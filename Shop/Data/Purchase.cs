using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data
{
    public class Purchase
    {
        public int Id { get; set; }

        [Display(Name = "کالا")]
        public int ItemId { get; set; }

        public Item Item { get; set; }

        public string OwnerId { get; set; }

        public IdentityUser Owner { get; set; }

        public virtual string Title { get { return Item == null? "" : Item.Title; } }

        [Display(Name = "تعداد")]
        [Range(1, double.MaxValue, ErrorMessage = "حداقل تعداد باید بزرگتر از صفر باشد")]
        public int Count { get; set; }

        [Display(Name = "قیمت")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:N0}")]
        [Range(0, double.MaxValue, ErrorMessage = "حداقل قیمت باید بزرگتر یا مساوی با صفر باشد")]
        public double Price { get; set; }

        [Display(Name = "قیمت کل")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:N0}")]
        public virtual double AllPrice { get { return Count * Price; } }

        [Display(Name = "وضعیت سفارش")]
        public PurchaseStatus Status { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data
{
    public class Item
    {
        public int Id { get; set; }

        [Display(Name = "عنوان")]
        public string Title { get; set; }

        [Display(Name = "توضیحات")]
        public string Description { get; set; }

        [Display(Name = "واحد")]
        public string Unit { get; set; }

        [Display(Name = "قیمت")]
        [Range(0, double.MaxValue, ErrorMessage ="حداقل قیمت باید بزرگتر یا مساوی با صفر باشد")]
        public double Price { get; set; }

        [Display(Name = "دسته بندی")]
        public int CategoryId { get; set; }

        [Display(Name = "دسته بندی")]
        public Category Category { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data
{
    public class Category
    {
        public int Id { get; set; }

        [Display(Name ="عنوان")]
        public string Title { get; set; }

        [Display(Name = "والد")]
        public int? ParentId { get; set; }

        [Display(Name = "والد")]
        public Category Parent { get; set; }

        public virtual string FullTitle { get {
                if (Parent == null)
                    return Title;
                else
                    return String.Format("{0} / {1}", Parent.FullTitle, Title);
            } }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetElites.Domain.Model.Members
{
    public class Member
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "نام")]
        [Required(ErrorMessage = " {0} را لطفا وارد کنید")]
        [MinLength(3, ErrorMessage = "{0} نباید از {1} کارکتر کمتر باشد")]
        [MaxLength(20, ErrorMessage = "{0} نباید از {1} کارکتر بیشتر باشد")]
        public string Name { get; private set; }
        [Display(Name = "سمت")]
        [Required(ErrorMessage = " {0} را لطفا وارد کنید")]
        [MinLength(3, ErrorMessage = "{0} نباید از {1} کارکتر کمتر باشد")]
        [MaxLength(20, ErrorMessage = "{0} نباید از {1} کارکتر بیشتر باشد")]
        public string Level { get; private set; }
        [Display(Name = "توضیحات")]
        [Required(ErrorMessage = " {0} را لطفا وارد کنید")]
        [MinLength(30, ErrorMessage = "{0} نباید از {1} کارکتر کمتر باشد")]
        public string Description { get; private set; }
        [Display(Name = "عکس")]
        [Required(ErrorMessage = " {0} را لطفا وارد کنید")]
        public string UrlImage { get; private set; }
        [Display(Name = "زمان عضو کردن اعضا")]
        public DateTime Created { get; private set; }
        public Member(string Name, string Level, string Description, string UrlImage)
        {
            this.Name = Name;
            this.Level = Level;
            this.Description = Description;
            this.UrlImage = UrlImage;
            this.Created = DateTime.Now;
        }
        #region Relations
        public virtual Seo Seo { get; private set; }
        #endregion
    }
}

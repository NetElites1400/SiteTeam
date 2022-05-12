using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetElites.Domain.Model.Articles;
using NetElites.Domain.Model.Users;
using NetElites.Domain.Model.Worksamples;

namespace NetElites.Domain.Model
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "توضیح کامنت")]
        [Required(ErrorMessage = " {0} را لطفا وارد کنید")]
        [MinLength(10, ErrorMessage = "{0} نباید از {1} کارکتر کمتر باشد")]
        [MaxLength(30, ErrorMessage = "{0} نباید از {1} کارکتر کمتر باشد")]
        public string FullName { get; set; }
        [Display(Name = "توضیح کامنت")]
        [Required(ErrorMessage = " {0} را لطفا وارد کنید")]
        [MinLength(10, ErrorMessage = "{0} نباید از {1} کارکتر کمتر باشد")]
        public string Description { get; private set; }
        [Display(Name = "زمان انتشار کامنت ")]
        public DateTime Created { get; private set; }
        public int ArticleId { get; private set; }
        public string UserId { get; private set; }
        public Comment(string Description, int ArticleId, string UserId)
        {
            this.Description = Description;
            this.ArticleId = ArticleId;
            this.UserId = UserId;
            this.Created = DateTime.Now;
        }
        #region Relations
        public virtual Article Article { get; private set; }
        public virtual User User { get; private set; }
        public virtual Worksample Worksample { get; private set; }
        #endregion
    }
}

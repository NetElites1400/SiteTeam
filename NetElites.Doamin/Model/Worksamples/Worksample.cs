using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetElites.Domain.Model.Worksamples
{
    public class Worksample
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "عنوان نمونه کار")]
        [Required(ErrorMessage = " {0} را لطفا وارد کنید")]
        [MinLength(3, ErrorMessage = "{0} نباید از {1} کارکتر کمتر باشد")]
        [MaxLength(20, ErrorMessage = "{0} نباید از {1} کارکتر بیشتر باشد")]
        public string Title { get; private set; }
        [Display(Name = "متن نمونه کار")]
        [Required(ErrorMessage = " {0} را لطفا وارد کنید")]
        [MinLength(30, ErrorMessage = "{0} نباید از {1} کارکتر کمتر باشد")]
        public string Description { get; private set; }
        [Display(Name = "زمان انتشار نمونه کار")]
        [Required(ErrorMessage = " {0} را لطفا وارد کنید")]
        public DateTime Created { get; private set; }
        [Display(Name = "نوع نمونه کار")]
        [Required(ErrorMessage = " {0} را لطفا وارد کنید")]
        [MinLength(3, ErrorMessage = "{0} نباید از {1} کارکتر کمتر باشد")]
        [MaxLength(20, ErrorMessage = "{0} نباید از {1} کارکتر بیشتر باشد")]
        public string Type { get; private set; }
        private readonly List<Comment> comments = new List<Comment>();
        public Worksample(string Title, string Description, string Type)
        {
            this.Title = Title;
            this.Description = Description;
            this.Type = Type;
            this.Created = DateTime.Now;
        }
        public void AddComment(string Description, int ArticleId, string UserId)
        {
            Comments.Add(new Comment(Description,ArticleId,UserId));
        }
        #region Relations
        public virtual Seo Seo { get; private set; }
        public virtual ICollection<Comment> Comments => comments;
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetElites.Domain.Model.Articles
{
    public class Article
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="عنوان مقاله")]
        [Required(ErrorMessage = " {0} را لطفا وارد کنید")]
        [MinLength(3, ErrorMessage = "{0} نباید از {1} کارکتر کمتر باشد")]
        [MaxLength(20, ErrorMessage = "{0} نباید از {1} کارکتر بیشتر باشد")]
        public string Title { get; private set; }
        [Display(Name = "متن مقاله")]
        [Required(ErrorMessage = " {0} را لطفا وارد کنید")]
        [MinLength(50, ErrorMessage = "{0} نباید از {1} کارکتر کمتر باشد")]
        public string Description { get; private set; }
        [Display(Name = "عکس مقاله")]
        [Required(ErrorMessage = " {0} را لطفا وارد کنید")]
        public string UrlImage { get; private set; }
        [Display(Name = "نویسنده مقاله")]
        [Required(ErrorMessage = " {0} را لطفا وارد کنید")]
        [MinLength(3, ErrorMessage = "{0} نباید از {1} کارکتر کمتر باشد")]
        [MaxLength(30, ErrorMessage = "{0} نباید از {1} کارکتر بیشتر باشد")]
        public string Author { get; private set; }
        [Display(Name = "زمان انتشار مقاله")]
        public DateTime Created { get; private set; }
        [Display(Name = "سطح مقاله")]
        [Required(ErrorMessage = " {0} را لطفا وارد کنید")]
        public Level Level { get; private set; }
        private readonly List<Comment> comments = new List<Comment>();
        public Article(string Title, string Description, string UrlImage, string Author, Level level)
        {
            this.Title = Title;
            this.Description = Description;
            this.UrlImage = UrlImage;
            this.Author = Author;
            this.Level = level;
            this.Created = DateTime.Now;
        }
        public void AddComment(string Description, int ArticleId, string UserId)
        {
            Comments.Add(new Comment(Description,ArticleId,UserId));
        }
        #region Relations
        public virtual ICollection<Comment> Comments => comments;
        public virtual Seo Seo { get; private set; }
        #endregion
    }
    public enum Level
    {
        Easy = 0,
        Medium = 1,
        Hard = 2,
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetElites.Domain.Model.Users
{
    public class Token
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="توکن")]
        public string HashToken { get; private set; }
        [Display(Name ="زمان توکن")]
        public DateTime TokenExpiry { get; private set; }
        [Display(Name ="رفرش توکن")]
        public string RefreshToken { get; private set; }
        [Display(Name ="زمان رفرش توکن")]
        public DateTime RefreshTokenExpiry { get; private set; }
        public string UserId { get; private set; }
        public Token(string HashToken, string RefreshToken, string UserId)
        {
            this.HashToken = HashToken;
            this.RefreshToken = RefreshToken;
            this.UserId = UserId;
            this.TokenExpiry = DateTime.Now;
            this.RefreshTokenExpiry = DateTime.Now;
        }
        #region Relations
        public virtual User User { get; private set; }
        #endregion
    }
}

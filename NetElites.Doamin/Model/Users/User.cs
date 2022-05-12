using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace NetElites.Domain.Model.Users
{
    public class User:IdentityUser
    {
        [Display(Name = "فعال سازی")]
        public bool IsActive { get; set; }
        private readonly List<Token> tokens = new List<Token>();
        public void AddToken(string HashToken, string RefreshToken, string UserId)
        {
            Tokens.Add(new Token(HashToken,RefreshToken,UserId));
        }
        #region Relations
        public virtual ICollection<Token> Tokens => tokens;
        #endregion
    }
}

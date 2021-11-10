using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.Domain.Models
{
    public class CryptedPassword : DomainObject
    {
        public string Password { get; set; }

        public SocialNetwork SocialNetwork { get; set; }
    }
}

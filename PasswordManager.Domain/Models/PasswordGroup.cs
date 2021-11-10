using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.Domain.Models
{
    public class PasswordGroup : DomainObject
    {
        public ICollection<CryptedPassword> CryptedPasswords { get; set; }

        public string PasswordOfGroup { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.Domain.Models
{
    public class SavedAccount : DomainObject
    { 
        public string ServiceName { get; set; }

        public string Username { get; set; }

        public string CryptedPassword { get; set; }
    }
}

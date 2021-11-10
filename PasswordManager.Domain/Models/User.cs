using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.Domain.Models
{
    public class User : DomainObject
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public DateTime DateJoined { get; set; }
    }
}

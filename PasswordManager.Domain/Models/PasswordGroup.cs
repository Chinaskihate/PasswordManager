using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.Domain.Models
{
    public class PasswordGroup : DomainObject
    {
        public Account Account { get; set; }

        public string Name { get; set; }

        public ICollection<SavedAccount> SavedAccounts { get; set; }

        public string PasswordOfGroupHash { get; set; }
    }
}
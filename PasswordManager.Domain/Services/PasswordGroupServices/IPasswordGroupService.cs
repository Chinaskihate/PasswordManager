using PasswordManager.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.Domain.Services.PasswordGroupServices
{
    public enum PasswordGroupCreateResult
    {
        Success,
        PasswordsDoNotMatch,
        NameAlreadyExists
    }

    public interface IPasswordGroupService
    {
        public Task<PasswordGroupCreateResult> AddPasswordGroup(Account account, string name, string password, string confirmPassword);

        public Task<Account> RemovePasswordGroup(Account account, string name);

        public Task<Account> ChangePasswordGroupName(Account account, string oldName, string newName);
    }
}

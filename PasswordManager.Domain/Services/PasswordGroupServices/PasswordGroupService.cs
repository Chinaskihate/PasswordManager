using Microsoft.AspNet.Identity;
using PasswordManager.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.Domain.Services.PasswordGroupServices
{
    public class PasswordGroupService : IPasswordGroupService
    {
        private readonly IDataService<Account> _accountDataService;
        private readonly IDataService<PasswordGroup> _passwordDataService;
        private readonly IPasswordHasher _passwordHasher;

        public PasswordGroupService(IDataService<Account> accountDataService,
            IDataService<PasswordGroup> passwordDataService, IPasswordHasher passwordHasher)
        {
            _accountDataService = accountDataService;
            _passwordHasher = passwordHasher;
            _passwordDataService = passwordDataService;
        }

        public async Task<PasswordGroupCreateResult> AddPasswordGroup(Account account, string name,
            string password, string confirmPassword)
        {
            if (account.PasswordGroups.Any(x => x.Name == name))
            {
                return PasswordGroupCreateResult.NameAlreadyExists;
            }
            if (password != confirmPassword)
            {
                return PasswordGroupCreateResult.PasswordsDoNotMatch;
            }
            var group = new PasswordGroup()
            {
                Name = name,
                PasswordOfGroupHash = _passwordHasher.HashPassword(password)
            };
            account.PasswordGroups.Add(group);

            await _accountDataService.Update(account.Id, account);

            return PasswordGroupCreateResult.Success;
        }

        public async Task<Account> ChangePasswordGroupName(Account account, string oldName, string newName)
        {
            if (account.PasswordGroups.Any(x => x.Name == newName))
            {
                // what should i do?
                throw new NotImplementedException();
            }
            var group = account.PasswordGroups.FirstOrDefault(x => x.Name == oldName);
            group.Name = newName;

            await _passwordDataService.Update(group.Id, group);

            return account;
        }

        public async Task<Account> RemovePasswordGroup(Account account, string name)
        {
            if (!account.PasswordGroups.Any(x => x.Name == name))
            {
                // what should i do?
                throw new NotImplementedException();
            }
            var group = account.PasswordGroups.First(x => x.Name == name);
            account.PasswordGroups.Remove(group);

            await _accountDataService.Update(account.Id, account);

            return account;
        }

        // TODO: add changing of password
    }
}

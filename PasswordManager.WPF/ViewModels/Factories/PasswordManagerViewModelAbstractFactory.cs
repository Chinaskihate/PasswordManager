using PasswordManager.WPF.State.Navigators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.WPF.ViewModels.Factories
{
    public class PasswordManagerViewModelAbstractFactory : IPasswordManagerViewModelAbstractFactory
    {
        private readonly IPasswordManagerViewModelFactory<GroupsViewModel> _groupsViewModelFactory;
        private readonly IPasswordManagerViewModelFactory<AccountsViewModel> _accountsViewModelFactory;
        private readonly IPasswordManagerViewModelFactory<AboutViewModel> _aboutViewModelFactory;

        public PasswordManagerViewModelAbstractFactory(
            IPasswordManagerViewModelFactory<GroupsViewModel> groupsViewModelFactory, IPasswordManagerViewModelFactory<AccountsViewModel> accountsViewModelFactory, IPasswordManagerViewModelFactory<AboutViewModel> aboutViewModelFactory)
        {
            _groupsViewModelFactory = groupsViewModelFactory;
            _accountsViewModelFactory = accountsViewModelFactory;
            _aboutViewModelFactory = aboutViewModelFactory;
        }

        public BaseViewModel CreateViewModel(ViewType viewType)
        {
            switch (viewType)
            {
                case ViewType.Groups:
                    return _groupsViewModelFactory.CreateViewModel();
                case ViewType.Accounts:
                    return _accountsViewModelFactory.CreateViewModel();
                case ViewType.About:
                    return _aboutViewModelFactory.CreateViewModel();
                default:
                    throw new ArgumentException("The ViewType does not have a ViewModel.", "viewType");
            }
        }
    }
}

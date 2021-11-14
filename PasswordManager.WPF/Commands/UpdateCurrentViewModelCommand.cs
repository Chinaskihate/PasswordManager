using PasswordManager.WPF.State.Navigators;
using PasswordManager.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PasswordManager.WPF.Commands
{
    public class UpdateCurrentViewModelCommand : ICommand
    {
        private INavigator _navigator;

        public UpdateCurrentViewModelCommand(INavigator navigator)
        {
            _navigator = navigator;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter is ViewType)
            {
                var viewType = (ViewType)parameter;
                switch (viewType)
                {
                    case ViewType.Groups:
                        _navigator.CurrentViewModel = new GroupsViewModel();
                        break;
                    case ViewType.Accounts:
                        _navigator.CurrentViewModel = new AccountsViewModel();
                        break;
                    case ViewType.About:
                        _navigator.CurrentViewModel = new AboutViewModel();
                        break;
                }
            }
        }
    }
}
using PasswordManager.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PasswordManager.WPF.State.Navigators
{
    public enum ViewType
    {
        Groups,
        Accounts,
        About
    }

    public interface INavigator
    {
        BaseViewModel CurrentViewModel { get; set; }
    
        ICommand UpdateCurrentViewModelCommand { get; }
    }
}

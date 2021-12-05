using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.WPF.ViewModels.Factories
{
    public interface IPasswordManagerViewModelFactory<T> where T : BaseViewModel
    {
        T CreateViewModel();
    }
}

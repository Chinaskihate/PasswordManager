using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.WPF.ViewModels.Factories
{
    public class AboutViewModelFactory : IPasswordManagerViewModelFactory<AboutViewModel>
    {
        public AboutViewModel CreateViewModel()
        {
            return new AboutViewModel();
        }
    }
}

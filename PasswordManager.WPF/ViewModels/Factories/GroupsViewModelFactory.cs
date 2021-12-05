using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.WPF.ViewModels.Factories
{
    public class GroupsViewModelFactory : IPasswordManagerViewModelFactory<GroupsViewModel>
    {
        public GroupsViewModel CreateViewModel()
        {
            return new GroupsViewModel();
        }
    }
}

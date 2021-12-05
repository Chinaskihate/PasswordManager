using Microsoft.AspNet.Identity;
using PasswordManager.Domain.Models;
using PasswordManager.Domain.Services.AuthenticationServices;
using PasswordManager.Domain.Services.PasswordGroupServices;
using PasswordManager.EntityFramework;
using PasswordManager.EntityFramework.Services;
using PasswordManager.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace PasswordManager.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            IAuthenticationService service = new AuthenticationService(new AccountDataService(new PasswordManagerDbContextFactory()), new PasswordHasher());
            var account = service.Login("test", "test");

            var window = new MainWindow();
            window.DataContext = new MainViewModel();
            window.Show();

            base.OnStartup(e);
        }
    }
}

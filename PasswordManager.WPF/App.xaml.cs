using Microsoft.AspNet.Identity;
using Microsoft.Extensions.DependencyInjection;
using PasswordManager.Domain.Models;
using PasswordManager.Domain.Services;
using PasswordManager.Domain.Services.AuthenticationServices;
using PasswordManager.Domain.Services.PasswordGroupServices;
using PasswordManager.EntityFramework;
using PasswordManager.EntityFramework.Services;
using PasswordManager.WPF.State.Navigators;
using PasswordManager.WPF.ViewModels;
using PasswordManager.WPF.ViewModels.Factories;
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
            IServiceProvider serviceProvider = CreateServiceProvider();
            var authService = serviceProvider.GetRequiredService<IAuthenticationService>();
            var account = authService.Login("test", "test");

            var window = new MainWindow();
            window.DataContext = serviceProvider.GetRequiredService<MainViewModel>();
            window.Show();
            base.OnStartup(e);
        }

        private IServiceProvider CreateServiceProvider()
        {
            IServiceCollection services = new ServiceCollection();

            services.AddSingleton<PasswordManagerDbContextFactory>();
            services.AddSingleton<IDataService<PasswordGroup>, GenericDataService<PasswordGroup>>();
            services.AddSingleton<IAccountService, AccountDataService>();
            services.AddSingleton<IPasswordHasher, PasswordHasher>();
            services.AddSingleton<IAuthenticationService, AuthenticationService>();
            services.AddSingleton<IPasswordGroupService, PasswordGroupService>();

            services.AddSingleton<IPasswordManagerViewModelAbstractFactory, PasswordManagerViewModelAbstractFactory>();
            services.AddSingleton<IPasswordManagerViewModelFactory<GroupsViewModel>, GroupsViewModelFactory>();
            services.AddSingleton<IPasswordManagerViewModelFactory<AccountsViewModel>, AccountsViewModelFactory>();
            services.AddSingleton<IPasswordManagerViewModelFactory<AboutViewModel>, AboutViewModelFactory>();

            services.AddScoped<INavigator, Navigator>();
            services.AddScoped<MainViewModel>();

            return services.BuildServiceProvider();
        }
    }
}

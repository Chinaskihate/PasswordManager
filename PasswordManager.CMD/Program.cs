using PasswordManager.Domain.Models;
using PasswordManager.Domain.Services;
using PasswordManager.EntityFramework;
using PasswordManager.EntityFramework.Services;
using System;
using System.Linq;

namespace PasswordManager.CMD
{
    class Program
    {
        static void Main(string[] args)
        {
            IDataService<User> userService = new GenericDataService<User>(new PasswordManagerDbContextFactory());
            userService.Create(new User());
            Console.WriteLine(userService.GetAll().Result);
            Console.ReadLine();
        }
    }
}

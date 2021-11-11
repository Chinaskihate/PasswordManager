using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.EntityFramework
{
    public class PasswordManagerDbContextFactory : IDesignTimeDbContextFactory<PasswordManagerDbContext>
    {
        public PasswordManagerDbContext CreateDbContext(string[] args = null)
        {
            var options = new DbContextOptionsBuilder<PasswordManagerDbContext>();
            options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=PasswordManager;Trusted_Connection=True;");

            return new PasswordManagerDbContext(options.Options);
        }
    }
}

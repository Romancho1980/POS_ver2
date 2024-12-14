using Console_Server.Models.Entities.SimpleEntities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Server.Context
{
    internal class ApplicationContext:DbContext
    {
        public DbSet<SimpleClientAccount> Clients => Set<SimpleClientAccount>();
        public ApplicationContext()
        {
            var ser = Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Bank.db");
        }
    }
}

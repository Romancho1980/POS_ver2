using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI_Serial_Port_Server.Domain.Models.SimpleModels;

namespace UI_Serial_Port_Server.Domain.Context
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<ClientAccountVer1> clients => Set<ClientAccountVer1>();
        public ApplicationDbContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Bank25.db");
        }



    }

   
}




//public DbSet<SimpleClientAccount> Clients => Set<SimpleClientAccount>();
//public ApplicationContext()
//{
//    Database.EnsureCreated();
//}

//protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//{
//    optionsBuilder.UseSqlite("Data Source=Bank.db");
//}
using Console_Sever_Complex.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Sever_Complex.Context
{
    internal class ApplicationContext:DbContext
    {
        public DbSet<Address> adress => Set<Address>();
   //     public DbSet<BankClientsAccount> bankClients => Set<BankClientsAccount>();
        public DbSet<CardAccount> cardAccount => Set<CardAccount>();
        public DbSet<Client> client => Set<Client>();
        public ApplicationContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Bank_Complex.db");
        }
    }
}

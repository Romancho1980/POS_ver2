using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Server.Models.Entities.SimpleEntities
{
    // сущность для БД
    // На данном этапе пока только одна таблица

    internal class SimpleClientAccount
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Surname { get; set; }
        public string INN { get; set; }
        public string City { get; set; }
        public string Passport { get; set; }
        public DateTime Birthday { get; set; }
        public string Account { get; set; }
        public decimal Balance { get; set; }
        public string Description { get; set; }
    }
}

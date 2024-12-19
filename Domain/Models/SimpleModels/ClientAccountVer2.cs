using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.SimpleModels
{
    public class ClientAccountVer2
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string INN { get; set; }
        public string City { get; set; }
        public string Passport { get; set; }
        public DateTime Birthday { get; set; }
        public List<CardAccount> Account;
        public string Description { get; set; }
    }
}

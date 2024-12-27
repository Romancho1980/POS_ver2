using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.SimpleModels
{
    public class ClientAccountVer1
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public string INN { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Passport { get; set; } = string.Empty;
        public DateTime Birthday { get; set; } 
        public string Account { get; set; } = string.Empty;
        public decimal Balance { get; set; }
        public string Description { get; set; } = string.Empty;
    }
}

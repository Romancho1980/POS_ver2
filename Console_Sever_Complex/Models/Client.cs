using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Console_Sever_Complex.Models
{
    internal class Client
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public string INN { get; set; } = string.Empty;
        public string Passport { get; set; } = string.Empty;
        public DateTime BirthDay { get; set; }
        public Address Address { get; set; }
        public List<CardAccount> Account { get; set; }
        public string Description { get; set; } = string.Empty;
    }
}

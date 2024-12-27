using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Sever_Complex.Models
{
    internal class BankClientsAccount
    {
        //public int Id { get; set; }

        [Key, Column(Order = 0)]
        public Client ClientId { get; set; }

        [Key, Column(Order = 1)]
        public CardAccount AccountId { get; set; }
    }
}

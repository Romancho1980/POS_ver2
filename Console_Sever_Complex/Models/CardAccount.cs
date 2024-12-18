using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Sever_Complex.Models
{
    internal class CardAccount
    {
        [Key]
        public string Account { get; set; } = string.Empty;
        public string TypeAccount { get; set; } = string.Empty;
        public decimal Balance { get; set; }
        public DateTime CreateDate { get; set; }
        public string Description { get; set; } = string.Empty;
        public Client ClientId { get; set; }
    }
}

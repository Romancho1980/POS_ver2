using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Sever_Complex.Models
{
    internal class Address
    {
        [Key]
        public int RegionId {  get; set; }
        public string? Oblast { get; set; } = string.Empty;
        public string? Region { get; set; } = string.Empty;
        public string? City { get; set; } = string.Empty;
        public string? Street { get; set; } = string.Empty;
        public string? House_number { get; set; } = string.Empty;
        public string? Kvartira { get; set; } = string.Empty;
    }
}

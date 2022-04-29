using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace SpringHeroBankClient.Models
{
    public class Account
    {
        [Key]
        [Required]
        public string AccountNumber { get; set; }

        public double Balance { get; set; }

        [Required]
        public string SecurityCode { get; set; }

        public int Status { get; set; }

        public string Token { get; set; }
    }
}
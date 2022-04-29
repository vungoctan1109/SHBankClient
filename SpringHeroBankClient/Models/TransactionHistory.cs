using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SpringHeroBankClient.Models
{
    public class TransactionHistory
    {
        public string Id { get; set; }

        public int Type { get; set; }

        [Required]
        public double Amount { get; set; }

        public string SenderAccountNumber { get; set; }

        [Required]
        public string ReceiverAccountNumber { get; set; }

        public int Status { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
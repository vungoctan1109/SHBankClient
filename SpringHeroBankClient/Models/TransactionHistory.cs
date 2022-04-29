using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpringHeroBankClient.Models
{
    public class TransactionHistory
    {
        public string Id { get; set; }

        public int Type { get; set; }

        public double Amount { get; set; }

        public string SenderAccountNumber { get; set; }

        public string ReceiverAccountNumber { get; set; }

        public int Status { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
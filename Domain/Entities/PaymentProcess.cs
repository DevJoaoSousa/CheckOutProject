using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class PaymentProcess
    {
        public long CardNumber { get; set; }
        public DateTime ExpiryDate { get; set; }
        public double Amount { get; set; }
        public string Currency { get; set; }
        public string CVV { get; set; }
    }
}

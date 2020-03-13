using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class PaymentProcess
    {
        public string CardName { get; set; }
        public long CardNumber { get; set; }
        public string MaskedNumber { get; set; }
        public DateTime ExpiryDate { get; set; }
        public double Amount { get; set; }
        public string Currency { get; set; }
        public int CVV { get; set; }
        public string Guid { get; set; }
        public string Status { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace BankService
{
    public class ResponseModel
    {
        public Guid Guid { get; set; }
        public ResponseType ResponseStatus { get; set; }
        //public DateTime ExpiryDate { get; set; }
        //public string CVV { get; set; }
    }
}

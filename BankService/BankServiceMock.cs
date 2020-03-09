using Domain.Entities;
using System;

namespace BankService
{
    public class BankServiceMock : IBankService
    {
        public ResponseModel ProcessPayment(PaymentProcess payment)
        {
            var response = new ResponseModel();

            response.ResponseStatus = ResponseType.Success;
            response.Guid = Guid.NewGuid();
            
            return response;
        }

        private bool ValidateCardDetails(PaymentProcess payment)
        {
            return payment.Amount < 0 || payment.ExpiryDate < DateTime.UtcNow ? false : true;
        }
    }
}

using Domain.Entities;
using System;

namespace Services
{
    public class ValidationService : IValidationService
    {
        /// <summary>
        /// Not allow negative amounts and expiry dates longer than actual time
        /// </summary>
        /// <param name="payment"></param>
        /// <returns></returns>
        public bool ValidateProcess(PaymentProcess payment)
        {
            return payment.Amount < 0 || payment.ExpiryDate < DateTime.UtcNow ? false : true;
        }
    }
}

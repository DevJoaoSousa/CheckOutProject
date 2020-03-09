using Domain.Entities;
using System.Collections.Generic;

namespace Services
{
    public interface ICustomerService
    {
        IEnumerable<PaymentProcess> GetAllPayments();
        bool ValidateProcess(PaymentProcess payment);
        void ProcessPayment(PaymentProcess payment);
    }
}
using Domain.Entities;
using System.Collections.Generic;

namespace Services
{
    public interface ICustomerService
    {
        IEnumerable<PaymentProcess> GetAllPayments();
        void ProcessPayment(PaymentProcess payment);
    }
}
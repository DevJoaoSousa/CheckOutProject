using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Repository
{
    public interface IRepository
    {
        IEnumerable<PaymentProcess> GetAllPayments();
        void ProcessPayment(PaymentProcess payment);
    }
}

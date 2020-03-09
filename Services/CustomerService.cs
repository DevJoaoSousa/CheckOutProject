using Domain.Entities;
using Infrastructure.Factory;
using Infrastructure.Repository;
using System;
using System.Collections.Generic;

namespace Services
{
    public class CustomerService : ICustomerService
    {
        private readonly IRepository _repository;

        public CustomerService(IRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<PaymentProcess> GetAllPayments()
        {
            return _repository.GetAllPayments();
        }

        /// <summary>
        /// Not allow negative amounts and expiry dates longer than actual time
        /// </summary>
        /// <param name="payment"></param>
        /// <returns></returns>
        public bool ValidateProcess(PaymentProcess payment)
        {
            return payment.Amount < 0 || payment.ExpiryDate < DateTime.UtcNow ? false : true;
        }

        public void ProcessPayment(PaymentProcess payment)
        {
            _repository.ProcessPayment(payment);
        }
    }
}

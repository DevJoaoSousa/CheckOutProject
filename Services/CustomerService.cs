using BankService;
using Domain.Entities;
using Infrastructure.Factory;
using Infrastructure.Repository;
using Services.Utils;
using System;
using System.Collections.Generic;

namespace Services
{
    public class CustomerService : ICustomerService
    {
        private readonly IBankService _bankservice;
        private readonly IRepository _repository;

        public CustomerService(IRepository repository, IBankService bankService)
        {
            _repository = repository;
            _bankservice = bankService;
        }

        public IEnumerable<PaymentProcess> GetAllPayments()
        {
            return _repository.GetAllPayments();
        }


        public void ProcessPayment(PaymentProcess payment)
        {
            var response = _bankservice.ProcessPayment(payment);

            payment.Status = response.ResponseStatus.ToString();
            payment.Guid = response.Guid.ToString();
            payment.MaskedNumber = MaskingCardNumber.Mask(payment.CardNumber.ToString(), 0, 12);

            _repository.ProcessPayment(payment);
        }

    }
}


using BankService.Factory;
using Domain.Entities;
using System;

namespace BankService
{
    public class BankServiceMock : IBankService
    {
        private readonly IResponseFactory _responseFactory;

        public BankServiceMock(IResponseFactory responseFactory)
        {
            _responseFactory = responseFactory;
        }

        public ResponseModel ProcessPayment(PaymentProcess payment)
        {
            return _responseFactory.create();
        }
    }
}

using Domain.Entities;
using Infrastructure.Factory;
using Dapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Repository
{
    public class Repository : IRepository
    {
        private readonly IConnectionFactory _connectionFactory;

        public Repository(IConnectionFactory connection)
        {
            _connectionFactory = connection;
        }

        public IEnumerable<PaymentProcess> GetAllPayments()
        {
            var queryGetAllPayments = RepositoryCommands.GetAllPayments;

            using (var connection = _connectionFactory.Create())
            {
                return connection.Query<PaymentProcess>(queryGetAllPayments);
            }
        }

        public void ProcessPayment(PaymentProcess payment)
        {
            var commandProcessPayment = RepositoryCommands.ProcessPayment;
            var args = new
            {
                CardN = payment.CardName,
                MaskedNumb = payment.MaskedNumber,
                ExpiryDat = payment.ExpiryDate,
                AmountPay = payment.Amount,
                Cur = payment.Currency,
                Cvv = payment.CVV,
                GeneratedId = payment.Guid,
                Stat = payment.Status
            };

            using (var connection = _connectionFactory.Create())
            {
                connection.Query<string>(commandProcessPayment, args);
            }
        }
    }
}

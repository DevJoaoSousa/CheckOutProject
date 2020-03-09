using Domain.Entities;

namespace BankService
{
    public interface IBankService
    {
        ResponseModel ProcessPayment(PaymentProcess payment);
    }
}
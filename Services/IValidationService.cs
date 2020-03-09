using Domain.Entities;

namespace Services
{
    public interface IValidationService
    {
        bool ValidateProcess(PaymentProcess payment);
    }
}
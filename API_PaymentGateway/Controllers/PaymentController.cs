using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace API_PaymentGateway.Controllers
{
    public class PaymentController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public PaymentController(ICustomerService service)
        {
            _customerService = service;
        }

        [HttpGet]
        [Route("api/payments")]
        public ActionResult<IEnumerable<PaymentProcess>> GetPaymentDetails()
        {
            var payments = _customerService.GetAllPayments();

            if (payments == null)
            {
                return NotFound();
            }

            return Ok(payments);
        }

        [HttpPost]
        [Route("api/processPayment")]
        public ActionResult ProcessPayment([FromBody] PaymentProcess payment)
        {
            if (payment == null || _customerService.ValidateProcess(payment) == false)
            {
                return NotFound();
            }

            _customerService.ProcessPayment(payment);

            return Ok(payment);
        }
    }
}
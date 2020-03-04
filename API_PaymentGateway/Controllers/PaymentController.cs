using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace API_PaymentGateway.Controllers
{
    public class PaymentController : Controller
    {
        [HttpGet]
        public IActionResult GetPaymentDetails()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ProcessPayment()
        {
            return View();
        }
    }
}
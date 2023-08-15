using CasgemMicroservice.Services.Payment.WebAPI.DAL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CasgemMicroservice.Services.Payment.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentsController : ControllerBase
    {
        private readonly PaymentContext _context;

        public PaymentsController(PaymentContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult PaymentList()
        {
            var values = _context.PaymentDetails.ToList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult PaymentCreate(PaymentDetail paymentDetail)
        {
            _context.PaymentDetails.Add(paymentDetail);
            return Ok("Ödeme yapıldı");
        }
    }
}
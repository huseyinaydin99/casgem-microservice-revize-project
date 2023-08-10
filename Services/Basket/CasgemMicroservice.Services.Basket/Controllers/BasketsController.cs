using CasgemMicroservice.Services.Basket.Services;
using CasgemMicroservice.Shared.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CasgemMicroservice.Services.Basket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketsController : ControllerBase
    {
        private readonly IBasketService _basketService;
        private readonly ISharedIdentityService _sharedIdentityService;

        public BasketsController(IBasketService basketService, ISharedIdentityService sharedIdentityService)
        {
            _basketService = basketService;
            _sharedIdentityService = sharedIdentityService;
        }


    }
}

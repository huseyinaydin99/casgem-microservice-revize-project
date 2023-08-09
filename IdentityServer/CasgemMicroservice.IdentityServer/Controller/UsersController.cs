using CasgemMicroservice.IdentityServer.DTOs;
using CasgemMicroservice.IdentityServer.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CasgemMicroservice.IdentityServer.Controller
{
    //[Authorize(LocalApi)]
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public UsersController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(SignUpDTO signUpDTO)
        {
            var user = new ApplicationUser
            {
                UserName = signUpDTO.Username,
                Email = signUpDTO.Email,
                City = signUpDTO.City,
                NameSurname = signUpDTO.NameSurname
            };
            var result = await _userManager.CreateAsync(user, signUpDTO.Password);
            return NoContent();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using RateForProfessor.Services.Interfaces;

namespace RateForProfessor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GoogleAuthenticationController : Controller
    {
        private readonly IGoogleAuthenticationService _googleAuthenticationService;
        public GoogleAuthenticationController(IGoogleAuthenticationService googleAuthenticationService)
        {
            _googleAuthenticationService = googleAuthenticationService;
        }
        public async Task LogIn()
        {
            
        }
    }
}

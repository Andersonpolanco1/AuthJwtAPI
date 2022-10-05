using JwtAPI.Models;
using JwtAPI.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JwtAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        public ApplicationDbContext _dbContext;

        public LoginController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [Route("users")]
        [HttpGet]
        public async Task<IActionResult> Users()
        {
            return Ok( await _dbContext.Users.ToListAsync());
        }

        [HttpPost]
        public IActionResult Login(UserLogin userLogin)
        {
            if (userLogin == null)
            {
                return NotFound();
            }
            return  Ok("Logged");
        }
    }
}

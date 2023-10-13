using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectMgtSystemApi.Models;
namespace ProjectMgtSystemApi.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly DataContext _context;
        public UsersController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {
            var users = await _context.Users
                        .Include(p => p.Projects)
                        .ToListAsync();

            return Ok(users);
        }

        [HttpPost]
        public async Task<IActionResult> AddUsers([FromBody] Users users){
            var user = new Users{
                Name = users.Name,
                Email = users.Email,
                Password = users.Password,
                Role = users.Role,
            };

            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();

            return Created("", user);
        }
    }
}
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("Api/[Controller]")]//api/users
    public class UsersController
    {
        private readonly DataContext _context;

        public UsersController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async  Task<ActionResult<IEnumerable<AppUser>>> GetUsers(){
        var users=await _context.Users.ToListAsync();
        return users;
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<AppUser>> GetUsers(int id){
        var user=await _context.Users.FindAsync(id);
        return user;
        } 
    }
}
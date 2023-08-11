using AppMovilAPI.Data;
using AppMovilAPI.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace AppMovilAPI.Services
{
    public class UserService : IUserService
    {
        private readonly AppMovilDbContext _context;


        public UserService(AppMovilDbContext context)
        {
            _context = context;
        }

        public async Task<User>? GetUserAsync(string username, string password)
        {
            if (_context.Users == null)
            {
                return null;
            }
            var user = await _context.Users.FirstOrDefaultAsync(user => user.UserName == username && user.Password == password);

            return user;
        }
    }
}

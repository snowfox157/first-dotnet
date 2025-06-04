using DotnetFirst.Models;
using DotnetFirst.Data;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace DotnetFirst.Services
{
    public class UserService : IUserService
    {
        private readonly AppDbContext _context;

        public UserService(AppDbContext context)
        {
            _context = context;   
        }     
        public User? GetUserById(int id)
        {
            return _context.User.FirstOrDefault(u => u.usrsid == id);
        }
    }
}
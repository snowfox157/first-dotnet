using DotnetFirst.Models;

namespace DotnetFirst.Services
{
    public interface IUserService
    {
        User? GetUserById(int id);
    }

}
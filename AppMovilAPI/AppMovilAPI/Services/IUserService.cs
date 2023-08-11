using AppMovilAPI.Data.Models;

namespace AppMovilAPI.Services
{
    public interface IUserService
    {
        Task<User>? GetUserAsync(string username, string password);
    }
}

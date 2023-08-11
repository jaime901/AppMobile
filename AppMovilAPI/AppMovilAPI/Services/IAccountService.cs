using AppMovilAPI.Data.Models;

namespace AppMovilAPI.Services
{
    public interface IAccountService
    {
        string GenerateJwtToken(User user);
    }
}

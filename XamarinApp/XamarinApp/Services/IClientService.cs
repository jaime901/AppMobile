
using XamarinApp.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace XamarinApp.Services
{
    public interface IClientService
    {
        Task<List<Client>> GetClients();
    }
}

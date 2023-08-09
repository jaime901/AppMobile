using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;
using XamarinApp.Data.Models;

namespace XamarinApp.Data.API
{
    public interface IClientApi
    {
        [Get("/Clients")]
        Task<List<Client>> GetClients();
    }

}

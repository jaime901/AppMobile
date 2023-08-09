using XamarinApp.Data.API;
using XamarinApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace XamarinApp.Services
{
    public class ClientService : IClientService
    {
        private readonly IClientApi _clientApi;
        public ClientService(IClientApi clientApi)
        {
            _clientApi = clientApi;
        }

        public async Task<List<Client>> GetClients()
        {
            var clients = new List<Client>();
            try
            {
                var response = await _clientApi.GetClients();
                clients = response.ToList();
                return clients;
            }
            catch (Exception ex)
            {
                var error = ex.Message;
            }
            return clients;
        }
    }
}

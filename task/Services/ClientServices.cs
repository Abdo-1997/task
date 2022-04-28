using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using task.repositories;
using task.Models;
using System.Threading.Tasks;
using task.ViewModels;

namespace task.Services
{
    public class ClientServices
    {
        private readonly Repository<Client> _clientrepo = new Repository<Client>();

        #region Get All Client
        public async Task<IEnumerable<Client>> GetAllClients()
        {
            return await _clientrepo.GetAll();
        }
        #endregion

        #region Delete
        public async Task Delete(int id)
        {
             await _clientrepo.Delete(id);
        }
        #endregion

        #region insert
        public async Task Add(AddCustomerViewModel newcustomer)

        {
            Client client = new Client()
            {
                name = newcustomer.CustomerName
            };
           await _clientrepo.add(client);
         
        }
        #endregion
    }
}
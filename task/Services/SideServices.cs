using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using task.Models;
using task.repositories;
using task.ViewModels;

namespace task.Services
{
    public class SideServices
    {
        private readonly Repository<ReceivingSide> _clientrepo = new Repository<ReceivingSide>();
        public async Task<IEnumerable<ReceivingSide>> GetAllClients()
        {
            return await _clientrepo.GetAll();
        }
        public async Task Delete(int id)
        {
            await _clientrepo.Delete(id);
        }
        public async Task Add(AddSidesViewModel newside)

        {
            ReceivingSide sides = new ReceivingSide()
            {
                name = newside.SideName
            };
            await _clientrepo.add(sides);

        }
    }
}
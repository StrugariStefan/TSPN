using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarServiceAPI.Model;

namespace CarServiceAPI.Repository.Write
{
    public class WriteClientRepository : IWriteClientRepository
    {
        private readonly Model1Container _dbContainer;

        public WriteClientRepository(Model1Container dbContainer)
        {
            _dbContainer = dbContainer;
        }

        public void Create(Client entity)
        {
            _dbContainer.Clients.Add(entity);
        }

        public void Delete(int id)
        {
            var client = _dbContainer.Clients.First(c => c.ClientId == id);
            _dbContainer.Clients.Remove(client);
        }

        public void Update(Client entity)
        {
            _dbContainer.Entry(entity).State = EntityState.Modified;
        }

        public bool Exists(int id)
        {
            return _dbContainer.Clients.Any(c => c.ClientId == id);
        }

        public void SaveChanges()
        {
            _dbContainer.SaveChanges();
        }
    }
}

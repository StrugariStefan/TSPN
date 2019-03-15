using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CarServiceAPI.Model;

namespace CarServiceAPI.Repository.Read
{
    public class ReadClientRepository : IReadClientRepository
    {
        private readonly Model1Container _dbContainer;

        public ReadClientRepository(Model1Container dbContainer)
        {
            _dbContainer = dbContainer;
        }

        public Client GetById(int id)
        {
            return _dbContainer.Clients.FirstOrDefault(c => c.ClientId == id);
        }

        public IReadOnlyList<Client> GetAll()
        {
            return _dbContainer.Clients.ToList();
        }

        public bool Exists(int id)
        {
            return _dbContainer.Clients.Any(c => c.ClientId == id);
        }

        public IReadOnlyList<Client> GetByCondition(Expression<Func<Client, bool>> expression)
        {
            return _dbContainer.Clients.Where(expression).ToList();
        }

        public Client GetByAutoId(int autoId)
        {
            return _dbContainer.Clients.FirstOrDefault(c => c.Autoes.FirstOrDefault(a => a.AutoId == autoId) != null);
        }
    }
}

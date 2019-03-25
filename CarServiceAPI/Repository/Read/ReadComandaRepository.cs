using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CarServiceAPI.Model;

namespace CarServiceAPI.Repository.Read
{
    public class ReadComandaRepository : IReadComandaRepository
    {
        private readonly Model1Container _dbContainer;

        public ReadComandaRepository(Model1Container container)
        {
            _dbContainer = container;
        }

        public Comanda GetById(int id)
        {
            return _dbContainer.Comandas.FirstOrDefault(c => c.ComandaId == id);
        }

        public List<Comanda> GetAll()
        {
            return _dbContainer.Comandas.ToList();
        }

        public bool Exists(int id)
        {
            return _dbContainer.Comandas.Any(c => c.ComandaId == id);
        }

        public IReadOnlyList<Comanda> GetByCondition(Expression<Func<Comanda, bool>> expression)
        {
            return _dbContainer.Comandas.Where(expression).ToList();
        }

        public IReadOnlyList<Comanda> GetByClientId(int clientId)
        {
            return _dbContainer.Comandas.Where(c => c.Client.ClientId == clientId).ToList();
        }

        public IReadOnlyList<Comanda> GetByAutoId(int autoId)
        {
            return _dbContainer.Comandas.Where(c => c.Auto.AutoId == autoId).ToList();
        }

        public IReadOnlyList<Comanda> GetByStare(Stare stare)
        {
            return _dbContainer.Comandas.Where(c => c.StareComanda == stare).ToList();
        }
    }
}

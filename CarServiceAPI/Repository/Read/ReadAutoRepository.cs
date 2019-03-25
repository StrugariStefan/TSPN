using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CarServiceAPI.Model;

namespace CarServiceAPI.Repository.Read
{
    public class ReadAutoRepository : IReadAutoRepository
    {
        private readonly Model1Container _dbContainer;

        public ReadAutoRepository(Model1Container container)
        {
            _dbContainer = container;
        }

        public Auto GetById(int id)
        {
            return _dbContainer.Autoes.FirstOrDefault(a => a.AutoId == id);
        }

        public List<Auto> GetAll()
        {
            return _dbContainer.Autoes.ToList();
        }

        public bool Exists(int id)
        {
            return _dbContainer.Autoes.Any(a => a.AutoId == id);
        }

        public IReadOnlyList<Auto> GetByCondition(Expression<Func<Auto, bool>> expression)
        {
            return _dbContainer.Autoes.Where(expression).ToList();
        }

        public Auto GetBySasiuId(int sasiuId)
        {
            return _dbContainer.Autoes.FirstOrDefault(a => a.Sasiu.SasiuId == sasiuId);
        }
    }
}

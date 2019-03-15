using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CarServiceAPI.Model;

namespace CarServiceAPI.Repository.Read
{
    public class ReadSasiuRepository : IReadSasiuRepository
    {
        private readonly Model1Container _dbContainer;

        public ReadSasiuRepository(Model1Container dbContainer)
        {
            _dbContainer = dbContainer;
        }

        public Sasiu GetById(int id)
        {
            return _dbContainer.Sasius.FirstOrDefault(s => s.SasiuId == id);
        }

        public IReadOnlyList<Sasiu> GetAll()
        {
            return _dbContainer.Sasius.ToList();
        }

        public bool Exists(int id)
        {
            return _dbContainer.Sasius.Any(s => s.SasiuId == id);
        }

        public IReadOnlyList<Sasiu> GetByCondition(Expression<Func<Sasiu, bool>> expression)
        {
            return _dbContainer.Sasius.Where(expression).ToList();
        }
    }
}

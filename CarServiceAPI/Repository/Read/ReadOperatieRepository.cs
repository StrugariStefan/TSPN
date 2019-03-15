using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CarServiceAPI.Model;

namespace CarServiceAPI.Repository.Read
{
    public class ReadOperatieRepository : IReadOperatieRepository
    {
        private readonly Model1Container _dbContainer;

        public ReadOperatieRepository(Model1Container dbContainer)
        {
            _dbContainer = dbContainer;
        }

        public Operatie GetById(int id)
        {
            return _dbContainer.Operaties.FirstOrDefault(o => o.OperatieId == id);
        }

        public IReadOnlyList<Operatie> GetAll()
        {
            return _dbContainer.Operaties.ToList();
        }

        public bool Exists(int id)
        {
            return _dbContainer.Operaties.Any(o => o.OperatieId == id);
        }

        public IReadOnlyList<Operatie> GetByCondition(Expression<Func<Operatie, bool>> expression)
        {
            return _dbContainer.Operaties.Where(expression).ToList();
        }
    }
}

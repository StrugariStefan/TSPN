using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CarServiceAPI.Model;

namespace CarServiceAPI.Repository.Read
{
    public class ReadMecanicRepository : IReadMecanicRepository
    {
        private readonly Model1Container _dbContainer;

        public ReadMecanicRepository(Model1Container dbContainer)
        {
            _dbContainer = dbContainer;
        }

        public Mecanic GetById(int id)
        {
            return _dbContainer.Mecanics.FirstOrDefault(m => m.MecanicId == id);
        }

        public IReadOnlyList<Mecanic> GetAll()
        {
            return _dbContainer.Mecanics.ToList();
        }

        public bool Exists(int id)
        {
            return _dbContainer.Mecanics.Any(m => m.MecanicId == id);
        }

        public IReadOnlyList<Mecanic> GetByCondition(Expression<Func<Mecanic, bool>> expression)
        {
            return _dbContainer.Mecanics.Where(expression).ToList();
        }
    }
}

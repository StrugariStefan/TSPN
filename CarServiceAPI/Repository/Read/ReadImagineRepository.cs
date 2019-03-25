using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CarServiceAPI.Model;

namespace CarServiceAPI.Repository.Read
{
    public class ReadImagineRepository : IReadImagineRepository
    {
        private readonly Model1Container _dbContainer;

        public ReadImagineRepository(Model1Container dbContainer)
        {
            _dbContainer = dbContainer;
        }

        public Imagine GetById(int id)
        {
            return _dbContainer.Imagines.FirstOrDefault(i => i.ImagineId == id);
        }

        public List<Imagine> GetAll()
        {
            return _dbContainer.Imagines.ToList();
        }

        public bool Exists(int id)
        {
            return _dbContainer.Imagines.Any(i => i.ImagineId == id);
        }

        public IReadOnlyList<Imagine> GetByCondition(Expression<Func<Imagine, bool>> expression)
        {
            return _dbContainer.Imagines.Where(expression).ToList();
        }
    }
}

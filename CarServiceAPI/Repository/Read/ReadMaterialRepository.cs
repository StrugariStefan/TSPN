using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CarServiceAPI.Model;

namespace CarServiceAPI.Repository.Read
{
    public class ReadMaterialRepository : IReadMaterialRepository
    {
        private readonly Model1Container _dbContainer;

        public ReadMaterialRepository(Model1Container dbContainer)
        {
            _dbContainer = dbContainer;
        }

        public Material GetById(int id)
        {
            return _dbContainer.Materials.FirstOrDefault(m => m.MaterialId == id);
        }

        public IReadOnlyList<Material> GetAll()
        {
            return _dbContainer.Materials.ToList();
        }

        public bool Exists(int id)
        {
            return _dbContainer.Materials.Any(m => m.MaterialId == id);
        }

        public IReadOnlyList<Material> GetByCondition(Expression<Func<Material, bool>> expression)
        {
            return _dbContainer.Materials.Where(expression).ToList();
        }
    }
}

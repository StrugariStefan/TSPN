using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarServiceAPI.Model;

namespace CarServiceAPI.Repository.Write
{
    public class WriteMaterialRepository : IWriteMaterialRepository
    {
        private readonly Model1Container _dbContainer;

        public WriteMaterialRepository(Model1Container dbContainer)
        {
            _dbContainer = dbContainer;
        }

        public void Create(Material entity)
        {
            _dbContainer.Materials.Add(entity);
        }

        public void Delete(int id)
        {
            var material = _dbContainer.Materials.First(m => m.MaterialId == id);
            _dbContainer.Materials.Remove(material);
        }

        public void Update(Material entity)
        {
            _dbContainer.Entry(entity).State = EntityState.Modified;
        }

        public bool Exists(int id)
        {
            return _dbContainer.Materials.Any(m => m.MaterialId == id);
        }

        public void SaveChanges()
        {
            _dbContainer.SaveChanges();
        }
    }
}

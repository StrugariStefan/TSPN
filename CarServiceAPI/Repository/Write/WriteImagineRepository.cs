using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarServiceAPI.Model;

namespace CarServiceAPI.Repository.Write
{
    public class WriteImagineRepository : IWriteImagineRepository
    {
        private readonly Model1Container _dbContainer;

        public WriteImagineRepository(Model1Container dbContainer)
        {
            _dbContainer = dbContainer;
        }

        public void Create(Imagine entity)
        {
            _dbContainer.Imagines.Add(entity);
        }

        public void Delete(int id)
        {
            var imagine = _dbContainer.Imagines.First(i => i.ImagineId == id);
            _dbContainer.Imagines.Remove(imagine);
        }

        public void Update(Imagine entity)
        {
            _dbContainer.Entry(entity).State = EntityState.Modified;
        }

        public bool Exists(int id)
        {
            return _dbContainer.Imagines.Any(i => i.ImagineId == id);
        }

        public void SaveChanges()
        {
            _dbContainer.SaveChanges();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarServiceAPI.Model;

namespace CarServiceAPI.Repository.Write
{
    public class WriteMecanicRepository : IWriteMecanicRepository
    {
        private readonly Model1Container _dbContainer;

        public WriteMecanicRepository(Model1Container dbContainer)
        {
            _dbContainer = dbContainer;
        }

        public void Create(Mecanic entity)
        {
            _dbContainer.Mecanics.Add(entity);
        }

        public void Delete(int id)
        {
            var mecanic = _dbContainer.Mecanics.First(m => m.MecanicId == id);
            _dbContainer.Mecanics.Remove(mecanic);
        }

        public void Update(Mecanic entity)
        {
            _dbContainer.Entry(entity).State = EntityState.Modified;
        }

        public bool Exists(int id)
        {
            return _dbContainer.Mecanics.Any(m => m.MecanicId == id);
        }

        public void SaveChanges()
        {
            _dbContainer.SaveChanges();
        }
    }
}

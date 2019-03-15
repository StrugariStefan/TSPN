using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarServiceAPI.Model;

namespace CarServiceAPI.Repository.Write
{
    public class WriteSasiuRepository : IWriteSasiuRepository
    {
        private readonly Model1Container _dbContainer;

        public WriteSasiuRepository(Model1Container dbContainer)
        {
            _dbContainer = dbContainer;
        }

        public void Create(Sasiu entity)
        {
            _dbContainer.Sasius.Add(entity);
        }

        public void Delete(int id)
        {
            var sasiu = _dbContainer.Sasius.First(s => s.SasiuId == id);
            _dbContainer.Sasius.Remove(sasiu);
        }

        public void Update(Sasiu entity)
        {
            _dbContainer.Entry(entity).State = EntityState.Modified;
        }

        public bool Exists(int id)
        {
            return _dbContainer.Sasius.Any(s => s.SasiuId == id);
        }

        public void SaveChanges()
        {
            _dbContainer.SaveChanges();
        }
    }
}

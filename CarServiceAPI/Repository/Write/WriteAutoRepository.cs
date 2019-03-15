using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarServiceAPI.Model;

namespace CarServiceAPI.Repository.Write
{
    public class WriteAutoRepository : IWriteAutoRepository
    {
        private readonly Model1Container _dbContainer;

        public WriteAutoRepository(Model1Container dbContainer)
        {
            _dbContainer = dbContainer;
        }

        public void Create(Auto entity)
        {
            _dbContainer.Autoes.Add(entity);
        }

        public void Delete(int id)
        {
            var auto = _dbContainer.Autoes.First(a => a.AutoId == id);
            _dbContainer.Autoes.Remove(auto);
        }

        public void Update(Auto entity)
        {
            _dbContainer.Entry(entity).State = EntityState.Modified;
        }

        public bool Exists(int id)
        {
            return _dbContainer.Autoes.Any(a => a.AutoId == id);
        }

        public void SaveChanges()
        {
            _dbContainer.SaveChanges();
        }
    }
}

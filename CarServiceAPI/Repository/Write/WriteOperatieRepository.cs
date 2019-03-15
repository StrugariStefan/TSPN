using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarServiceAPI.Model;

namespace CarServiceAPI.Repository.Write
{
    public class WriteOperatieRepository : IWriteOperatieRepository
    {
        private readonly Model1Container _dbContainer;

        public WriteOperatieRepository(Model1Container dbContainer)
        {
            _dbContainer = dbContainer;
        }

        public void Create(Operatie entity)
        {
            _dbContainer.Operaties.Add(entity);
        }

        public void Delete(int id)
        {
            var operatie = _dbContainer.Operaties.First(o => o.OperatieId == id);
            _dbContainer.Operaties.Remove(operatie);
        }

        public void Update(Operatie entity)
        {
            _dbContainer.Entry(entity).State = EntityState.Modified;
        }

        public bool Exists(int id)
        {
            return _dbContainer.Operaties.Any(o => o.OperatieId == id);
        }

        public void SaveChanges()
        {
            _dbContainer.SaveChanges();
        }
    }
}

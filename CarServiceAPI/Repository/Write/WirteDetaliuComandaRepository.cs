using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarServiceAPI.Model;

namespace CarServiceAPI.Repository.Write
{
    public class WirteDetaliuComandaRepository : IWriteDetaliuComandaRepository
    {
        private readonly Model1Container _dbContainer;

        public WirteDetaliuComandaRepository(Model1Container dbContainer)
        {
            _dbContainer = dbContainer;
        }

        public void Create(DetaliuComanda entity)
        {
            _dbContainer.DetaliuComandas.Add(entity);
        }

        public void Delete(int id)
        {
            var detaliuComanda = _dbContainer.DetaliuComandas.First(d => d.DetaliuComandaId == id);
            _dbContainer.DetaliuComandas.Remove(detaliuComanda);
        }

        public void Update(DetaliuComanda entity)
        {
            _dbContainer.Entry(entity).State = EntityState.Modified;
        }

        public bool Exists(int id)
        {
            return _dbContainer.DetaliuComandas.Any(d => d.DetaliuComandaId == id);
        }

        public void SaveChanges()
        {
            _dbContainer.SaveChanges();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using CarServiceAPI.Model;

namespace CarServiceAPI.Repository.Write
{
    public class WriteComandaRepository : IWriteComandaRepository
    {
        private readonly Model1Container _dbContainer;

        public WriteComandaRepository(Model1Container dbContainer)
        {
            _dbContainer = dbContainer;
        }

        public void Create(Comanda entity)
        {
            _dbContainer.Comandas.Add(entity);
        }

        public void Delete(int id)
        {
            var comanda = _dbContainer.Comandas.First(c => c.ComandaId == id);
            _dbContainer.Comandas.Remove(comanda);
        }

        public void Update(Comanda entity)
        {
            var detaliu = _dbContainer.DetaliuComandas.First(d => d.Comanda.ComandaId == entity.ComandaId);

            entity.ValoarePiese = detaliu.Materials.Count == 0 ? 0.0M : detaliu.Materials.Aggregate(0.0M,
                (valoarePiese, nextMaterial) => valoarePiese + nextMaterial.Cantitate * nextMaterial.Pret);
            _dbContainer.Entry(entity).State = EntityState.Modified;
        }

        public bool Exists(int id)
        {
            return _dbContainer.Comandas.Any(c => c.ComandaId == id);
        }

        public void SaveChanges()
        {
            _dbContainer.SaveChanges();
        }
    }
}

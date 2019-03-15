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

        public void AddMecanic(int id, Mecanic mecanic)
        {
            if (mecanic == null)
            {
                throw new ArgumentNullException(nameof(mecanic));
            }

            var detaliu = _dbContainer.DetaliuComandas.FirstOrDefault(d => d.DetaliuComandaId == id);
            detaliu?.Mecanics.Add(mecanic);
        }

        public void AddMaterial(int id, Material material)
        {
            if (material == null)
            {
                throw new ArgumentNullException(nameof(material));
            }

            var detaliu = _dbContainer.DetaliuComandas.FirstOrDefault(d => d.DetaliuComandaId == id);
            detaliu?.Materials.Add(material);
        }

        public void AddOperatie(int id, Operatie operatie)
        {
            if (operatie == null)
            {
                throw new ArgumentNullException(nameof(operatie));
            }

            var detaliu = _dbContainer.DetaliuComandas.FirstOrDefault(d => d.DetaliuComandaId == id);
            detaliu?.Operaties.Add(operatie);
        }
    }
}

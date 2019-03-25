using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CarServiceAPI.Model;

namespace CarServiceAPI.Repository.Read
{
    public class ReadDetaliuComandaRepository : IReadDetaliuComandaRepository
    {
        private readonly Model1Container _dbContainer;

        public ReadDetaliuComandaRepository(Model1Container dbContainer)
        {
            _dbContainer = dbContainer;
        }

        public DetaliuComanda GetById(int id)
        {
            return _dbContainer.DetaliuComandas.FirstOrDefault(d => d.DetaliuComandaId == id);
        }

        public List<DetaliuComanda> GetAll()
        {
            return _dbContainer.DetaliuComandas.ToList();
        }

        public bool Exists(int id)
        {
            return _dbContainer.DetaliuComandas.Any(d => d.DetaliuComandaId == id);
        }

        public IReadOnlyList<DetaliuComanda> GetByCondition(Expression<Func<DetaliuComanda, bool>> expression)
        {
            return _dbContainer.DetaliuComandas.Where(expression).ToList();
        }

        public DetaliuComanda GetByComandaId(int comandaId)
        {
            return _dbContainer.DetaliuComandas.FirstOrDefault(d => d.Comanda.ComandaId == comandaId);
        }

        public IReadOnlyList<DetaliuComanda> GetByMecanicId(int mecanicId)
        {
            return _dbContainer.DetaliuComandas
                .Where(d => d.Mecanics.Where(m => m.MecanicId == mecanicId).ToList() != null).ToList();
        }

        public IReadOnlyList<DetaliuComanda> GetByOperatieId(int operatieId)
        {
            return _dbContainer.DetaliuComandas
                .Where(d => d.Operaties.Where(o => o.OperatieId == operatieId).ToList() != null).ToList();
        }

        public IReadOnlyList<DetaliuComanda> GetByMaterialId(int materialId)
        {
            return _dbContainer.DetaliuComandas
                .Where(d => d.Materials.Where(m => m.MaterialId == materialId).ToList() != null).ToList();
        }

        public DetaliuComanda GetByImagineId(int imagineId)
        {
            return _dbContainer.DetaliuComandas.FirstOrDefault(d => d.Imagines.FirstOrDefault(i => i.ImagineId == imagineId) != null);
        }

        public IReadOnlyList<Imagine> GetAllImagesById(int detaliuComandaId)
        {
            return _dbContainer.DetaliuComandas.First(d => d.DetaliuComandaId == detaliuComandaId).Imagines.ToList();
        }
    }
}

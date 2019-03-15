using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarServiceAPI.Model;
using CarServiceAPI.Repository.Read;

namespace CarServiceAPI.Repository.Read
{
    public interface IReadDetaliuComandaRepository : IReadRepository<DetaliuComanda>
    {
        DetaliuComanda GetByComandaId(int comandaId);
        IReadOnlyList<DetaliuComanda> GetByMecanicId(int mecanicId);
        IReadOnlyList<DetaliuComanda> GetByOperatieId(int operatieId);
        IReadOnlyList<DetaliuComanda> GetByMaterialId(int materialId);
        DetaliuComanda GetByImagineId(int imagineId);
        IReadOnlyList<Imagine> GetAllImagesById(int detaliuComandaId);
    }
}

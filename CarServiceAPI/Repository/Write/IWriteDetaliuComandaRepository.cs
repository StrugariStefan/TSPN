using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarServiceAPI.Model;

namespace CarServiceAPI.Repository.Write
{
    public interface IWriteDetaliuComandaRepository : IWriteRepository<DetaliuComanda>
    {
        void AddMecanic(int id, Mecanic mecanic);
        void AddMaterial(int id, Material material);
        void AddOperatie(int id, Operatie operatie);
        void RemoveOperatie(int id, Operatie operatie);
        void RemoveMaterial(int id, Material material);
        void RemoveMecanic(int id, Mecanic mecanic);
    }
}

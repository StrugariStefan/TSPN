using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using CarServiceAPI.Model;

namespace ObjectWCF
{
    [ServiceContract]
    interface InterfaceComanda
    {
        [OperationContract]
        void Add(Comanda comanda);

        [OperationContract]
        void Update(Comanda comanda);

        [OperationContract]
        void Delete(int id);

        [OperationContract]
        IReadOnlyList<Comanda> Get();

        [OperationContract]
        Comanda GetById(int id);

        [OperationContract]
        IReadOnlyList<Comanda> GetByCondition(Expression<Func<Comanda, bool>> expression);

        [OperationContract]
        IReadOnlyList<Comanda> GetByClientId(int clientId);

        [OperationContract]
        IReadOnlyList<Comanda> GetByAutoId(int autoId);

        [OperationContract]
        IReadOnlyList<Comanda> GetByStare(Stare stare);

        [OperationContract]
        IReadOnlyList<Comanda> GetByMecanicId(int mecanicId);

        [OperationContract]
        IReadOnlyList<Comanda> GetByOperatieId(int operatieId);

        [OperationContract]
        IReadOnlyList<Comanda> GetByMaterialId(int materialId);

        [OperationContract]
        Comanda GetByImagineId(int imagineId);

        [OperationContract]
        IReadOnlyList<Imagine> GetByComandaId(int id);

        [OperationContract]
        void AddMecanic(int id, Mecanic mecanic);

        [OperationContract]
        void AddMaterial(int id, Material material);

        [OperationContract]
        void AddOperatie(int id, Operatie operatie);

        [OperationContract]
        void RemoveMecanic(int id, Mecanic mecanic);

        [OperationContract]
        void RemoveMaterial(int id, Material material);

        [OperationContract]
        void RemoveOperatie(int id, Operatie operatie);
    }
}

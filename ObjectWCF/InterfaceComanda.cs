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
        void AddComanda(Comanda comanda);

        [OperationContract]
        void UpdateComanda(Comanda comanda);

        [OperationContract]
        void DeleteComanda(int id);

        [OperationContract]
        IReadOnlyList<Comanda> GetComandas();

        [OperationContract]
        Comanda GetComandaById(int id);

        //[OperationContract]
        List<Comanda> GetComandasByCondition(Expression<Func<Comanda, bool>> expression);

        [OperationContract]

        List<Comanda> GetComandasByClientId(int clientId);

        [OperationContract]
        List<Comanda> GetComandasByAutoId(int autoId);

        [OperationContract]
        List<Comanda> GetComandasByStare(Stare stare);

        [OperationContract]
        List<Comanda> GetComandasByMecanicId(int mecanicId);

        [OperationContract]
        List<Comanda> GetComandasByOperatieId(int operatieId);

        [OperationContract]
        List<Comanda> GetComandasByMaterialId(int materialId);

        [OperationContract]
        Comanda GetComandaByImagineId(int imagineId);

        [OperationContract]
        List<Imagine> GetImaginesByComandaId(int id);

        [OperationContract]
        void AddComandaMecanic(int id, Mecanic mecanic);

        [OperationContract]
        void AddComandaMaterial(int id, Material material);

        [OperationContract]
        void AddComandaOperatie(int id, Operatie operatie);

        [OperationContract]
        void RemoveComandaMecanic(int id, Mecanic mecanic);

        [OperationContract]
        void RemoveComandaMaterial(int id, Material material);

        [OperationContract]
        void RemoveComandaOperatie(int id, Operatie operatie);
    }
}

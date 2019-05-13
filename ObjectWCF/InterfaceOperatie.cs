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
    interface InterfaceOperatie
    {
        [OperationContract]
        void AddOperatie(Operatie operatie);

        [OperationContract]
        void UpdateOperatie(Operatie operatie);

        [OperationContract]
        void DeleteOperatie(int id);

        [OperationContract]
        List<Operatie> GetOperaties();

        [OperationContract]
        Operatie GetOperatieById(int id);

        //[OperationContract]
        List<Operatie> GetOperatiesByCondition(Expression<Func<Operatie, bool>> expression);
    }
}

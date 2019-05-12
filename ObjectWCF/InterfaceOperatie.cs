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
        void Add(Operatie operatie);

        [OperationContract]
        void Update(Operatie operatie);

        [OperationContract]
        void Delete(int id);

        [OperationContract]
        IReadOnlyList<Operatie> Get();

        [OperationContract]
        Operatie GetById(int id);

        [OperationContract]
        IReadOnlyList<Operatie> getByCondition(Expression<Func<Operatie, bool>> expression);
    }
}

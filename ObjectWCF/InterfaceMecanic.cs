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
    interface InterfaceMecanic
    {
        [OperationContract]
        void Add(Mecanic mecanic);

        [OperationContract]
        void Update(Mecanic mecanic);

        [OperationContract]
        void Delete(int id);

        [OperationContract]
        IReadOnlyList<Mecanic> Get();

        [OperationContract]
        Mecanic GetById(int id);

        [OperationContract]
        IReadOnlyList<Mecanic> GetByCondition(Expression<Func<Mecanic, bool>> expression);

    }
}

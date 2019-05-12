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
    interface InterfaceAuto
    {
        [OperationContract]
        void Add(Auto auto);

        [OperationContract]
        void Update(Auto auto);

        [OperationContract]
        void Delete(int id);

        [OperationContract]
        IReadOnlyList<Auto> Get();

        [OperationContract]
        Client GetById(int id);

        [OperationContract]
        List<Auto> GetBySasiuId(int sasiuId);

        [OperationContract]
        IReadOnlyList<Auto> GetByCondition(Expression<Func<Auto, bool>> expression);

    }
}

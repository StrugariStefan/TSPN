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
    interface InterfaceSasiu
    {
        [OperationContract]
        void Add(Sasiu sasiu);

        [OperationContract]
        void Update(Sasiu sasiu);

        [OperationContract]
        void Delete(int id);

        [OperationContract]
        IReadOnlyList<Sasiu> Get();

        [OperationContract]
        Sasiu GetById(int id);

        [OperationContract]
        IReadOnlyList<Sasiu> GetByCondition(Expression<Func<Sasiu, bool>> expression);
    }
}

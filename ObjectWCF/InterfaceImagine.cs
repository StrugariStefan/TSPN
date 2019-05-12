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
    interface InterfaceImagine
    {
        [OperationContract]
        void Add(Imagine imagine);

        [OperationContract]
        void Update(Imagine imagine);

        [OperationContract]
        void Delete(int id);

        [OperationContract]
        IReadOnlyList<Imagine> Get();

        [OperationContract]
        Imagine GetById(int id);

        [OperationContract]
        IReadOnlyList<Imagine> GetByCondition(Expression<Func<Imagine, bool>> expression);
    }
}

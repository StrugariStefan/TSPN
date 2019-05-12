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
    interface InterfaceMaterial
    {
        [OperationContract]
        void Add(Material material);

        [OperationContract]
        void Update(Material material);

        [OperationContract]
        void Delete(int id);

        [OperationContract]
        IReadOnlyList<Material> Get();

        [OperationContract]
        Material GetById(int id);

        [OperationContract]
        IReadOnlyList<Material> GetByCondition(Expression<Func<Material, bool>> expression);
    }
}

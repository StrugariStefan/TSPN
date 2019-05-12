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
    interface InterfaceClient
    {
        [OperationContract]
        void Add(Client client);

        [OperationContract]
        void Update(Client client);

        [OperationContract]
        void Delete(int id);

        [OperationContract]
        IReadOnlyList<Client> Get();

        [OperationContract]
        Client GetById(int id);

        [OperationContract]
        Client GetByAutoId(int autoId);

        [OperationContract]
        IReadOnlyList<Client> GetByCondition(Expression<Func<Client, bool>> expression);

    }
}

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
        void AddClient(Client client);

        [OperationContract]
        void UpdateClient(Client client);

        [OperationContract]
        void DeleteClient(int id);

        [OperationContract]
        IReadOnlyList<Client> GetClients();

        [OperationContract]
        Client GetClientById(int id);

        [OperationContract]
        Client GetClientByAutoId(int autoId);

        //[OperationContract]
        IReadOnlyList<Client> GetClientsByCondition(Expression<Func<Client, bool>> expression);

    }
}

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
        void AddSasiu(Sasiu sasiu);

        [OperationContract]
        void UpdateSasiu(Sasiu sasiu);

        [OperationContract]
        void DeleteSasiu(int id);

        [OperationContract]
        IReadOnlyList<Sasiu> GetSasius();

        [OperationContract]
        Sasiu GetSasiuById(int id);

        //[OperationContract]
        IReadOnlyList<Sasiu> GetSasiusByCondition(Expression<Func<Sasiu, bool>> expression);
    }
}

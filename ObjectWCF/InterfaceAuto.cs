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
        void AddAuto(Auto auto);

        [OperationContract]
        void UpdateAuto(Auto auto);

        [OperationContract]
        void DeleteAuto(int id);

        [OperationContract]
        IReadOnlyList<Auto> GetAutoes();

        [OperationContract]
        Auto GetAutoById(int id);

        [OperationContract]
        List<Auto> GetAutoesBySasiuId(int sasiuId);

        //[OperationContract]
        IReadOnlyList<Auto> GetAutoesByCondition(Expression<Func<Auto, bool>> expression);

    }
}

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
        void AddMecanic(Mecanic mecanic);

        [OperationContract]
        void UpdateMecanic(Mecanic mecanic);

        [OperationContract]
        void DeleteMecanic(int id);

        [OperationContract]
        List<Mecanic> GetMecanics();

        [OperationContract]
        Mecanic GetMecanicById(int id);

        //[OperationContract]
        List<Mecanic> GetMecanicsByCondition(Expression<Func<Mecanic, bool>> expression);

    }
}

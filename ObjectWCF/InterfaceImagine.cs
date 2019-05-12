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
        void AddImagine(Imagine imagine);

        [OperationContract]
        void UpdateImagine(Imagine imagine);

        [OperationContract]
        void DeleteImagine(int id);

        [OperationContract]
        IReadOnlyList<Imagine> GetImagines();

        [OperationContract]
        Imagine GetImagineById(int id);

        //[OperationContract]
        IReadOnlyList<Imagine> GetImaginesByCondition(Expression<Func<Imagine, bool>> expression);
    }
}

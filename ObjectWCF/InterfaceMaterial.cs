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
        void AddMaterial(Material material);

        [OperationContract]
        void UpdateMaterial(Material material);

        [OperationContract]
        void DeleteMaterial(int id);

        [OperationContract]
        IReadOnlyList<Material> GetMaterials();

        [OperationContract]
        Material GetMaterialById(int id);

        //[OperationContract]
        IReadOnlyList<Material> GetMaterialsByCondition(Expression<Func<Material, bool>> expression);
    }
}

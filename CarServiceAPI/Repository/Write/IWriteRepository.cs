using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceAPI.Repository.Write
{
    public interface IWriteRepository<in T>
    {
        void Create(T entity);
        void Delete(int id);
        void Update(T entity);
        bool Exists(int id);
        void SaveChanges();
    }
}

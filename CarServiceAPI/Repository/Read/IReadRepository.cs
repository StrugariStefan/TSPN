using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceAPI.Repository.Read
{
    public interface IReadRepository<T>
    {
        T GetById(int id);
        IReadOnlyList<T> GetAll();
        bool Exists(int id);
        IReadOnlyList<T> GetByCondition(Expression<Func<T, bool>> expression);
    }
}

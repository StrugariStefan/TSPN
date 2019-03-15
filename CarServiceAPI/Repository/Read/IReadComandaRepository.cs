using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarServiceAPI.Model;

namespace CarServiceAPI.Repository.Read
{
    public interface IReadComandaRepository : IReadRepository<Comanda>
    {
        IReadOnlyList<Comanda> GetByClientId(int clientId);
        IReadOnlyList<Comanda> GetByAutoId(int autoId);
        IReadOnlyList<Comanda> GetByStare(Stare stare);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarServiceAPI.Repository.Read;
using CarServiceAPI.Repository.Write;

namespace CarServiceAPI.Repository
{
    public interface IRepositoryWrapper
    {
        IReadAutoRepository AutoReadRepository { get; }
        IReadComandaRepository ComandaReadRepository { get; }
        IReadClientRepository ClientReadRepository { get; }
        IReadDetaliuComandaRepository DetaliuReadRepository { get; }
        IReadSasiuRepository SasiuReadRepository { get; }
        IReadMecanicRepository MecanicReadRepository { get; }
        IReadMaterialRepository MaterialReadRepository { get; }
        IReadImagineRepository ImagineReadRepository { get; }
        IReadOperatieRepository OperatieReadRepository { get; }

        IWriteAutoRepository AutoWriteRepository { get; }
        IWriteComandaRepository ComandaWriteRepository { get; }
        IWriteClientRepository ClientWriteRepository { get; }
        IWriteDetaliuComandaRepository DetaliuWriteRepository { get; }
        IWriteSasiuRepository SasiuWriteRepository { get; }
        IWriteMecanicRepository MecanicWriteRepository { get; }
        IWriteMaterialRepository MaterialWriteRepository { get; }
        IWriteImagineRepository ImagineWriteRepository { get; }
        IWriteOperatieRepository OperatieWriteRepository { get; }
    }
}

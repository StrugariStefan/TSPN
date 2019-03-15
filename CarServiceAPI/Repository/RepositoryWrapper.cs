using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarServiceAPI.Model;
using CarServiceAPI.Repository.Read;
using CarServiceAPI.Repository.Write;

namespace CarServiceAPI.Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private static RepositoryWrapper _repository;

        private Model1Container _dbContainer;

        private IReadAutoRepository _autoReadRepository;
        private IReadComandaRepository _comandaReadRepository;
        private IReadClientRepository _clientReadRepository;
        private IReadDetaliuComandaRepository _detaliuReadRepository;
        private IReadSasiuRepository _sasiuReadRepository;
        private IReadMecanicRepository _mecanicReadRepository;
        private IReadMaterialRepository _materialReadRepository;
        private IReadImagineRepository _imagineReadRepository;
        private IReadOperatieRepository _operatieReadRepository;

        private IWriteAutoRepository _autoWriteRepository;
        private IWriteComandaRepository _comandaWriteRepository;
        private IWriteClientRepository _clientWriteRepository;
        private IWriteDetaliuComandaRepository _detaliuWriteRepository;
        private IWriteSasiuRepository _sasiuWriteRepository;
        private IWriteMecanicRepository _mecanicWriteRepository;
        private IWriteMaterialRepository _materialWriteRepository;
        private IWriteImagineRepository _imagineWriteRepository;
        private IWriteOperatieRepository _operatieWriteRepository;

        public static RepositoryWrapper Repository
        {
            get
            {
                if (_repository == null)
                {
                    _repository = new RepositoryWrapper();
                }

                return _repository;
            }
        }

        public IReadAutoRepository AutoReadRepository
        {
            get
            {
                if (_autoReadRepository == null)
                {
                    _autoReadRepository = new ReadAutoRepository(_dbContainer);
                }

                return _autoReadRepository;
            }
        }

        public IReadComandaRepository ComandaReadRepository
        {
            get
            {
                if (_comandaReadRepository == null)
                {
                    _comandaReadRepository = new ReadComandaRepository(_dbContainer);
                }

                return _comandaReadRepository;
            }
        }

        public IReadClientRepository ClientReadRepository
        {
            get
            {
                if (_clientReadRepository == null)
                {
                    _clientReadRepository = new ReadClientRepository(_dbContainer);
                }

                return _clientReadRepository;
            }
        }

        public IReadDetaliuComandaRepository DetaliuReadRepository
        {
            get
            {
                if (_detaliuReadRepository == null)
                {
                    _detaliuReadRepository = new ReadDetaliuComandaRepository(_dbContainer);
                }

                return _detaliuReadRepository;
            }
        }

        public IReadSasiuRepository SasiuReadRepository
        {
            get
            {
                if (_sasiuReadRepository == null)
                {
                    _sasiuReadRepository = new ReadSasiuRepository(_dbContainer);
                }

                return _sasiuReadRepository;
            }
        }

        public IReadMecanicRepository MecanicReadRepository
        {
            get
            {
                if (_mecanicReadRepository == null)
                {
                    _mecanicReadRepository = new ReadMecanicRepository(_dbContainer);
                }

                return _mecanicReadRepository;
            }
        }

        public IReadMaterialRepository MaterialReadRepository
        {
            get
            {
                if (_materialReadRepository == null)
                {
                    _materialReadRepository = new ReadMaterialRepository(_dbContainer);
                }

                return _materialReadRepository;
            }
        }

        public IReadImagineRepository ImagineReadRepository
        {
            get
            {
                if (_imagineReadRepository == null)
                {
                    _imagineReadRepository = new ReadImagineRepository(_dbContainer);
                }

                return _imagineReadRepository;
            }
        }

        public IReadOperatieRepository OperatieReadRepository
        {
            get
            {
                if (_operatieReadRepository == null)
                {
                    _operatieReadRepository = new ReadOperatieRepository(_dbContainer);
                }

                return _operatieReadRepository;
            }
        }

        public IWriteAutoRepository AutoWriteRepository
        {
            get
            {
                if (_autoWriteRepository == null)
                {
                    _autoWriteRepository = new WriteAutoRepository(_dbContainer);
                }

                return _autoWriteRepository;
            }
        }

        public IWriteComandaRepository ComandaWriteRepository
        {
            get
            {
                if (_comandaWriteRepository == null)
                {
                    _comandaWriteRepository = new WriteComandaRepository(_dbContainer);
                }

                return _comandaWriteRepository;
            }
        }

        public IWriteClientRepository ClientWriteRepository
        {
            get
            {
                if (_clientWriteRepository == null)
                {
                    _clientWriteRepository = new WriteClientRepository(_dbContainer);
                }

                return _clientWriteRepository;
            }
        }

        public IWriteDetaliuComandaRepository DetaliuWriteRepository
        {
            get
            {
                if (_detaliuWriteRepository == null)
                {
                    _detaliuWriteRepository = new WirteDetaliuComandaRepository(_dbContainer);
                }

                return _detaliuWriteRepository;
            }
        }

        public IWriteSasiuRepository SasiuWriteRepository
        {
            get
            {
                if (_sasiuWriteRepository == null)
                {
                    _sasiuWriteRepository = new WriteSasiuRepository(_dbContainer);
                }

                return _sasiuWriteRepository;
            }
        }

        public IWriteMecanicRepository MecanicWriteRepository
        {
            get
            {
                if (_mecanicWriteRepository == null)
                {
                    _mecanicWriteRepository = new WriteMecanicRepository(_dbContainer);
                }

                return _mecanicWriteRepository;
            }
        }

        public IWriteMaterialRepository MaterialWriteRepository
        {
            get
            {
                if (_materialWriteRepository == null)
                {
                    _materialWriteRepository = new WriteMaterialRepository(_dbContainer);
                }

                return _materialWriteRepository;
            }
        }

        public IWriteImagineRepository ImagineWriteRepository
        {
            get
            {
                if (_imagineWriteRepository == null)
                {
                    _imagineReadRepository = new ReadImagineRepository(_dbContainer);
                }

                return _imagineWriteRepository;
            }
        }

        public IWriteOperatieRepository OperatieWriteRepository
        {
            get
            {
                if (_operatieWriteRepository == null)
                {
                    _operatieWriteRepository = new WriteOperatieRepository(_dbContainer);
                }

                return _operatieWriteRepository;
            }
        }

        private RepositoryWrapper()
        {
            _dbContainer = new Model1Container();
        }
    }
}

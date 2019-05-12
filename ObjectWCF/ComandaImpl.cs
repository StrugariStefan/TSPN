using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CarServiceAPI.Model;
using CarServiceAPI.Repository;

namespace ObjectWCF
{
    public class ComandaImpl : InterfaceComanda
    {
        private readonly IRepositoryWrapper _repository;

        public ComandaImpl(IRepositoryWrapper repository)
        {
            _repository = repository;
        }

        public void Add(Comanda comanda)
        {
            _repository.ComandaWriteRepository.Create(comanda);
            DetaliuComanda detaliuComanda = new DetaliuComanda(comanda);
            _repository.DetaliuWriteRepository.Create(detaliuComanda);
            _repository.ComandaWriteRepository.SaveChanges();
        }

        public void Update(Comanda comanda)
        {
            _repository.ComandaWriteRepository.Update(comanda);
            _repository.ComandaWriteRepository.SaveChanges();
        }

        public void Delete(int id)
        {
            if (_repository.ComandaWriteRepository.Exists(id))
            {
                DetaliuComanda detaliuComanda = _repository.DetaliuReadRepository.GetByComandaId(id);
                _repository.DetaliuWriteRepository.Delete(detaliuComanda.DetaliuComandaId);
                _repository.ComandaWriteRepository.Delete(id);
                _repository.ComandaWriteRepository.SaveChanges();
            }
        }

        public IReadOnlyList<Comanda> Get()
        {
            return _repository.ComandaReadRepository.GetAll();
        }

        public Comanda GetById(int id)
        {
            if (_repository.ComandaReadRepository.Exists(id))
            {
                return _repository.ComandaReadRepository.GetById(id);
            }

            return null;
        }

        public IReadOnlyList<Comanda> GetByCondition(Expression<Func<Comanda, bool>> expression)
        {
            return _repository.ComandaReadRepository.GetByCondition(expression);
        }

        public IReadOnlyList<Comanda> GetByClientId(int clientId)
        {
            if (_repository.ClientReadRepository.Exists(clientId))
            {
                return _repository.ComandaReadRepository.GetByClientId(clientId);
            }

            return null;
        }

        public IReadOnlyList<Comanda> GetByAutoId(int autoId)
        {
            if (_repository.AutoReadRepository.Exists(autoId))
            {
                return _repository.ComandaReadRepository.GetByAutoId(autoId);
            }

            return null;
        }

        public IReadOnlyList<Comanda> GetByStare(Stare stare)
        {
            return _repository.ComandaReadRepository.GetByStare(stare);
        }

        public IReadOnlyList<Comanda> GetByMecanicId(int mecanicId)
        {
            if (_repository.MecanicReadRepository.Exists(mecanicId))
            {
                IReadOnlyList<DetaliuComanda> detaliuComandas = _repository.DetaliuReadRepository.GetByMecanicId(mecanicId);
                return (IReadOnlyList<Comanda>) _repository.ComandaReadRepository.GetAll().Where(c =>
                    detaliuComandas.Contains(_repository.DetaliuReadRepository.GetByComandaId(c.ComandaId)));
            }

            return null;
            
        }

        public IReadOnlyList<Comanda> GetByOperatieId(int operatieId)
        {
            if (_repository.OperatieReadRepository.Exists(operatieId))
            {
                IReadOnlyList<DetaliuComanda> detaliuComandas =
                    _repository.DetaliuReadRepository.GetByOperatieId(operatieId);
                return (IReadOnlyList<Comanda>) _repository.ComandaReadRepository.GetAll().Where(c =>
                    detaliuComandas.Contains(_repository.DetaliuReadRepository.GetByComandaId(c.ComandaId)));
            }

            return null;
        }

        public IReadOnlyList<Comanda> GetByMaterialId(int materialId)
        {
            if (_repository.MaterialWriteRepository.Exists(materialId))
            {
                IReadOnlyList<DetaliuComanda> detaliuComandas =
                    _repository.DetaliuReadRepository.GetByMaterialId(materialId);
                return (IReadOnlyList<Comanda>)_repository.ComandaReadRepository.GetAll().Where(c =>
                    detaliuComandas.Contains(_repository.DetaliuReadRepository.GetByComandaId(c.ComandaId)));
            }

            return null;
        }

        public Comanda GetByImagineId(int imagineId)
        {
            if (_repository.ImagineWriteRepository.Exists(imagineId))
            {
                DetaliuComanda detaliuComanda =
                    _repository.DetaliuReadRepository.GetByImagineId(imagineId);
                return _repository.ComandaReadRepository.GetAll().FirstOrDefault(c =>
                    detaliuComanda.DetaliuComandaId == _repository.DetaliuReadRepository.GetByComandaId(c.ComandaId).DetaliuComandaId);
            }

            return null;
        }

        public IReadOnlyList<Imagine> GetByComandaId(int id)
        {
            if (_repository.ComandaWriteRepository.Exists(id))
            {
                DetaliuComanda detaliuComanda = _repository.DetaliuReadRepository.GetByComandaId(id);
                return _repository.DetaliuReadRepository.GetAllImagesById(detaliuComanda.DetaliuComandaId);
            }

            return null;
        }

        public void AddMecanic(int id, Mecanic mecanic)
        {
            if (_repository.ComandaReadRepository.Exists(id))
            {
                DetaliuComanda detaliuComanda = _repository.DetaliuReadRepository.GetByComandaId(id);
                _repository.DetaliuWriteRepository.AddMecanic(detaliuComanda.DetaliuComandaId, mecanic);
                _repository.DetaliuWriteRepository.SaveChanges();

            }
        }

        public void AddMaterial(int id, Material material)
        {
            if (_repository.ComandaReadRepository.Exists(id))
            {
                DetaliuComanda detaliuComanda = _repository.DetaliuReadRepository.GetByComandaId(id);
                _repository.DetaliuWriteRepository.AddMaterial(detaliuComanda.DetaliuComandaId, material);
                _repository.DetaliuWriteRepository.SaveChanges();

            }
        }

        public void AddOperatie(int id, Operatie operatie)
        {
            if (_repository.ComandaReadRepository.Exists(id))
            {
                DetaliuComanda detaliuComanda = _repository.DetaliuReadRepository.GetByComandaId(id);
                _repository.DetaliuWriteRepository.AddOperatie(detaliuComanda.DetaliuComandaId, operatie);
                _repository.DetaliuWriteRepository.SaveChanges();

            }
        }

        public void RemoveMecanic(int id, Mecanic mecanic)
        {
            if (_repository.ComandaReadRepository.Exists(id))
            {
                DetaliuComanda detaliuComanda = _repository.DetaliuReadRepository.GetByComandaId(id);
                _repository.DetaliuWriteRepository.RemoveMecanic(detaliuComanda.DetaliuComandaId, mecanic);
                _repository.DetaliuWriteRepository.SaveChanges();
            }
        }

        public void RemoveMaterial(int id, Material material)
        {
            if (_repository.ComandaReadRepository.Exists(id))
            {
                DetaliuComanda detaliuComanda = _repository.DetaliuReadRepository.GetByComandaId(id);
                _repository.DetaliuWriteRepository.RemoveMaterial(detaliuComanda.DetaliuComandaId, material);
                _repository.DetaliuWriteRepository.SaveChanges();
            }
        }

        public void RemoveOperatie(int id, Operatie operatie)
        {
            if (_repository.ComandaReadRepository.Exists(id))
            {
                DetaliuComanda detaliuComanda = _repository.DetaliuReadRepository.GetByComandaId(id);
                _repository.DetaliuWriteRepository.RemoveOperatie(detaliuComanda.DetaliuComandaId, operatie);
                _repository.DetaliuWriteRepository.SaveChanges();
            }
        }
    }
}

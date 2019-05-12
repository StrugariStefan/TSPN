using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CarServiceAPI.Model;
using CarServiceAPI.Repository;
using ObjectWCF;

namespace ObjectWCF
{
    public class OperatieImpl : InterfaceOperatie
    {
        private readonly IRepositoryWrapper _repository;

        public OperatieImpl(IRepositoryWrapper repository)
        {
            _repository = repository;
        }

        public void Add(Operatie operatie)
        {
            _repository.OperatieWriteRepository.Create(operatie);
            _repository.OperatieWriteRepository.SaveChanges();
        }

        public void Update(Operatie operatie)
        {
            _repository.OperatieWriteRepository.Update(operatie);
            _repository.OperatieWriteRepository.SaveChanges();
        }

        public void Delete(int id)
        {
            if (_repository.OperatieWriteRepository.Exists(id))
            {
                _repository.OperatieWriteRepository.Delete(id);
                _repository.OperatieWriteRepository.SaveChanges();
            }
        }

        public IReadOnlyList<Operatie> Get()
        {
            return _repository.OperatieReadRepository.GetAll();
        }

        public Operatie GetById(int id)
        {
            if (_repository.OperatieReadRepository.Exists(id))
            {
                return _repository.OperatieReadRepository.GetById(id);
            }

            return null;
        }

        public IReadOnlyList<Operatie> GetByCondition(Expression<Func<Operatie, bool>> expression)
        {
            return _repository.OperatieReadRepository.GetByCondition(expression);
        }
    }
}

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
    public class MecanicImpl : InterfaceMecanic
    {
        private readonly IRepositoryWrapper _repository;

        public MecanicImpl(IRepositoryWrapper repository)
        {
            _repository = repository;
        }

        public void Add(Mecanic mecanic)
        {
            _repository.MecanicWriteRepository.Create(mecanic);
            _repository.MecanicWriteRepository.SaveChanges();
        }

        public void Update(Mecanic mecanic)
        {
            _repository.MecanicWriteRepository.Update(mecanic);
            _repository.MecanicWriteRepository.SaveChanges();
        }

        public void Delete(int id)
        {
            if (_repository.MecanicWriteRepository.Exists(id))
            {
                _repository.MecanicWriteRepository.Delete(id);
                _repository.MecanicWriteRepository.SaveChanges();
            }
        }

        public IReadOnlyList<Mecanic> Get()
        {
            return _repository.MecanicReadRepository.GetAll();
        }

        public Mecanic GetById(int id)
        {
            if (_repository.MecanicReadRepository.Exists(id))
            {
                return _repository.MecanicReadRepository.GetById(id);
            }

            return null;
        }

        public IReadOnlyList<Mecanic> GetByCondition(Expression<Func<Mecanic, bool>> expression)
        {
            return _repository.MecanicReadRepository.GetByCondition(expression);
        }
    }
}

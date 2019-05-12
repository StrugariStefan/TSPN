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
    public class SasiuImpl : InterfaceSasiu
    {
        private readonly IRepositoryWrapper _repository;

        public SasiuImpl(IRepositoryWrapper repository)
        {
            _repository = repository;
        }

        public void Add(Sasiu sasiu)
        {
            _repository.SasiuWriteRepository.Create(sasiu);
            _repository.SasiuWriteRepository.SaveChanges();
        }

        public void Update(Sasiu sasiu)
        {
            _repository.SasiuWriteRepository.Update(sasiu);
            _repository.SasiuWriteRepository.SaveChanges();
        }

        public void Delete(int id)
        {
            if (_repository.SasiuWriteRepository.Exists(id))
            {
                _repository.SasiuWriteRepository.Delete(id);
                _repository.SasiuWriteRepository.SaveChanges();
            }
        }

        public IReadOnlyList<Sasiu> Get()
        {
            return _repository.SasiuReadRepository.GetAll();
        }

        public Sasiu GetById(int id)
        {
            if (_repository.SasiuReadRepository.Exists(id))
            {
                return _repository.SasiuReadRepository.GetById(id);
            }

            return null;
        }

        public IReadOnlyList<Sasiu> GetByCondition(Expression<Func<Sasiu, bool>> expression)
        {
            return _repository.SasiuReadRepository.GetByCondition(expression);
        }
    }
}

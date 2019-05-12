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
    public class AutoImpl : InterfaceAuto
    {
        private readonly IRepositoryWrapper _repository;

        public AutoImpl(IRepositoryWrapper repository)
        {
            _repository = repository;
        }

        public void Add(Auto auto)
        {
            _repository.AutoWriteRepository.Create(auto);
            _repository.AutoWriteRepository.SaveChanges();
        }

        public void Update(Auto auto)
        {
            _repository.AutoWriteRepository.Update(auto);
        }

        public void Delete(int id)
        {
            if (_repository.AutoWriteRepository.Exists(id))
            {
                _repository.AutoWriteRepository.Delete(id);
                _repository.AutoWriteRepository.SaveChanges();
            }
        }

        public IReadOnlyList<Auto> Get()
        {
            return _repository.AutoReadRepository.GetAll();
        }

        public Auto GetById(int id)
        {
            if (_repository.AutoReadRepository.Exists(id))
            {
                return _repository.AutoReadRepository.GetById(id);
            }

            return null;
        }

        public List<Auto> GetBySasiuId(int sasiuId)
        {
            if (_repository.SasiuReadRepository.Exists(sasiuId))
            {
                return _repository.AutoReadRepository.GetBySasiuId(sasiuId);
            }

            return null;
        }

        public IReadOnlyList<Auto> GetByCondition(Expression<Func<Auto, bool>> expression)
        {
            return _repository.AutoReadRepository.GetByCondition(expression);
        }
    }
}

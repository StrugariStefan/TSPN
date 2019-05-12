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
    public class ImagineImpl : InterfaceImagine
    {
        private readonly IRepositoryWrapper _repository;

        public ImagineImpl(IRepositoryWrapper repository)
        {
            _repository = repository;
        }

        public void Add(Imagine imagine)
        {
            _repository.ImagineWriteRepository.Create(imagine);
            _repository.ImagineWriteRepository.SaveChanges();
        }

        public void Update(Imagine imagine)
        {
            _repository.ImagineWriteRepository.Update(imagine);
            _repository.ImagineWriteRepository.SaveChanges();
        }

        public void Delete(int id)
        {
            if (_repository.ImagineWriteRepository.Exists(id))
            {
                _repository.ImagineWriteRepository.Delete(id);
                _repository.ImagineWriteRepository.SaveChanges();
            }
        }

        public IReadOnlyList<Imagine> Get()
        {
            return _repository.ImagineReadRepository.GetAll();
        }

        public Imagine GetById(int id)
        {
            if (_repository.ImagineReadRepository.Exists(id))
            {
                return _repository.ImagineReadRepository.GetById(id);
            }

            return null;
        }

        public IReadOnlyList<Imagine> GetByCondition(Expression<Func<Imagine, bool>> expression)
        {
            return _repository.ImagineReadRepository.GetByCondition(expression);
        }
    }
}

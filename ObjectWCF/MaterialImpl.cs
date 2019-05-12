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
    public class MaterialImpl : InterfaceMaterial
    {
        private readonly IRepositoryWrapper _repository;

        public MaterialImpl(IRepositoryWrapper repository)
        {
            _repository = repository;
        }

        public void Add(Material material)
        {
            _repository.MaterialWriteRepository.Create(material);
            _repository.MaterialWriteRepository.SaveChanges();
        }

        public void Update(Material material)
        {
            _repository.MaterialWriteRepository.Update(material);
            _repository.MaterialWriteRepository.SaveChanges();
        }

        public void Delete(int id)
        {
            if (_repository.MaterialWriteRepository.Exists(id))
            {
                _repository.MaterialWriteRepository.Delete(id);
                _repository.MaterialWriteRepository.SaveChanges();
            }
        }

        public IReadOnlyList<Material> Get()
        {
            return _repository.MaterialReadRepository.GetAll();
        }

        public Material GetById(int id)
        {
            if (_repository.MaterialReadRepository.Exists(id))
            {
                return _repository.MaterialReadRepository.GetById(id);
            }

            return null;
        }

        public IReadOnlyList<Material> GetByCondition(Expression<Func<Material, bool>> expression)
        {
            return _repository.MaterialReadRepository.GetByCondition(expression);
        }
    }
}

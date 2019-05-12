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
    public class ClientImpl : InterfaceClient
    {
        private readonly IRepositoryWrapper _repository;

        public ClientImpl(IRepositoryWrapper repository)
        {
            _repository = repository;
        }

        public void Add(Client client)
        {
            _repository.ClientWriteRepository.Create(client);
            _repository.ClientWriteRepository.SaveChanges();
        }

        public void Update(Client client)
        {
            _repository.ClientWriteRepository.Update(client);
            _repository.ClientWriteRepository.SaveChanges();
        }

        public void Delete(int id)
        {
            if (_repository.ClientWriteRepository.Exists(id))
            {
                _repository.ClientWriteRepository.Delete(id);
                _repository.ClientWriteRepository.SaveChanges();
            }
        }

        public IReadOnlyList<Client> Get()
        {
            return _repository.ClientReadRepository.GetAll();
        }

        public Client GetById(int id)
        {
            if (_repository.ClientReadRepository.Exists(id))
            {
                return _repository.ClientReadRepository.GetById(id);
            }

            return null;
        }

        public Client GetByAutoId(int autoId)
        {
            if (_repository.AutoReadRepository.Exists(autoId))
            {
                return _repository.ClientReadRepository.GetByAutoId(autoId);
            }

            return null;
        }

        public IReadOnlyList<Client> GetByCondition(Expression<Func<Client, bool>> expression)
        {
            return _repository.ClientReadRepository.GetByCondition(expression);
        }
    }
}

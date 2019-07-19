using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using restFullApi.model;
using restFullApi.model.Context;
using restFullApi.Repository;
using restFullApi.Repository.Generic;

namespace restFullApi.Business.Implementations
{
    public class PersonBusinessImpl : IPersonBusiness
    {
        private IRepository<Persons> _repository;

        public PersonBusinessImpl(IRepository<Persons> repository)
        {
            _repository = repository;
        }

        public Persons Create(Persons person)
        {
            return _repository.Create(person);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }

        public List<Persons> FindAll()
        {
            return _repository.FindAll();
        }

        public Persons FindById(long id)
        {
            return _repository.FindById(id);
        }

        public Persons Update(Persons person)
        {
            return _repository.Update(person);
        }
    }
}

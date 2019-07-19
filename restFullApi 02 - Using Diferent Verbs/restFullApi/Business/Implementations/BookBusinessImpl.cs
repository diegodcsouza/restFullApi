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
    public class BookBusinessImpl : IBookBusiness
    {
        public IRepository<Books> _repository;

        public BookBusinessImpl(IRepository<Books> repository)
        {
            _repository = repository;
        }

        public Books Create(Books Book)
        {
            return _repository.Create(Book);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }

        public List<Books> FindAll()
        {
            return _repository.FindAll();
        }

        public Books FindById(long id)
        {
            return _repository.FindById(id);
        }

        public Books Update(Books Book)
        {
            return _repository.Update(Book);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using restFullApi.Data.Converters;
using restFullApi.Data.VO;
using restFullApi.model;
using restFullApi.model.Context;
using restFullApi.Repository;
using restFullApi.Repository.Generic;

namespace restFullApi.Business.Implementations
{
    public class BookBusinessImpl : IBookBusiness
    {
        public IRepository<Book> _repository;

        private readonly BookConverter _converter;

        public BookBusinessImpl(IRepository<Book> repository)
        {
            _repository = repository;
            _converter = new BookConverter();
        }

        public BookVO Create(BookVO Book)
        {
            var bookEntity = _converter.Parse(Book);
            bookEntity = _repository.Create(bookEntity);
            return _converter.Parse(bookEntity);
        }
        public void Delete(long id)
        {
            _repository.Delete(id);
        }

        public List<BookVO> FindAll()
        {
            return _converter.ParseList(_repository.FindAll());
        }

        public BookVO FindById(long id)
        {
            return _converter.Parse(_repository.FindById(id));
        }

        public BookVO Update(BookVO Book)
        {
            var bookEntity = _converter.Parse(Book);
            bookEntity = _repository.Update(bookEntity);
            return _converter.Parse(bookEntity);
        }

    }
}

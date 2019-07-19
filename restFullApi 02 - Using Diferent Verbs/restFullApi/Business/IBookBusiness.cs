using restFullApi.Data.VO;
using restFullApi.model;
using System.Collections.Generic;

namespace restFullApi.Business
{
    public interface IBookBusiness
    {
        BookVO Create(BookVO Book);
        BookVO FindById(long id);
        List<BookVO> FindAll();
        BookVO Update(BookVO Book);
        void Delete(long id);
    }
}

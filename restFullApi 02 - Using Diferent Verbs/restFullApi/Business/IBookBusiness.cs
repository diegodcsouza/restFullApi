using restFullApi.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace restFullApi.Business
{
    public interface IBookBusiness
    {
        Books Create(Books Book);
        Books FindById(long id);
        List<Books> FindAll();
        Books Update(Books Book);
        void Delete(long id);
    }
}

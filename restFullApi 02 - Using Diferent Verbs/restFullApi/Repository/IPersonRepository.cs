using restFullApi.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace restFullApi.Repository
{
    public interface IPersonRepository
    {
        Persons Create(Persons person);
        Persons FindById(long id);
        List<Persons> FindAll();
        Persons Update(Persons person);
        void Delete(long id);
        bool Exist(long? id);
    }
}

using restFullApi.Data.VO;
using restFullApi.model;
using System.Collections.Generic;

namespace restFullApi.Business
{
    public interface IPersonBusiness
    {
        PersonVO Create(PersonVO person);
        PersonVO FindById(long id);
        List<PersonVO> FindAll();
        PersonVO Update(PersonVO person);
        void Delete(long id);
    }
}

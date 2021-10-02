using System.Collections.Generic;
using SolidApi.Dto;

namespace SolidApi.Interfaces
{
    public interface IPersonRetrievalManagement
    {
        PersonDto Retrieve(int keyId);
        IEnumerable<PersonDto> Search(PersonSearchCriteriaDto criteria);
    }
}
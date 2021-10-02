using System.Collections.Generic;
using SolidApi.Dto;
using SolidApi.Interfaces;

namespace SolidApi.Microservices
{
    public class PersonRetrievalManagementService : IPersonRetrievalManagement
    {
        public PersonDto Retrieve(int keyId)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<PersonDto> Search(PersonSearchCriteriaDto criteria)
        {
            throw new System.NotImplementedException();
        }
    }
}
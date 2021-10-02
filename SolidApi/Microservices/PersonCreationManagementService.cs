using SolidApi.Dto;
using SolidApi.Interfaces;

namespace SolidApi.Microservices
{
    public class PersonCreationManagementService : IPersonCreationManagement
    {
        public PersonDto Create(PersonDto person)
        {
            return person;
        }
    }
}
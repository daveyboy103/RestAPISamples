using System.Collections.Generic;
using SolidApi.Dto;
using SolidApi.Interfaces;

namespace SolidApi.Microservices
{
    public sealed class PersonUpdateManagementService : IPersonUpdateManagement
    {
        private readonly IDataAccess _dataAccess;

        private PersonUpdateManagementService() { }

        public PersonUpdateManagementService(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }
        public void UpdateContactDetails(IEnumerable<ContactDetailsDto> contactDetails)
        {
            _dataAccess.UpdateContactsDetails(contactDetails);
        }

        public void UpdateGenderDetails(GenderDetailDto genderDetails)
        {
            _dataAccess.UpdateGenderDetails(genderDetails);
        }

        public void UpdateNationalityDetails(IEnumerable<NationalityDetailsDto> nationalityDetails)
        {
            _dataAccess.UpdateNationalityDetails(nationalityDetails);
        }

        public void UpdateNameDetails(NameDetailsDto nameDetails)
        {
            _dataAccess.UpdateNameDetails(nameDetails);
        }
    }
}
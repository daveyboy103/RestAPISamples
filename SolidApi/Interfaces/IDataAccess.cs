using System.Collections.Generic;
using SolidApi.Dto;

namespace SolidApi.Interfaces
{
    public interface IDataAccess
    {
        void DeletePerson(int keyId);
        void UpdateContactsDetails(IEnumerable<ContactDetailsDto> contactDetails);
        void UpdateGenderDetails(GenderDetailDto genderDetailDto);
        void UpdateNationalityDetails(IEnumerable<NationalityDetailsDto> nationalityDetailsDto);
        void UpdateNameDetails(NameDetailsDto nameDetailsDto);
        PersonDto Retrieve(int keyId);
        IEnumerable<PersonDto> Search(PersonSearchCriteriaDto criteria);
    }
}
using System;
using System.Collections.Generic;
using SolidApi.Dto;
using SolidApi.Interfaces;

namespace SolidApi.DataAccess
{
    public class DataAccess : IDataAccess
    {
        public void DeletePerson(int keyId)
        {
            Console.WriteLine($"Person Id: {keyId} deleted");
        }

        public void UpdateContactsDetails(IEnumerable<ContactDetailsDto> contactDetails)
        {
            foreach (ContactDetailsDto contactDetail in contactDetails)
            {
                Console.WriteLine($"Contact details updated for KeyId: {contactDetail.KeyId}");
            }
        }

        public void UpdateGenderDetails(GenderDetailDto genderDetailDto)
        {
            Console.WriteLine($"Person Id: {genderDetailDto.KeyId} gender details updated");
        }

        public void UpdateNationalityDetails(IEnumerable<NationalityDetailsDto> nationalityDetailsDto)
        {
            foreach (NationalityDetailsDto detailsDto in nationalityDetailsDto)
            {
                Console.WriteLine($"Nationality details updated for KeyId: {detailsDto.KeyId}");
            }
        }

        public void UpdateNameDetails(NameDetailsDto nameDetailsDto)
        {
            Console.WriteLine($"Name details for Key ID: {nameDetailsDto.KeyId} updated");
        }

        public PersonDto Retrieve(int keyId)
        {
            Console.WriteLine($"Retrieved person with Key Id: {keyId}");
            return PersonDto.Empty();
        }

        public IEnumerable<PersonDto> Search(PersonSearchCriteriaDto criteria)
        {
            return new List<PersonDto>();
        }
    }
}
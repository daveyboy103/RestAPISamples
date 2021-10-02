using System.Collections.Generic;
using System.Runtime.InteropServices;
using SolidApi.Interfaces;

namespace SolidApi.Dto
{
    #nullable enable
    public static class DtoFactoryExtensions
    {
        public static PersonDto ToPersonDto(this IPerson person)
        {
            var personDto = new PersonDto
            {
                Nationality = person.ToNationalityDetailsDto(),
                ContactDetails = person.ToContactDetailsDto(),
                DateOfBirth = person.DateOfBirth,
                NameDetails = person.ToNameDetailsDto(),
                Gender = person.ToGenderDetailsDto(),
                KeyId = person.KeyId
            };

            return personDto;
        }
        
        public static NameDetailsDto ToNameDetailsDto(this IPerson person)
        {
            return new NameDetailsDto
            {
                Family = person.NameDetails.Family,
                Given = person.NameDetails.Given,
                Prefix = person.NameDetails.Prefix,
                Suffix = person.NameDetails.Suffix,
                Title = person.NameDetails.Title,
                Middle = person.NameDetails.Middle,
            };
        }
        
        public static IEnumerable<NationalityDetailsDto> ToNationalityDetailsDto(this IPerson person)
        {
            var ret = new List<NationalityDetailsDto>();

            foreach (var nationality in person.Nationality)
            {
                var nationalityDetails = new NationalityDetailsDto
                {
                    Country = nationality.Country,
                    DateFrom = nationality.DateFrom,
                    DateTo = nationality.DateTo
                };
                
                ret.Add(nationalityDetails);
            }

            return ret;
        }
        
        public static IEnumerable<ContactDetailsDto> ToContactDetailsDto(this IPerson person)
        {
            var ret = new List<ContactDetailsDto>();
            
            foreach (var contactDetail in person.ContactDetails)
            {
                var contactDetailsDto = new ContactDetailsDto
                {
                    Type = contactDetail.Type,
                    Details = contactDetail.Details
                };
                
                ret.Add(contactDetailsDto);
            }

            return ret;
        }

        public static GenderDetailDto ToGenderDetailsDto(this IPerson person)
        {
            return new GenderDetailDto
            {
                Gender = person.Gender.Gender,
                Notes = person.Gender.Notes
            };
        }
    }
    #nullable disable
}
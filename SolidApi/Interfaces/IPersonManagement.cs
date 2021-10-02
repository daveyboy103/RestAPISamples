using System.Collections.Generic;
using SolidApi.Dto;

namespace SolidApi.Interfaces
{
    /// <summary>
    /// People management API
    /// </summary>
    public interface IPersonUpdateManagement
    {
        void UpdateContactDetails(IEnumerable<ContactDetailsDto> contactDetails);
        void UpdateGenderDetails(GenderDetailDto genderDetails);
        void UpdateNationalityDetails(IEnumerable<NationalityDetailsDto> nationalityDetails);
        void UpdateNameDetails(NameDetailsDto nameDetails);
    }
}
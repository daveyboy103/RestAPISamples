using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SolidApi.Dto;

namespace PersonUpdateManagementService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonUpdateController : ControllerBase
    {
        [HttpPost(nameof(UpdateContactDetails))]
        public void UpdateContactDetails(ContactDetailsDto contactDetailsDto)
        {
            
        }

        [HttpPost(nameof(UpdateGenderDetails))]
        public void UpdateGenderDetails(GenderDetailDto genderDetails)
        {
            
        }

        [HttpPost(nameof(UpdateNationalityDetails))]
        public void UpdateNationalityDetails(IEnumerable<NationalityDetailsDto> nationalityDetails)
        {
        }

        [HttpPost(nameof(UpdateNameDetails))]
        public void UpdateNameDetails(NameDetailsDto nameDetails)
        {
        }
    }
}
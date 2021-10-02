using Microsoft.AspNetCore.Mvc;
using SolidApi.Dto;

namespace PersonRetrievalManagementService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonRetrievalManagementServiceController : ControllerBase
    {
        [HttpGet]
        public PersonDto Retrieve(int keyId)
        {
            return new PersonDto();
        }
    }
}
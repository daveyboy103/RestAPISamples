using Autofac;
using Microsoft.AspNetCore.Mvc;
using SolidApi;
using SolidApi.Dto;
using SolidApi.Interfaces;

namespace PersonCreationManagementService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonCreationManagementServiceController : ControllerBase
    {
        private readonly IContainer _container;
        public PersonCreationManagementServiceController()
        {
            _container = Initialisation.Container;
        }
        
        [HttpPost(nameof(Create))]
        public PersonDto Create(PersonDto person)
        {
            using (var scope = _container.BeginLifetimeScope())
            {
                var create = scope.Resolve<IPersonCreationManagement>();

                create.Create(person);

                return person;
            }
        }
    }
}
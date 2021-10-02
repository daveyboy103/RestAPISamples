using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PersonDeletionManagementService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonDeletionManagementServiceController : ControllerBase
    {
        [HttpGet]
        public void Delete(int keyId)
        {
            
        }
        
    }
}
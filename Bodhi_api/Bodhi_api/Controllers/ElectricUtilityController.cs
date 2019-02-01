using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bodhi_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ElectricUtilityController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "Electric Utility1", "Electric Utility2", "Electric Utility3" };
        }
    }
}
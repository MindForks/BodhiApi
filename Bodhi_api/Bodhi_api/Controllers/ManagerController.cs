using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Bodhi_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManagerController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "Manager1", "Manager2", "Manager3"};
        }

    }
}
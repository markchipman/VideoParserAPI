using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace VideoParserAPI.Controllers
{
   
    [ApiController]
    [Route("api/[controller]")]
    public class BaseAPIController : ControllerBase
    {        
        public BaseAPIController()
        {

        }
    }
}
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using VideoParserAPI.Model;

namespace VideoParserAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/ch9")]
    public class Ch9Controller : BaseAPIController
    {
        [HttpGet]
        public ActionResult<List<Ch9ParserModel>> Get()
        {
            return null;
        }
    }
}
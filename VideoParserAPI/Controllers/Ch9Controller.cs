using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using VideoParserAPI.Model;
using VideoParserAPI.Service;

namespace VideoParserAPI.Controllers
{   
    public class Ch9Controller : BaseAPIController
    {       
        [HttpGet("Roku")] 
        [Produces("application/xml")]
        public RokuFeedParserModel GetRokuFormat()
        {           
            var parserService = new Ch9ParserService("https://s.ch9.ms/Feeds/RSS");
            //return new RokuFeedParserModel() { ResultLength = 100 };
            return parserService.ParseContent().Result;   
        }
    }
}
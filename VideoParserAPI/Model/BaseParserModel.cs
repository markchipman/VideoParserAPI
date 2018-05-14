using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VideoParserAPI.Model
{
    public class BaseParserModel
    {
        public string Title { get; set; }
        public string ImageURL { get; set; }
        public string ContentURL { get; set; }
        public string Category { get; set; }

    }
}

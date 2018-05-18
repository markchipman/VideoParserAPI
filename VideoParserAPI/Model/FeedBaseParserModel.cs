using Microsoft.SyndicationFeed;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace VideoParserAPI.Model
{    
    public class FeedBaseParserModel : BaseParserModel
    {
        [XmlIgnore]
        public List<ISyndicationItem> SyndicationItems { get; set; }
    }
}

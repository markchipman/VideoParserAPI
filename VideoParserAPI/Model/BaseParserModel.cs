using Microsoft.SyndicationFeed;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace VideoParserAPI.Model
{    
    public class BaseParserModel : IParserModel
    {
        [XmlIgnore]
        public string RawContent { get; set; }
    }
}

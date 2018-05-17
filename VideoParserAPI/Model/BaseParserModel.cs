using Microsoft.SyndicationFeed;
using System.Runtime.Serialization;

namespace VideoParserAPI.Model
{
    public class BaseParserModel : IParserModel
    {
        [IgnoreDataMember]
        public string RawContent { get; set; }
    }
}

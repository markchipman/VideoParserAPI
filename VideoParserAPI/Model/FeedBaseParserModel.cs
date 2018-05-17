using Microsoft.SyndicationFeed;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace VideoParserAPI.Model
{
    public class FeedBaseParserModel : BaseParserModel
    {
        [IgnoreDataMember]
        public List<ISyndicationItem> SyndicationItems { get; set; }
    }
}

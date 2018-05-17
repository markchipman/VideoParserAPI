using System.Collections.Generic;
using System.Runtime.Serialization;

namespace VideoParserAPI.Model
{
    [DataContract]
    public class RokuFeedParserModel : FeedBaseParserModel
    {
        [DataMember]
        public int ResultLength { get; set; }
        public int EndIndex { get; set; }          
        [IgnoreDataMember]
        public List<RokuParserItem> ParserItems { get; set; }
    }

    [DataContract]
    public class RokuParserItem
    {       
        public string Title { get; set; }
        public int ContentId { get; set; }
        public string StreamFormat { get; set; }
        public string Synopsis { get; set; }
        public string SdImg { get; set; }
        public string HdImg { get; set; }
        public string ThumbnailURL { get; set; }
        public RokuMediaItem MediaItem { get; set; }
    }

    [DataContract]
    public class RokuMediaItem
    {       
        public string StreamUrl { get; set; }
        public string ThumbnailURL { get; set; }
    }
}

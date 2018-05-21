using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace VideoParserAPI.Model
{    
    [XmlRoot(ElementName ="Feed")]
    public class RokuFeedParserModel : FeedBaseParserModel
    {        
        [XmlElement]
        public int ResultLength { get; set; }
        [XmlElement]
        public int EndIndex { get; set; }      
        [XmlElement(ElementName ="Item")]
        public List<RokuParserItem> ParserItems { get; set; }
    }

    [XmlRoot(ElementName = "Item")]
    public class RokuParserItem
    {
        [XmlElement]
        public string Title { get; set; }
        [XmlElement]
        public int ContentId { get; set; }
        [XmlElement]
        public string StreamFormat { get; set; }
        [XmlElement]
        public string Synopsis { get; set; }
        [XmlAttribute]
        public string SdImg { get; set; }
        [XmlAttribute]
        public string HdImg { get; set; }
        [XmlAttribute]
        public string ThumbnailURL { get; set; }
        [XmlElement]
        public RokuMediaItem MediaItem { get; set; }
    }

    [XmlRoot(ElementName = "MediaItem")]
    public class RokuMediaItem
    {
        [XmlElement]
        public string StreamUrl { get; set; }
        [XmlElement]
        public string ThumbnailURL { get; set; }
    }
}

using Microsoft.SyndicationFeed;

namespace VideoParserAPI.Model
{
    public interface IParserModel
    {
        string RawContent { get; set; }       
    }
}

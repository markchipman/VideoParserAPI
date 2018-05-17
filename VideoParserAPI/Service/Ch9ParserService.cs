using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VideoParserAPI.Model;

namespace VideoParserAPI.Service
{
    public class Ch9ParserService : RokuFeedParserService
    {
       
        public Ch9ParserService(string _feedURL) : base(_feedURL)
        {
           
        }

        public async override Task<RokuFeedParserModel> ParseContent()
        {
            var parserModel = await base.ParseContent();
            parserModel.ParserItems = new List<RokuParserItem>();
            int currIndex = 0;
            foreach(var syndicationItem in parserModel.SyndicationItems)
            {
                RokuParserItem parserItem = new RokuParserItem();
                parserItem.Title = syndicationItem.Title;
                parserItem.ContentId = currIndex;
                parserItem.StreamFormat = "mp4";
                parserItem.MediaItem = new RokuMediaItem();
                parserItem.MediaItem.StreamUrl = syndicationItem.Links.FirstOrDefault(i => i.RelationshipType == "enclosure")?.Uri.ToString();
                parserModel.ParserItems.Add(parserItem);
                currIndex++;
            }
            parserModel.ResultLength = currIndex;
            parserModel.EndIndex = currIndex;
            return parserModel;
        }

    }
}

using Microsoft.SyndicationFeed;
using Microsoft.SyndicationFeed.Rss;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Xml;
using VideoParserAPI.Model;

namespace VideoParserAPI.Service
{
    public class RokuFeedParserService : BaseParserService<RokuFeedParserModel>
    {
        public string FeedURL { get; set; }

        public RokuFeedParserService(string _feedURL)
        {
            FeedURL = _feedURL;
        }

        public async override Task<RokuFeedParserModel> ParseContent()
        {
            RokuFeedParserModel parserModel = new RokuFeedParserModel() { SyndicationItems = new List<ISyndicationItem>() };
            using (XmlReader xmlReader = XmlReader.Create(FeedURL, new XmlReaderSettings() { Async = true }))
            {
                var reader = new RssFeedReader(xmlReader);
                while (await reader.Read())
                {
                    switch (reader.ElementType)
                    {
                        case SyndicationElementType.Item:
                            parserModel.SyndicationItems.Add(await reader.ReadItem());
                            break;
                    }
                }
            }
            return parserModel;
        }
    }
}

using Microsoft.SyndicationFeed;
using Microsoft.SyndicationFeed.Rss;
using System.Xml;


namespace VideoParserAPI.Service
{
    public class Ch9ParserService : BaseParserService
    {
        public async override void ParseFeed()
        {
            string filePath = "https://s.ch9.ms/Feeds/RSS";

            using (XmlReader xmlReader = XmlReader.Create(filePath, new XmlReaderSettings() { Async = true }))
            {
                var reader = new RssFeedReader(xmlReader);
                while (await reader.Read())
                {
                    switch (reader.ElementType)
                    {
                        case SyndicationElementType.Item:
                            ISyndicationItem item = await reader.ReadItem();

                            break;

                    }
                }
            }
        }
    }
}

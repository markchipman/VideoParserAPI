using Microsoft.Extensions.Logging;
using Microsoft.SyndicationFeed;
using Microsoft.SyndicationFeed.Rss;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Xml;
using VideoParserAPI.Model;

namespace VideoParserAPI.Service
{
    public abstract class BaseParserService<T> : IParserService<T> where T : IParserModel, new()
    {
        public BaseParserService()
        {

        }

        public async virtual Task<T> ParseContent()
        {
            return await Task.FromResult(new T());
        }
    }
}

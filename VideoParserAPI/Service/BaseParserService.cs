using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VideoParserAPI.Service
{
    interface IParserService
    {
        void ParseFeed();
    }

    public abstract class BaseParserService : IParserService
    {
        public abstract void ParseFeed();
    }
}

using System.Collections.Generic;
using System.Threading.Tasks;
using VideoParserAPI.Model;

namespace VideoParserAPI.Service
{
    public interface IParserService<T> where T : IParserModel
    {
        Task<T> ParseContent();
    }
}

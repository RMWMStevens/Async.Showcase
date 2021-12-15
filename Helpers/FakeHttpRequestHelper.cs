using Async.Showcase.Interfaces;
using System.Threading.Tasks;

namespace Async.Showcase.Helpers
{
    public class FakeHttpRequestHelper : IFakeHttpRequestHelper
    {
        public async Task RunFakeHttpRequestAsync()
        {
            await Task.Delay(2000);
        }
    }
}

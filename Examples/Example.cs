using Async.Showcase.Interfaces;
using System.Threading.Tasks;

namespace Async.Showcase.Examples
{
    public abstract class Example
    {
        protected readonly IFakeHttpRequestHelper fakeHttpRequestHelper;

        public Example(IFakeHttpRequestHelper fakeHttpRequestHelper)
        {
            this.fakeHttpRequestHelper = fakeHttpRequestHelper;
        }

        public abstract Task Run(int iterationCount);
    }
}

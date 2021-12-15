using Async.Showcase.Interfaces;
using System;
using System.Threading.Tasks;

namespace Async.Showcase.Examples
{
    public class AsyncExample : Example
    {
        public AsyncExample(IFakeHttpRequestHelper fakeHttpRequestHelper) : base(fakeHttpRequestHelper) { }

        public override async Task Run(int runCount)
        {
            Console.WriteLine("| Asynchronous calls in the same loop |");
            for (int i = 0; i < runCount; i++)
            {
                await fakeHttpRequestHelper.RunFakeHttpRequestAsync();
            }
        }
    }
}

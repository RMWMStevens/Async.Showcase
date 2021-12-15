using Async.Showcase.Interfaces;
using System;
using System.Threading.Tasks;

namespace Async.Showcase.Examples
{
    public class SyncExample : Example
    {
        public SyncExample(IFakeHttpRequestHelper fakeHttpRequestHelper) : base(fakeHttpRequestHelper) { }

#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
        public override async Task Run(int runCount)
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
        {
            Console.WriteLine("| Synchronous calls in a loop |");
            for (int i = 0; i < runCount; i++)
            {
                fakeHttpRequestHelper.RunFakeHttpRequestAsync().GetAwaiter().GetResult();
            }
        }
    }
}

using Async.Showcase.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Async.Showcase.Examples
{
    public class AsyncParallelExample : Example
    {
        public AsyncParallelExample(IFakeHttpRequestHelper fakeHttpRequestHelper) : base(fakeHttpRequestHelper) { }

        public override async Task Run(int runCount)
        {
            Console.WriteLine("| Asynchronous calls with Task.WhenAll() |");
            var callTasks = new List<Task>();

            for (int i = 0; i < runCount; i++)
            {
                callTasks.Add(fakeHttpRequestHelper.RunFakeHttpRequestAsync());
            }

            await Task.WhenAll(callTasks);
        }
    }
}

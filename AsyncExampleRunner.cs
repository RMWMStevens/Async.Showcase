using Async.Showcase.Examples;
using Async.Showcase.Helpers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Async.Showcase
{
    public class AsyncExampleRunner
    {
        readonly int iterationCount = 5;
        readonly List<Example> examples;

        public AsyncExampleRunner()
        {
            var fakeHttpRequestHelper = new FakeHttpRequestHelper();
            examples = new()
            {
                new SyncExample(fakeHttpRequestHelper),
                new AsyncExample(fakeHttpRequestHelper),
                new AsyncParallelExample(fakeHttpRequestHelper),
            };
        }

        public async Task RunExamples()
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            foreach (var example in examples)
            {
                await example.Run(iterationCount);
                Console.WriteLine($"Executing took {stopwatch.Elapsed} milliseconds\n");
                stopwatch.Restart();
            }
        }
    }
}

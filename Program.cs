using System.Threading.Tasks;

namespace Async.Showcase
{
    class Program
    {
        static void Main(string[] args)
        {
            MainAsync().GetAwaiter().GetResult();
        }

        static async Task MainAsync()
        {
            var asyncExampleRunner = new AsyncExampleRunner();
            await asyncExampleRunner.RunExamples();
        }
    }
}

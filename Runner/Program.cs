using BenchmarkDotNet.Running;
using Runner.Tests;

namespace Runner
{
    public class Program
    {

        static void Main(string[] args)
        {
            //BenchmarkSwitcher.FromAssembly(typeof(Program).GetTypeInfo().Assembly).Run(args);

            var summary = BenchmarkRunner.Run<UnityContainerBenchmarks>();
        }
    }
}

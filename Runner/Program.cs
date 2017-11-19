using BenchmarkDotNet.Running;
using Runner.Tests;
using System.Reflection;
using Runner.Setup;

namespace Runner
{
    public class Program
    {

        static void Main(string[] args)
        {
            if (0 == args.Length)
                BenchmarkSwitcher.FromAssembly(typeof(Program).GetTypeInfo().Assembly).RunAllJoined();
            else
                BenchmarkSwitcher.FromAssembly(typeof(Program).GetTypeInfo().Assembly).Run(args);
        }
    }
}

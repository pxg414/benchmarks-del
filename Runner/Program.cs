using System;
using BenchmarkDotNet.Running;

namespace Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<CreateContainer>();
        }
    }
}

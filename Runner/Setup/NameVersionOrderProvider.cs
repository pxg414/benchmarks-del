using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Order;
using BenchmarkDotNet.Reports;

namespace Runner.Setup
{
    public class NameVersionOrderProvider : IOrderProvider
    {
        public IEnumerable<BenchmarkDotNet.Running.Benchmark> GetExecutionOrder(BenchmarkDotNet.Running.Benchmark[] benchmarks) => benchmarks;

        public IEnumerable<BenchmarkDotNet.Running.Benchmark> GetSummaryOrder(BenchmarkDotNet.Running.Benchmark[] benchmarks, Summary summary) =>
            benchmarks.OrderBy(benchmark => benchmark.DisplayInfo).ThenBy(benchmark => benchmark.Parameters["Version"]);

        public string GetGroupKey(BenchmarkDotNet.Running.Benchmark benchmark, Summary summary) => null;
    }
}

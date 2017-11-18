using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Order;
using BenchmarkDotNet.Reports;

namespace Runner.Tests
{
    [Config(typeof(Config))]
    [BenchmarkCategory("IUnityContainer")]
    public class UnityContainerBenchmarks : TestsBase
    {
        #region Tests

        [Benchmark(Description = "new UnityContainer()")]
        public void NewUnityContainer() => Adapter.NewUnityContainer();

        [Benchmark(Description = "using(var uc = new UnityContainer()){}")]
        public void UsingUnityContainer() => Adapter.UsingUnityContainer();

        #endregion


        #region Config

        private class Config : ManualConfig
        {
            public Config()
            {
                Set(new NameVersionOrderProvider());
            }

            private class NameVersionOrderProvider : IOrderProvider
            {
                public IEnumerable<BenchmarkDotNet.Running.Benchmark> GetExecutionOrder(BenchmarkDotNet.Running.Benchmark[] benchmarks) =>
                    from benchmark in benchmarks
                    orderby benchmark.Parameters["Version"] descending,
                        benchmark.Target.MethodDisplayInfo
                    select benchmark;

                public IEnumerable<BenchmarkDotNet.Running.Benchmark> GetSummaryOrder(BenchmarkDotNet.Running.Benchmark[] benchmarks, Summary summary) =>
                    benchmarks.OrderBy(benchmark => benchmark.DisplayInfo).ThenBy(benchmark => benchmark.Parameters["Version"]);//.ThenBy(benchmark => summary[benchmark].ResultStatistics.Mean);

                public string GetGroupKey(BenchmarkDotNet.Running.Benchmark benchmark, Summary summary) => null;
            }
        }
        
        #endregion
    }
}

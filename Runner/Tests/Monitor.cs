using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;
using System.Collections.Generic;

namespace Runner.Tests
{
    [BenchmarkCategory("Basic")]
    [RPlotExporter]
    [SimpleJob(RunStrategy.Monitoring, targetCount:33, invocationCount: 10000)]
    public class Monitor : TestsBase
    {
        [Benchmark]
        public void Singleton() => Adapter.Singleton();

        [Benchmark]
        public void Unregistered() => Adapter.Resolve(typeof(object), null);

        [Benchmark]
        public void Transient() => Adapter.Resolve(typeof(Poco), null);

        [Benchmark]
        public void Mapping() => Adapter.Resolve(typeof(IService), null);

        [Benchmark]
        public void Array() => Adapter.Resolve(typeof(IService[]), null);

        [Benchmark]
        public void Enumerable() => Adapter.Resolve(typeof(IEnumerable<IService>), null);
    }
}

using BenchmarkDotNet.Attributes;
using Runner.Setup;
using System.Collections.Generic;

namespace Runner.Tests
{
    [BenchmarkCategory("Basic")]
    [Config(typeof(BenchmarkConfiguration))]
    public class ColdStart : TestsBase
    {
        //[Benchmark(Description = "new Container()")]
        //public void NewUnityContainer() => Adapter.NewContainer();

        //[Benchmark(Description = "using(var uc = new Container()){}")]
        //public void UsingUnityContainer() => Adapter.UsingContainer();

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

using BenchmarkDotNet.Attributes;
using Runner.Setup;

namespace Runner.Tests
{
    [BenchmarkCategory("Basic")]
    [Config(typeof(BenchmarkConfiguration))]
    public class Basic : TestsBase
    {
        [Benchmark(Description = "new Container()")]
        public void NewUnityContainer() => Adapter.NewContainer();

        [Benchmark(Description = "using(var uc = new Container()){}")]
        public void UsingUnityContainer() => Adapter.UsingContainer();

        [Benchmark(Description = "Container.Resolve<Container>()")]
        public void Singleton() => Adapter.Singleton();
    }
}

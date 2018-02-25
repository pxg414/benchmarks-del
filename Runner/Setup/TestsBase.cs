using System;
using System.Reflection;
using Benchmark.Abstractions;
using BenchmarkDotNet.Attributes;

namespace Runner.Tests
{
    public class TestsBase
    {
        [Params("Unity.V4", "Unity.V5", "Unity.V6")]
        protected string Version;

        protected ITestAdapter Adapter;

        [GlobalSetup]
        public void Setup()
        {
            var type = Assembly.LoadFrom($"..\\{Version}.Adapter\\{Version}.Adapter.dll")
                               .GetType($"{Version}.Adapter.TestAdapter");

            Adapter = (ITestAdapter)Activator.CreateInstance(type);
            Adapter.Container = Adapter.CreateContainer();
        }

        [IterationSetup]
        public virtual void SetupContainer()
        {
            Adapter.Container = Adapter.CreateContainer();
            Adapter.RegisterType(typeof(Poco), null);
            Adapter.RegisterTypeMapping(typeof(IService), typeof(Service), null);
            Adapter.RegisterTypeMapping(typeof(IService), typeof(Service), "1");
            Adapter.RegisterTypeMapping(typeof(IService), typeof(Service), "2");
        }

    }

    public interface IService { }
    public class Service : IService { }

    public class Poco { }
}

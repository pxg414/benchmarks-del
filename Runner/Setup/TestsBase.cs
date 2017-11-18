using System;
using System.Reflection;
using Benchmark.Abstractions;
using BenchmarkDotNet.Attributes;

namespace Runner.Tests
{
    public class TestsBase
    {
        [Params("V4", "V5", "V6")]
        protected string Version;

        protected IUnityAdapter Adapter;

        [GlobalSetup]
        public void Setup()
        {
            var type = Assembly.LoadFrom($"..\\Unity.{Version}.Adapter\\Unity.{Version}.Adapter.dll")
                               .GetType($"Unity.{Version}.Adapter.UnityTestAdapter");

            Adapter = (IUnityAdapter)Activator.CreateInstance(type);
        }

    }
}

using System;
using Benchmark.Abstractions;
using Microsoft.Practices.Unity;

namespace Unity.V4.Adapter
{
    public class UnityV4Adapter : UnityAdapterBase
    {
        public override void CreateContainer()
        {
            var container = new UnityContainer();
        }
    }
}

using System;
using Benchmark.Abstractions;

namespace Unity.V6.Adapter
{
    public class UnityV6Adapter : UnityAdapterBase
    {
        public override void CreateContainer()
        {
            var container = new UnityContainer();
        }
    }
}

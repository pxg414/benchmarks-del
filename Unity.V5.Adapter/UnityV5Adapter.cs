using System;
using Benchmark.Abstractions;

namespace Unity.V5.Adapter
{
    public class UnityV5Adapter : UnityAdapterBase
    {
        public override void CreateContainer()
        {
            var container = new UnityContainer();
        }
    }
}

using System;
using Benchmark.Abstractions;

namespace Unity.V5.Adapter
{
    public class UnityTestAdapter : UnityAdapterBase<UnityContainer>
    {
        protected override UnityContainer CreateContainer()
        {
            return new UnityContainer();
        }

    }
}

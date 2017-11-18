using System;
using Benchmark.Abstractions;
using Microsoft.Practices.Unity;

namespace Unity.V4.Adapter
{
    public class UnityTestAdapter : UnityAdapterBase<UnityContainer>
    {
        protected override UnityContainer CreateContainer()
        {
            return new UnityContainer();
        }

    }
}

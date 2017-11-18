using Benchmark.Abstractions;

namespace Unity.V6.Adapter
{
    public class UnityTestAdapter : UnityAdapterBase<UnityContainer>
    {
        protected override UnityContainer CreateContainer()
        {
            return new UnityContainer();
        }
    }
}

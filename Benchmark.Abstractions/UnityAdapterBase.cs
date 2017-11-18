using System;

namespace Benchmark.Abstractions
{
    public interface IUnityAdapter
    {
        void NewUnityContainer();

        void UsingUnityContainer();
    }

    public abstract class UnityAdapterBase<T> : IUnityAdapter where T : IDisposable 
    {
        protected abstract T CreateContainer();

        public virtual void NewUnityContainer() { T container = CreateContainer(); }

        public virtual void UsingUnityContainer() { using (T container = CreateContainer()) { } }

        public virtual void RegisterInstance()
        {
        }
    }
}

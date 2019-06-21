using Benchmark.Abstractions;
using System;
using Unity.Lifetime;

namespace Unity.V6.Adapter
{
    public class TestAdapter : TestAdapterBase<UnityContainer>
    {
        public override object CreateContainer()
        {
            return new UnityContainer();
        }

        public override object Singleton()
        {
            return ((IUnityContainer)Container).Resolve(typeof(IUnityContainer), null);
        }

        public override object Resolve(Type type, string name)
        {
            return ((IUnityContainer)Container).Resolve(type, name);
        }

        public override object RegisterType(Type type, string name)
        {
            return ((IUnityContainer)Container).RegisterType(null, type, name);
        }
                                                                                                                       
        public override object RegisterTypeSingleton(Type type, string name)
        {
            return ((IUnityContainer)Container).RegisterType(type, name, new ContainerControlledLifetimeManager());
        }

        public override object RegisterTypeMapping(Type from, Type to, string name)
        {
            return ((IUnityContainer)Container).RegisterType(from, to, name);
        }

        public override object RegisterTypeMappingSingleton(Type from, Type to, string name)
        {
            return ((IUnityContainer)Container).RegisterType(from, to, name, new ContainerControlledLifetimeManager());
        }
    }
}

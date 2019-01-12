using Benchmark.Abstractions;
using Microsoft.Practices.Unity;
using System;

namespace Unity.V4.Adapter
{
    public class TestAdapter : TestAdapterBase<UnityContainer>
    {
        public override object CreateContainer()
        {
            return new UnityContainer();
        }

        public override object Singleton()
        {
            return ((UnityContainer)Container).Resolve(typeof(IUnityContainer), null, new ResolverOverride[0]) ;
        }

        public override object Resolve(Type type, string name)
        {
            return ((UnityContainer)Container).Resolve(type, name, new ResolverOverride[0]);
        }

        public override object RegisterType(Type type, string name)
        {
            return ((UnityContainer)Container).RegisterType(null, type, name, null, new InjectionMember[0]);
        }

        public override object RegisterTypeSingleton(Type type, string name)
        {
            return ((UnityContainer)Container).RegisterType(null, type, name, new ContainerControlledLifetimeManager(), new InjectionMember[0]);
        }

        public override object RegisterTypeMapping(Type from, Type to, string name)
        {
            return ((UnityContainer)Container).RegisterType(from, to, name, null, new InjectionMember[0]);
        }

        public override object RegisterTypeMappingSingleton(Type from, Type to, string name)
        {
            return ((UnityContainer)Container).RegisterType(from, to, name, new ContainerControlledLifetimeManager(), new InjectionMember[0]);
        }
    }
}

using System;
using System.Collections.Generic;

namespace Benchmark.Abstractions
{
    public interface ITestAdapter
    {
        object Container { get; set; }

        object CreateContainer();

        void NewContainer();

        void UsingContainer();

        object Singleton();

        object Resolve(Type type, string name);


        object RegisterType(Type type, string name);

        object RegisterTypeSingleton(Type type, string name);

        object RegisterTypeMapping(Type from, Type to, string name);

        object RegisterTypeMappingSingleton(Type from, Type to, string name);

        void RegisterTypes(IEnumerable<Type> types);

        void RegisterTypeWithNames(Type type, IEnumerable<string> names);

        void RegisterTypesWithNames(IEnumerable<Type> types, IEnumerable<string> names);
    }

    public abstract class TestAdapterBase<T> : ITestAdapter where T : IDisposable
    {
        public object Container { get; set; }

        public abstract object CreateContainer();

        public virtual void NewContainer() { var container = CreateContainer(); }

        public virtual void UsingContainer() { using (var container = (T)CreateContainer()) { } }

        public abstract object Singleton();

        public abstract object Resolve(Type type, string name);

        public abstract object RegisterType(Type type, string name);

        public abstract object RegisterTypeSingleton(Type type, string name);

        public abstract object RegisterTypeMapping(Type from, Type to, string name);

        public abstract object RegisterTypeMappingSingleton(Type from, Type to, string name);

        public virtual void RegisterTypes(IEnumerable<Type> types)
        {
            foreach (var type in types)
            {
                RegisterType(type, null);
            }
        }

        public virtual void RegisterTypeWithNames(Type type, IEnumerable<string> names)
        {
            foreach (var name in names)
            {
                RegisterType(type, name);
            }
        }

        public virtual void RegisterTypesWithNames(IEnumerable<Type> types, IEnumerable<string> names)
        {
            foreach (var type in types)
            {
                foreach (var name in names)
                {
                    RegisterType(type, name);
                }
            }
        }

        public virtual void RegisterInstance()
        {
        }
    }
}

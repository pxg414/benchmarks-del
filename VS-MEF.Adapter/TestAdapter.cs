using System;
using System.Collections.Generic;
using Benchmark.Abstractions;
using Microsoft.VisualStudio.Composition;

namespace VS_MEF.Adapter
{
    public class TestAdapter : TestAdapterBase<ExportProvider>
    {
        public override object CreateContainer()
        {
            // Build up an empty catalog
            var catalog = ComposableCatalog.Create(Resolver.DefaultInstance);

            // Assemble the parts into a valid graph.
            var config = CompositionConfiguration.Create(catalog);

            // Prepare an ExportProvider factory based on this graph.
            var epf = config.CreateExportProviderFactory();

            // Create an export provider, which represents a unique container of values.
            return epf.CreateExportProvider();
        }

        public override object Singleton()
        {
            return ((ExportProvider)Container).GetExport<ExportProvider>();
        }

        public override object RegisterType(Type type, string name)
        {
            throw new NotImplementedException();
        }

        public override object RegisterTypeSingleton(Type type, string name)
        {
            throw new NotImplementedException();
        }

        public override object RegisterTypeMapping(Type from, Type to, string name)
        {
            throw new NotImplementedException();
        }

        public override object RegisterTypeMappingSingleton(Type from, Type to, string name)
        {
            throw new NotImplementedException();
        }

        public override void RegisterTypes(IEnumerable<Type> types)
        {
            throw new NotImplementedException();
        }

        public override void RegisterTypeWithNames(Type type, IEnumerable<string> names)
        {
            throw new NotImplementedException();
        }
    }
}

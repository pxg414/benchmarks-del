using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Benchmark.Abstractions;
using BenchmarkDotNet.Attributes;
using Unity.V4.Adapter;
using Unity.V5.Adapter;
using Unity.V6.Adapter;

namespace Runner
{
    public class CreateContainer
    {
        private UnityAdapterBase _adapter_v4 = new UnityV4Adapter();
        private UnityAdapterBase _adapter_v5 = new UnityV5Adapter();
        private UnityAdapterBase _adapter_v6 = new UnityV6Adapter();

        [Benchmark]
        public void CreateContainer_v4()
        {
            _adapter_v4
        }

        public void CreateContainer_v5()
        {
        }

        public void CreateContainer_v6()
        {
        }
    }
}

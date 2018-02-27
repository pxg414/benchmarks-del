using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;

namespace Runner.Setup
{
    public class BenchmarkConfiguration : ManualConfig
    {
        public BenchmarkConfiguration()
        {
            //Add(DefaultConfig.Instance); // *** add default loggers, reporters etc? ***
            Add(Job.Default.WithUnrollFactor(1).WithInvocationCount(50000));
            Set(new NameVersionOrderProvider());
        }
    }
}

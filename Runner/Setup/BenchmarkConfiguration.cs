using BenchmarkDotNet.Configs;

namespace Runner.Setup
{
    public class BenchmarkConfiguration : ManualConfig
    {
        public BenchmarkConfiguration()
        {
            Set(new NameVersionOrderProvider());
        }
    }
}

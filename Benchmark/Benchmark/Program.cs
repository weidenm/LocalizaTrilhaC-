using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;
using System.Text;

namespace Benchmark
{   public class TestaString
    {

        [Benchmark]

        public void StringBuilderTest()
        {
            var sb = new StringBuilder();
            for (int i=0;i< 1000; i++)
            {
                sb.Append(i.ToString());
            }
        }

        [Benchmark]
        public void StringConcatTest()
        {
            var st = "";
            for (int i = 0; i < 1000; i++)
            {
                st += i.ToString();
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run(typeof(Program).Assembly);
        }
    }
}
    
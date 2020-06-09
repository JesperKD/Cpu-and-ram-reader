using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Cpu_and_ram_reader
{
    class Program
    {
        static void Main(string[] args)
        {
            RunTest();
        }

        private static void RunTest()
        {
            bool done = false;
            PerformanceCounter cpuPercent = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            PerformanceCounter ramUsed = new PerformanceCounter("Memory", "Available MBytes");
            while (!done)
            {
                float t = cpuPercent.NextValue();
                float r = ramUsed.NextValue();
                Console.WriteLine(String.Format("CPU: " + t + "%"));
                Console.WriteLine(string.Format("RAM: " + r + "MB"));
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine();
            }
        }
    }
}

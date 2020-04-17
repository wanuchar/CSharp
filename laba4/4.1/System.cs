using System;
using System.Runtime.InteropServices;
using System.Text;


namespace Laba4._1
{
    class System
    {
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GlobalMemoryStatusEx(Memory info);
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern void GetSystemInfo(CPU info);

        public static string CPUInform()
        {
            CPU info = new CPU();
            GetSystemInfo(info);
            StringBuilder strCPU = new StringBuilder();
            strCPU.Append("Processor architecture is ");
            switch (info.ProcessorArchitecture)
            {
                case 0:
                    strCPU.Append("x86\n");
                    break;
                case 5:
                    strCPU.Append("ARM\n");
                    break;
                case 6:
                    strCPU.Append("Itanium-based\n");
                    break;
                case 9:
                    strCPU.Append("x64\n");
                    break;
                case 12:
                    strCPU.Append("ARM64\n");
                    break;
                default:
                    strCPU.Append("unknown\n");
                    break;
            }
            strCPU.Append($"Number of processors: {info.NumberOfProcessors + 1}\n");
            strCPU.Append($"");
            return strCPU.ToString();
        }

        public static string MemoryInform()
        {
            Memory info = new Memory();
            GlobalMemoryStatusEx(info);
            StringBuilder strMem = new StringBuilder();
            strMem.Append($"Memory architecture is {info.Length}\n");
            strMem.Append($"Used memory is {info.MemoryLoad}%\n");
            strMem.Append($"Total physical memory is {info.TotalPhys / Math.Pow(2, 30)} GB\n");
            strMem.Append($"Available physical memory is {info.AvailPhys / Math.Pow(2, 30)} GB\n");
            strMem.Append($"Committed memory limit is {info.TotalPageFile / Math.Pow(2, 30)} GB\n");
            strMem.Append($"Available committed memory is {info.AvailPageFile / Math.Pow(2, 30)} GB\n");
            strMem.Append($"Total virtual memory is {info.TotalVirtual / Math.Pow(2, 30)} GB\n");
            strMem.Append($"Availible virtual memory is {info.AvailVirtual / Math.Pow(2, 30)} GB\n");
            return strMem.ToString();
        }
    }
}

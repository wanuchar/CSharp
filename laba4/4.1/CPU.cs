using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace Laba4._1
{
    [StructLayout(LayoutKind.Sequential)]
    class CPU
    {
        public ushort ProcessorArchitecture;
        public ushort Reserved;
        public uint PageSize;
        public IntPtr MinimumApplicationAddress;
        public IntPtr MaximumApplicationAddress;
        public IntPtr ActiveProcessorMask;
        public uint NumberOfProcessors;
        public uint ProcessorType;
        public uint AllocationGranularity;
        public ushort ProcessorLevel;
        public ushort ProcessorRevision;
    }
}

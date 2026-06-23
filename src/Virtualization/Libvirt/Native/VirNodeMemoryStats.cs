using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace IDNT.AppBasics.Virtualization.Libvirt.Native
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VirNodeMemoryStats
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
        public string field;

        public ulong value;
    }
}

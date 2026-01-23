using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace IDNT.AppBasics.Virtualization.Libvirt.Native
{
    internal static class LibvirtConstants
    {
        public const int VIR_NODE_CPU_STATS_FIELD_LENGTH = 80;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct VirNodeCPUStats
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = LibvirtConstants.VIR_NODE_CPU_STATS_FIELD_LENGTH)]
        public string field;

        public ulong value;
    }
}

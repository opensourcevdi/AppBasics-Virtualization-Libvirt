using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace IDNT.AppBasics.Virtualization.Libvirt.Native
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VirDomainBlockJobInfo
    {
        public VirDomainBlockJobType type;
        public ulong bandwidth;
        public ulong cur;
        public ulong end;
    }
}

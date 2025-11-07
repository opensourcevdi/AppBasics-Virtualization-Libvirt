using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IDNT.AppBasics.Virtualization.Libvirt.Native
{
    internal static class NativeLib
    {
#if WINDOWS
        public const string Libvirt = "libvirt-0.dll";
        public const string LibvirtQemu = "libvirt-qemu-0.dll";
        public const string LibC = "msvcrt.dll";
#else
        public const string Libvirt = "libvirt.so.0";
        public const string LibvirtQemu = "libvirt-qemu.so.0";
        public const string LibC = "libc.so.6";
#endif
    }
}
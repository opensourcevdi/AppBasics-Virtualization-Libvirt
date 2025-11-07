/*
 * Libvirt-dotnet
 * 
 * Copyright 2020 IDNT (https://www.idnt.net) and Libvirt-dotnet contributors.
 * 
 * This project incorporates work by the following original authors and contributors
 * to libvirt-csharp:
 *    
 *    Copyright (C) 
 *      Arnaud Champion <arnaud.champion@devatom.fr>
 *      Jaromír Červenka <cervajz@cervajz.com>
 *
 * Licensed under the GNU Lesser General Public Library, Version 2.1 (the "License");
 * you may not use this file except in compliance with the License. You may obtain a 
 * copy of the License at
 *
 * https://www.gnu.org/licenses/lgpl-2.1.en.html
 * 
 * or see LICENSE for a copy of the license terms. Unless required by applicable 
 * law or agreed to in writing, software distributed under the License is distributed 
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express 
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 */
using System;
using System.Runtime.InteropServices;
using System.Text;

namespace IDNT.AppBasics.Virtualization.Libvirt.Native
{
    ///<summary>
    /// class for libvirt qemu specific methods
    ///</summary>
    public static class NativeVirQemu
    {
        [DllImport(NativeLib.LibvirtQemu, CallingConvention = CallingConvention.Cdecl, EntryPoint = "virDomainQemuMonitorCommand")]
        private static extern int virDomainQemuMonitorCommand(
            IntPtr domain,
            [MarshalAs(UnmanagedType.LPUTF8Str)] string cmd,
            out IntPtr result,
            VirDomainQemuMonitorCommandFlags flags);

        [DllImport(NativeLib.Libvirt, CallingConvention = CallingConvention.Cdecl, EntryPoint = "virFree")]
        private static extern int virFree(IntPtr ptr);

        public static int MonitorCommand(IntPtr domain, string cmd, out string result, VirDomainQemuMonitorCommandFlags flags)
        {
            IntPtr resultPtr;
            int ret = virDomainQemuMonitorCommand(domain, cmd, out resultPtr, flags);

            if (ret < 0 || resultPtr == IntPtr.Zero)
            {
                result = null;
                return ret;
            }

            result = Marshal.PtrToStringUTF8(resultPtr);

            // Free memory allocated by libvirt
            NativeFunctions.Free(resultPtr);

            return ret;
        }
    }
}

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

namespace IDNT.AppBasics.Virtualization.Libvirt.Native
{
    /// <summary>
    /// The Secret class expose all libvirt secret related functions
    /// </summary>
    public class NativeVirSecret
    {
        [DllImport(NativeLib.Libvirt, CallingConvention = CallingConvention.Cdecl, EntryPoint = "virSecretDefineXML")]
        public static extern IntPtr DefineXML(IntPtr conn, string xml, int flags);

        [DllImport(NativeLib.Libvirt, CallingConvention = CallingConvention.Cdecl, EntryPoint = "virSecretFree")]
        public static extern int Free(IntPtr secret);

        // TODO virSecretGetConnect

        // TODO virSecretGetUUID

        // TODO virSecretGetUUIDString

        [DllImport(
            NativeLib.Libvirt,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "virSecretGetUUIDString"
        )]
        private static extern int GetUUIDString(IntPtr secret, [Out] char[] uuid);

        public static string GetUUIDString(IntPtr secret)
        {
            char[] uuidArray = new char[36];
            GetUUIDString(secret, uuidArray);
            return new string(uuidArray);
        }

        // TODO virSecretGetUsageID

        // TODO virSecretGetUsageType

        // TODO virSecretGetValue

        // TODO virSecretGetXMLDesc

        // TODO virSecretLookupByUUID

        // TODO virSecretLookupByUUIDString

        // TODO virSecretLookupByUsage
        [DllImport(
            NativeLib.Libvirt,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "virSecretLookupByUsage"
        )]
        public static extern IntPtr LookupByUsage(IntPtr conn, virSecretUsageType usageType, string usageID);

        // TODO virSecretRef

        // TODO virSecretSetValue
        [DllImport(NativeLib.Libvirt, CallingConvention = CallingConvention.Cdecl, EntryPoint = "virSecretSetValue")]
        public static extern int SetValue(IntPtr secret, byte[] value, uint valueSize, int flags);

        // TODO virSecretUndefine
    }

    public enum virSecretUsageType
    {
        VIR_SECRET_USAGE_TYPE_NONE = 0,
        VIR_SECRET_USAGE_TYPE_VOLUME = 1,
        VIR_SECRET_USAGE_TYPE_CEPH = 2,
        VIR_SECRET_USAGE_TYPE_ISCSI = 3,
        VIR_SECRET_USAGE_TYPE_TLS = 4,
        VIR_SECRET_USAGE_TYPE_VTPM = 5,
        VIR_SECRET_USAGE_TYPE_LAST = 6,
    }
}

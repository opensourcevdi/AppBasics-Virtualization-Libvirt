using IDNT.AppBasics.Virtualization.Libvirt.Events;
using System;
using System.Runtime.InteropServices;


namespace IDNT.AppBasics.Virtualization.Libvirt.Native
{
    /// <summary>
    /// A callback function to be registered, and called when a connection is closed
    /// </summary>
    /// <param name="conn">virConnect connection</param>
    /// <param name="reason">the reason for the connection closure</param>
    /// <param name="opaque">opaque user data</param>
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void VirConnectCloseFunc(IntPtr conn, VirConnectCloseReason reason, IntPtr opaque);

}   

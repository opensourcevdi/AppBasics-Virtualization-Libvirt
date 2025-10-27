using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace IDNT.AppBasics.Virtualization.Libvirt.Native
{
    public enum VirDomainEventGraphicsPhase
    {

        /// <summary>
        /// Initial socket connection established
        /// </summary>
        VIR_DOMAIN_EVENT_GRAPHICS_CONNECT = 0,

        /// <summary>
        /// Authentication & setup completed
        /// </summary>
        VIR_DOMAIN_EVENT_GRAPHICS_INITIALIZE = 1,
        /// <summary>
        /// Client disconnected
        /// </summary>
        VIR_DOMAIN_EVENT_GRAPHICS_DISCONNECT = 2,
        /// <summary>
        /// Final socket disconnection
        /// </summary>
        VIR_DOMAIN_EVENT_GRAPHICS_LAST = 3
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VirDomainEventGraphicsAddress
    {
        public int family;

        [MarshalAs(UnmanagedType.LPStr)]
        public string node;

        [MarshalAs(UnmanagedType.LPStr)]
        public string service;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VirDomainEventGraphicsSubjectIdentity
    {
        [MarshalAs(UnmanagedType.LPStr)]
        public string type;

        [MarshalAs(UnmanagedType.LPStr)]
        public string name;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VirDomainEventGraphicsSubject
    {
        public int nidentity;
        public IntPtr identities; // pointer to virDomainEventGraphicsSubjectIdentity
    }
}
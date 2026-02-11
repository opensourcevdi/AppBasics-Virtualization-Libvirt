/*
 * Copyright (C)
 *
 *   Arnaud Champion <arnaud.champion@devatom.fr>
 *   Jaromír Červenka <cervajz@cervajz.com>
 *   Marcus Zoller <marcus.zoller@idnt.net>
 *
 * and the Libvirt-CSharp contributors.
 *
 * Licensed under the GNU Lesser General Public Library, Version 2.1 (the "License");
 * you may not use this file except in compliance with the License. You may obtain a
 * copy of the License at
 *
 * https://www.gnu.org/licenses/lgpl-2.1.en.html
 *
 * or see COPYING.LIB for a copy of the license terms. Unless required by applicable
 * law or agreed to in writing, software distributed under the License is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using IDNT.AppBasics.Virtualization.Libvirt.Events;

namespace IDNT.AppBasics.Virtualization.Libvirt.Native
{
    /// <summary>
    /// A callback function to be registered, and called when a domain event occurs
    /// </summary>
    /// <param name="conn">virConnect connection </param>
    /// <param name="dom">The domain on which the event occured</param>
    /// <param name="evt">The specfic virDomainEventType which occured</param>
    /// <param name="detail">event specific detail information</param>
    /// <param name="opaque">opaque user data</param>
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void VirConnectDomainEventCallback(
        IntPtr conn,
        IntPtr dom,
        [MarshalAs(UnmanagedType.I4)] VirDomainEventType evt,
        int detail,
        IntPtr opaque
    );

    /// <summary>
    /// The callback signature to use when registering for an event of type VIR_DOMAIN_EVENT_ID_GRAPHICS with virConnectDomainEventRegisterAny()
    /// </summary>
    /// <param name="conn">virConnect connection </param>
    /// <param name="dom">The domain on which the event occured</param>
    /// <param name="phase">The specific phase of the graphics event</param>
    /// <param name="local">Local address information</param>
    /// <param name="remote">Remote address information</param>
    /// <param name="authScheme">Authentication scheme used</param>
    /// <param name="subject">Subject of the event</param>
    /// <param name="opaque">Opaque user data</param>
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void VirConnectDomainEventGraphicsCallback(
        IntPtr conn,
        IntPtr dom,
        VirDomainEventGraphicsPhase phase,
        ref VirDomainEventGraphicsAddress local,
        ref VirDomainEventGraphicsAddress remote,
        [MarshalAs(UnmanagedType.LPStr)] string authScheme,
        ref VirDomainEventGraphicsSubject subject,
        IntPtr opaque
    );

    /// <summary>
    /// The callback signature to use when registering for an event of type VIR_DOMAIN_EVENT_ID_BLOCK_JOB with virConnectDomainEventRegisterAny()
    /// </summary>
    /// <param name="conn">virConnect connection </param>
    /// <param name="dom">The domain on which the event occured</param>
    /// <param name="disk">The disk associated with the block job</param>
    /// <param name="type">The specific type of the block job event</param>
    /// <param name="status">The status of the block job</param>
    /// <param name="opaque">Opaque user data</param>
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void VirConnectDomainEventBlockJobCallback(
        IntPtr conn,
        IntPtr dom,
        [MarshalAs(UnmanagedType.LPStr)] string disk,
        VirDomainBlockJobType type,
        VirConnectDomainEventBlockJobStatus status,
        IntPtr opaque
    );
}

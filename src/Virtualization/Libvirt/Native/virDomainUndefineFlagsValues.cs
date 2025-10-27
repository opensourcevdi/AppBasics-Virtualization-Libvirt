using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IDNT.AppBasics.Virtualization.Libvirt.Native
{
    /// <summary>
    /// VirDomainUndefineFlagsValues
    /// </summary>
    [Flags]
    public enum VirDomainUndefineFlagsValues
    {
        /// <summary>
        /// Also remove any managed save
        /// </summary>
        VIR_DOMAIN_UNDEFINE_MANAGED_SAVE = 1,

        /// <summary>
        /// If last use of domain, then also remove any snapshot metadata
        /// </summary>
        VIR_DOMAIN_UNDEFINE_SNAPSHOTS_METADATA = 2,
        /// <summary>
        /// Also remove any nvram file
        /// </summary>
        VIR_DOMAIN_UNDEFINE_NVRAM = 4,
        /// <summary>
        /// Keep nvram file
        /// </summary>
        VIR_DOMAIN_UNDEFINE_KEEP_NVRAM = 8,
        /// <summary>
        /// If last use of domain, then also remove any checkpoint metadata
        /// </summary>
        VIR_DOMAIN_UNDEFINE_CHECKPOINTS_METADATA = 16,
        /// <summary>
        /// Also remove any TPM state
        /// </summary>
        VIR_DOMAIN_UNDEFINE_TPM = 32,
        /// <summary>
        /// Keep TPM state Future undefine control flags should come here.
        /// </summary>
        VIR_DOMAIN_UNDEFINE_KEEP_TPM = 64,

    }
}
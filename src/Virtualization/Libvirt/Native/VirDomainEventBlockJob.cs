using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace IDNT.AppBasics.Virtualization.Libvirt.Native
{
    public enum VirDomainBlockJobType
    {
        /// <summary>
        /// Placeholder
        /// </summary>
        VIR_DOMAIN_BLOCK_JOB_TYPE_UNKNOWN = 0,

        /// <summary>
        /// Block Pull (virDomainBlockPull, or virDomainBlockRebase without flags), job ends on completion
        /// </summary>
        VIR_DOMAIN_BLOCK_JOB_TYPE_PULL = 1,

        /// <summary>
        ///   Block Copy (virDomainBlockCopy, or virDomainBlockRebase with flags), job exists as long as mirroring is active
        /// </summary>
        VIR_DOMAIN_BLOCK_JOB_TYPE_COPY = 2,

        /// <summary>
        /// Block Commit (virDomainBlockCommit without flags), job ends on completion
        /// </summary>
        VIR_DOMAIN_BLOCK_JOB_TYPE_COMMIT = 3,

        /// <summary>
        /// Active Block Commit (virDomainBlockCommit with flags), job exists as long as sync is active
        /// </summary>
        VIR_DOMAIN_BLOCK_JOB_TYPE_ACTIVE_COMMIT = 4,

        /// <summary>
        /// Backup (virDomainBackupBegin)
        /// </summary>
        VIR_DOMAIN_BLOCK_JOB_TYPE_BACKUP = 5,
        VIR_DOMAIN_BLOCK_JOB_TYPE_LAST = 6,
    }

    public enum VirConnectDomainEventBlockJobStatus
    {
        VIR_DOMAIN_BLOCK_JOB_COMPLETED = 0,
        VIR_DOMAIN_BLOCK_JOB_FAILED = 1,
        VIR_DOMAIN_BLOCK_JOB_CANCELED = 2,
        VIR_DOMAIN_BLOCK_JOB_READY = 3,
        VIR_DOMAIN_BLOCK_JOB_LAST = 4,
    }
}

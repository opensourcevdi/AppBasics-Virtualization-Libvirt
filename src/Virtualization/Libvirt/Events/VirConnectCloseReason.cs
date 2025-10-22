namespace IDNT.AppBasics.Virtualization.Libvirt.Events
{
    public enum VirConnectCloseReason
    {
        /// <summary>
        /// Misc I/O error
        /// </summary>
        VIR_CONNECT_CLOSE_REASON_ERROR = 0,
        /// <summary>
        /// End-of-file from server
        /// </summary>
        VIR_CONNECT_CLOSE_REASON_EOF = 1,
        /// <summary>
        /// Keepalive timer triggered
        /// </summary>
        VIR_CONNECT_CLOSE_REASON_KEEPALIVE = 2,
        /// <summary>
        /// Client requested it
        /// </summary>
        VIR_CONNECT_CLOSE_REASON_CLIENT = 3,
        /// <summary>
        /// Last reason
        /// </summary>
        VIR_CONNECT_CLOSE_REASON_LAST = 4,
    }
}
using System;

namespace MPL.CryptoMonkey.Protocol
{
    /// <summary>
    /// An interface that defines a CyptoMonkey protocol.
    /// </summary>
    public interface IMessageProtocol
    {
        /// <summary>
        /// Outputs the specified message as text.
        /// </summary>
        /// <param name="outboundMessage">An IOutboundMessage that is the message to output.</param>
        /// <returns>A string containing the output message.</returns>
        string OutputText(IOutboundMessage outboundMessage);
    }
}
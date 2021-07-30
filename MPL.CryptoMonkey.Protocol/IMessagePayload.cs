using System;

namespace MPL.CryptoMonkey.Protocol
{
    /// <summary>
    /// An interface the defines a message payload.
    /// </summary>
    public interface IMessagePayload
    {
        /// <summary>
        /// Gets the raw payload.
        /// </summary>
        byte[] RawPayload { get; }

        /// <summary>
        /// Gets a textual representation of the payload.
        /// </summary>
        string TextualPayload { get; }
    }
}
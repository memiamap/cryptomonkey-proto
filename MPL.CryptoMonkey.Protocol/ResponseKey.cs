using System;

namespace MPL.CryptoMonkey.Protocol
{
    /// <summary>
    /// A class that defines a response key.
    /// </summary>
    public class ResponseKey
    {
        /// <summary>
        /// Gets the identifier of the algorithm for the key.
        /// </summary>
        public int AlgorithmID { get; }

        /// <summary>
        /// Gets the key data.
        /// </summary>
        public string Data { get; }

        /// <summary>
        /// Gets the identifier of the key.
        /// </summary>
        public long ID { get; }
    }
}
using System;

namespace MPL.CryptoMonkey.Protocol.Payloads
{
    #region Declarations
    #region _Enumerations_
    /// <summary>
    /// An enumeration that defines the textual format of a data payload.
    /// </summary>
    public enum DataPayloadTextFormat : int
    {
        /// <summary>
        /// The textual format is undefined.
        /// </summary>
        Undefined = 0,

        /// <summary>
        /// The textual format is Base64 encoding.
        /// </summary>
        Base64,

        /// <summary>
        /// The textual format is hexadecimal with lowercase characters.
        /// </summary>
        HexadecimalLowercase,

        /// <summary>
        /// The textual format is hexadecimal with uppercase characters.
        /// </summary>
        HexadecimalUppercase
    }

    #endregion
    #endregion
}
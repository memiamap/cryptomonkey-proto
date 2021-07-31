using System;

namespace MPL.CryptoMonkey.Protocol.Json
{
    /// <summary>
    /// A class that defines an implementation of a JSON-based CryptoMonkey protocol.
    /// </summary>
    public class JsonMessageProtocol : IMessageProtocol
    {
        #region Interfaces
        #region _IMessageProtocol_
        string IMessageProtocol.OutputText(IOutboundMessage outboundMessage)
        {
            return null;
        }

        #endregion
        #endregion
    }
}
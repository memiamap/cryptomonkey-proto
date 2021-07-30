using System;
using System.Text;

namespace MPL.CryptoMonkey.Protocol.Payloads
{
    /// <summary>
    /// A class that defines a string message payload.
    /// </summary>
    public class StringMessagePayload : IMessagePayload
    {
        #region Constructors
        /// <summary>
        /// Creates a new instance of the class with the specified parameters.
        /// </summary>
        /// <param name="messagePayload">A string containing the message payload.</param>
        public StringMessagePayload(string messagePayload)
            : this(messagePayload, Encoding.UTF8)
        { }

        /// <summary>
        /// Creates a new instance of the class with the specified parameters.
        /// </summary>
        /// <param name="messagePayload">A string containing the message payload.</param>
        /// <param name="textEncoding">An Encoding indicating the text encoding to use.</param>
        public StringMessagePayload(string messagePayload, Encoding textEncoding)
        {
            _messagePayload = messagePayload ?? throw new ArgumentNullException(nameof(messagePayload));
            _textEncoding = textEncoding ?? throw new ArgumentNullException(nameof(textEncoding));

            _rawPayload = _textEncoding.GetBytes(_messagePayload);
        }

        #endregion

        #region Declarations
        #region _Members_
        private readonly string _messagePayload;
        private readonly byte[] _rawPayload;
        private readonly Encoding _textEncoding;

        #endregion
        #endregion
       
        #region Interfaces
        #region __IMessagePayload__
        byte[] IMessagePayload.RawPayload => _rawPayload;

        string IMessagePayload.TextualPayload => _messagePayload;

        #endregion
        #endregion
    }
}
using MPL.Common;
using System;

namespace MPL.CryptoMonkey.Protocol.Payloads
{
    /// <summary>
    /// A class that defines a data message payload.
    /// </summary>
    public class DataMessagePayload : IMessagePayload
    {
        #region Constructors
        /// <summary>
        /// Creates a new instance of the class with the specified parameters.
        /// </summary>
        /// <param name="dataPayload">An array of byte containing the data payload.</param>
        /// <param name="textFormat">A DataPayloadTextFormat indicating the format used to convert the data to a textual payload.</param>
        public DataMessagePayload(byte[] dataPayload, DataPayloadTextFormat textFormat = DataPayloadTextFormat.Base64)
        {
            _rawPayload = dataPayload ?? throw new ArgumentNullException(nameof(dataPayload));
            _textFormat = textFormat;

        }

        #endregion

        #region Declarations
        #region _Members_
        private string _messagePayload;
        private readonly byte[] _rawPayload;
        private readonly DataPayloadTextFormat _textFormat;

        #endregion
        #endregion

        #region Methods
        #region _Private_
        private string ConvertPayload()
        {
            if (_messagePayload == null)
            {
                _messagePayload = _textFormat switch
                {
                    DataPayloadTextFormat.Base64 => Convert.ToBase64String(_rawPayload),
                    DataPayloadTextFormat.HexadecimalLowercase => _rawPayload.ToHexString(string.Empty),
                    DataPayloadTextFormat.HexadecimalUppercase => _rawPayload.ToHexString(string.Empty, false),
                    _ => throw new InvalidOperationException($"The specified data payload text format \"{_textFormat}\" is invalid")
                };
            }

            return _messagePayload;
        }

        #endregion
        #endregion

        #region Interfaces
        #region __IMessagePayload__
        byte[] IMessagePayload.RawPayload => _rawPayload;

        string IMessagePayload.TextualPayload => ConvertPayload();

        #endregion
        #endregion
    }
}
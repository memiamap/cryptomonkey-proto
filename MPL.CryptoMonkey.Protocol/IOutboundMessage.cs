using System;

namespace MPL.CryptoMonkey.Protocol
{
    /// <summary>
    /// An interface that defines an outbound message.
    /// </summary>
    public interface IOutboundMessage
    {
        /// <summary>
        /// Gets the identifier of the conversation this message belongs to.
        /// </summary>
        Guid ConversationID { get; }

        /// <summary>
        /// Gets an indication of whether this is a group message.
        /// </summary>
        bool IsGroupMessage { get; }

        /// <summary>
        /// Gets the payload of the message.
        /// </summary>
        IMessagePayload MessagePayload { get; }

        /// <summary>
        /// Gets the identifier of the conversation participant the created the message.
        /// </summary>
        Guid ParticipantID { get; }

        /// <summary>
        /// Gets the identifier of the conversation recipient for this message.
        /// </summary>
        Guid ReceipientID { get; }

        /// <summary>
        /// Gets the response key.
        /// </summary>
        ResponseKey ResponseKey { get; }

        /// <summary>
        /// Gets the sequence identifier of the message.
        /// </summary>
        long SequenceID { get; }
    }
}
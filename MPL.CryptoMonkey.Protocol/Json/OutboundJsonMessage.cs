using System;

namespace MPL.CryptoMonkey.Protocol.Json
{
    public class OutboundJsonMessage : IOutboundMessage
    {
        Guid IOutboundMessage.ConversationID => throw new NotImplementedException();

        bool IOutboundMessage.IsGroupMessage => throw new NotImplementedException();

        IMessagePayload IOutboundMessage.MessagePayload => throw new NotImplementedException();

        Guid IOutboundMessage.ParticipantID => throw new NotImplementedException();

        Guid IOutboundMessage.ReceipientID => throw new NotImplementedException();

        ResponseKey IOutboundMessage.ResponseKey => throw new NotImplementedException();

        long IOutboundMessage.SequenceID => throw new NotImplementedException();
    }
}
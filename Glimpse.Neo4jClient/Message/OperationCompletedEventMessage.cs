using System;
using Glimpse.Core.Message;

namespace Glimpse.Neo4JClient.Message
{
    public class OperationCompletedEventMessage : MessageBase
    {
        public string Query { get; set; }

        public int ResultCount { get; set; }

        public TimeSpan Time { get; set; }
    }
}
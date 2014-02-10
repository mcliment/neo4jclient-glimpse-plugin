using Glimpse.Core.Extensibility;
using Glimpse.Neo4jClient.Message;
using Neo4jClient;

namespace Glimpse.Neo4jClient.Inspector
{
    public class OperationCompletedEventInspector : IInspector
    {
        private static IMessageBroker broker;

        public void OperationCompletedLog(object sender, OperationCompletedEventArgs eventArgs)
        {
            var message = new OperationCompletedEventMessage()
            {
                Query = eventArgs.QueryText,
                ResultCount = eventArgs.ResourcesReturned,
                Time = eventArgs.TimeTaken
            };

            Publish(message);
        }

        private static void Publish(OperationCompletedEventMessage message)
        {
            broker.Publish(message);
        }

        public void Setup(IInspectorContext context)
        {
            broker = context.MessageBroker;
        }
    }
}
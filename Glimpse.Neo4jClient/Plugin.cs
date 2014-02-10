using System.Linq;
using Glimpse.Core.Extensibility;
using Glimpse.Core.Extensions;
using Glimpse.Neo4jClient.Inspector;
using Glimpse.Neo4jClient.Message;
using Neo4jClient;

namespace Glimpse.Neo4jClient
{
    public class Plugin : TabBase, ITabSetup
    {
        public override object GetData(ITabContext context)
        {
            var messages = context.GetMessages<OperationCompletedEventMessage>().ToList();

            var section = Core.Tab.Assist.Plugin.Create("Query", "Count", "Time");

            foreach (var message in messages)
            {
                section.AddRow()
                    .Column(message.Query)
                    .Column(message.ResultCount)
                    .Column(message.Time);
            }

            return section;
        }

        public override string Name { get { return "Neo4jClient"; } }

        public static void RegisterGraphClient(IGraphClient client)
        {
            var inspector = new OperationCompletedEventInspector();

            client.OperationCompleted += inspector.OperationCompletedLog;
        }

        public void Setup(ITabSetupContext context)
        {
            context.PersistMessages<OperationCompletedEventMessage>();
        }
    }
}
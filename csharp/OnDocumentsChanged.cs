using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.SignalRService;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace SignalRFlights
{
    public static class OnDocumentChanged
    {
        [FunctionName("OnDocumentsChanged")]
        public static async Task Run(
            [CosmosDBTrigger("demo", "flights", ConnectionStringSetting = "AzureWebJobsCosmosDBConnectionString")]
                IEnumerable<object> updatedFlights,
            [SignalR(HubName = "flights")] IAsyncCollector<SignalRMessage> signalRMessages,
            ILogger log)
        {
            foreach(var flight in updatedFlights)
            {
                await signalRMessages.AddAsync(new SignalRMessage
                {
                    Target = "flightUpdated",
                    Arguments = new[] { flight }
                });
            }
        }
    }
}


using System.IO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Azure.WebJobs.Host;
using Newtonsoft.Json;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace SignalRFlights
{
    public static class GetFlights
    {
        [FunctionName("GetFlights")]
        public static IActionResult Run(
            [HttpTrigger(AuthorizationLevel.Anonymous)] HttpRequest req,
            [CosmosDB("demo", "flights", ConnectionStringSetting = "AzureWebJobsCosmosDBConnectionString")]
                IEnumerable<object> flights,
            ILogger log)
        {
            return new OkObjectResult(flights);
        }
    }
}

using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace VehicleVanna_Kelly
{
    public static class Function1
    {
        [FunctionName("Function1")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            [Queue("queuename")] IAsyncCollector<Vehicles> vehicleQueue, ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");
            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            var Vehicle = JsonConvert.DeserializeObject<Vehicles>(requestBody);
            await vehicleQueue.AddAsync(Vehicle);

            log.LogInformation($"Buyer's Name: {Vehicle.FirstName} {Vehicle.LastName}");

            string responseMessage = $"Buyer {Vehicle.FirstName} {Vehicle.LastName} ({Vehicle.Email}) purchased a" +
                $" {Vehicle.Year} {Vehicle.Make} {Vehicle.Model} {Vehicle.VehicleType} with list price of " +
                $"{Vehicle.ListPrice.ToString("C")}. With discount applied, purchase price is {(Vehicle.ListPrice - (Vehicle.ListPrice * .085m)).ToString("C")}";

            return new OkObjectResult(responseMessage);
        }
    }
}
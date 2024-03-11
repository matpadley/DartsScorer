using System;
using System.IO;
using System.Threading.Tasks;
using DartsScorer.Checkout;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace DartsScrorer.Checkout;

public static class HttpCheckout
{
    [FunctionName("HttpCheckout")]
    public static async Task<IActionResult> RunAsync(
        [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req, ILogger log)
    {
        log.LogInformation("C# Starts Gets Darts Checkout.");

        var checkoutCalculator = new CheckoutCalculator();

        string score = req.Query["score"];

        string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
        dynamic data = JsonConvert.DeserializeObject(requestBody);
        score = score ?? data?.score;

        return score != null
            ? (ActionResult)new OkObjectResult($"{checkoutCalculator.CalculateCheckout(Int32.Parse(score))}")
            : new BadRequestObjectResult("Please pass a name on the query string or in the request body");
        
    }
}
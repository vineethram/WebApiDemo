using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
using System.Net;
using Newtonsoft.Json;

namespace DemoFUNC
{
    public static class Function1
    {
        [FunctionName("Function1")]
        public static void Run([TimerTrigger("* * * * *")]TimerInfo myTimer, ILogger log)
        {
            execute();
            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");
        }
        public static void execute()
        {
            var url = "http://newsapi.org/v2/top-headlines?" +
                      "country=in&" +
                      "apiKey=89961c5041f041738514c6882ae40d59";

            var json = JsonConvert.DeserializeObject(new WebClient().DownloadString(url));

            Console.WriteLine(json);
        }
    }
}

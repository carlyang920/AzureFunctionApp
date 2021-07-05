using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using Sample.FunctionApp.Services;

namespace Sample.FunctionApp.Functions
{
    public class FunctionTest
    {
        private readonly MyServices _myServices;

        public FunctionTest(
            MyServices myServices
            )
        {
            _myServices = myServices;
        }

        [FunctionName("FunctionTest")]
        public void Run([TimerTrigger("*/2 * * * * *")]TimerInfo myTimer, ILogger log)
        {
            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");
        }
    }
}

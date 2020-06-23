using System;
using System.IO;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace Company.Function
{
    public static class ProcessMyBlob
    {
        [FunctionName("ProcessMyBlob")]
        public static void Run(
            [BlobTrigger("demo/{name}", Connection = "AzureWebJobsStorage")]Stream myBlob, 
            [BlobTrigger("output/{name}", Connection = "AzureWebJobsStorage")]Stream outputBlob, 
            string name, 
            ILogger log)
        {
            var length = myBlob.Length;
            myBlob.CopyTo(outputBlob);
        }
    }
}

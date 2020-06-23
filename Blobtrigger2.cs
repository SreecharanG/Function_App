using System;
using System.IO;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace Company.Function
{
    public static class Blobtrigger2
    {
        [FunctionName("Blobtrigger2")]
        public static void Run([BlobTrigger("demo/{name}", Connection = "AzureWebJobsStorage")]Stream myBlob,
        [BlobTrigger("output/{name}", Connection = "AzureWebJobsStorage")]Stream myBloboutput,
         
        string name, 
        ILogger log)
        {
            myBlob.CopyTo(myBloboutput);
        }
    }
}

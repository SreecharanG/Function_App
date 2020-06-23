using System;
using System.IO;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace Company.Function
{
    public static class BlobTrigger
    {
        [FunctionName("BlobTrigger")]
        public static void Run(
            [BlobTrigger("demo/{name}", Connection = "storageaccountvpcar92f4_STORAGE")]Stream myBlob, 
            [BlobTrigger("output/{name}", Connection = "storageaccountvpcar92f4_STORAGE")]Stream outputBlob, 
            string name, 
            ILogger log)
        {
            var length = myBlob.Length;
            myBlob.CopyTo(outputBlob);
        }
    }
}

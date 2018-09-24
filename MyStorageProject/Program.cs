using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Auth;
using Microsoft.WindowsAzure.Storage.Blob;
using Microsoft.WindowsAzure.Storage.Table;
using Microsoft.WindowsAzure.Storage.Queue;

namespace MyStorageProject
{
    class Program
    {
        static void Main(string[] args)
        {
            StorageCredentials storageCredentials = new StorageCredentials("mystorageaccountbrian", "3ePbLWNl1u3t7b2uDccF8lRG9zaTZByZi7NLuOobDIjK0LMh9fscWp8zVRJXI6bDoNdaXEU/KO7o5X30jB4LoA==");
            CloudStorageAccount storageAccount = new CloudStorageAccount(storageCredentials, true);

            CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();

            CloudBlobContainer container = blobClient.GetContainerReference("inbox");

            container.CreateIfNotExists();

            CloudBlockBlob blob = container.GetBlockBlobReference("testFile");

            blob.UploadFromFile(@"C:\Users\admin\Desktop\TestFolder\testText.txt");

        }
    }
}

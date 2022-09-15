using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;

string connectionString = "your string"
string containerName = "name";

BlobContainerClient blobContainerClient =
    new BlobContainerClient(connectionString, containerName);

await foreach (BlobItem blobItem in blobContainerClient.GetBlobsAsync())
{
    Console.WriteLine("The blob name is : {0}", blobItem.Name);
    Console.WriteLine("The blob size is : {0}", blobItem.Properties.ContentLength);
}


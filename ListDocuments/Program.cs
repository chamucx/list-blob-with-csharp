using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;

string connectionString = "DefaultEndpointsProtocol=https;AccountName=demoappcore;AccountKey=F7L7yIs8GE5/oCNiuNFsr6hacl7Cb4a03bSsHbP0rAgX/4hTIs6Dh7ZZVXhxwuae+zrx4USd1N28+AStlTM/7A==;EndpointSuffix=core.windows.net";

string containerName = "makec";

BlobContainerClient blobContainerClient =
    new BlobContainerClient(connectionString, containerName);

await foreach (BlobItem blobItem in blobContainerClient.GetBlobsAsync())
{
    Console.WriteLine("The blob name is : {0}", blobItem.Name);
    Console.WriteLine("The blob size is : {0}", blobItem.Properties.ContentLength);
}


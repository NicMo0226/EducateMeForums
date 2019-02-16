using Microsoft.WindowsAzure.Storage.Blob;

namespace EducateMeForums.InterfaceForService
{
    public interface IUpload
    {
        CloudBlobContainer GetBlobContainer(string connectionString, string containerName);
    }
}
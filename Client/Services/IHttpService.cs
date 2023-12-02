using VMS_App.Shared.Models;

namespace VMS_App.Client.Service
{
    public interface IHttpService
    {
        Task<T> GetData<T>(string uri);
        Task<ResponseData> GetData(string uri);
        Task<ResponseData> PostData<T>(string uri, T requestBody);
    }
}

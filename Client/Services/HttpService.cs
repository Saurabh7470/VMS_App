using VMS_App.Shared.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace VMS_App.Client.Service
{
    public class HttpService : IHttpService
    {
        private HttpClient client;

        public HttpService(HttpClient _client)
        {
            client = _client;
        }

        public async Task<T> GetData<T>(string uri)
        {
            HttpResponseMessage httpResponse = await client.GetAsync(uri);
            ResponseData responseData = await httpResponse.Content.ReadFromJsonAsync<ResponseData>();

            T? data = Activator.CreateInstance<T>();
            if (responseData.Success)
            {
                data = JsonConvert.DeserializeObject<T>(responseData.Data.ToString());
            }
            else
            {
                Console.WriteLine($"StatusCode:{responseData.StatusCode} - Message{responseData.Message}");
            }
            return data;
        }

        public async Task<ResponseData> GetData(string uri)
        {
            try
            {
                HttpResponseMessage httpResponse = await client.GetAsync(uri);
                ResponseData responseData = await httpResponse.Content.ReadFromJsonAsync<ResponseData>();
                return responseData;
            }
            catch (Exception ex)
            {
                return new ResponseData() { Success = false, StatusCode = 000, Message = "Client:" + ex.Message };
            }
        }

        public async Task<ResponseData> PostData<T>(string uri, T requestBody)
        {
            try
            {
                HttpResponseMessage httpResponse = await client.PostAsJsonAsync<T>(uri, requestBody);

                ResponseData responseData = await httpResponse.Content.ReadFromJsonAsync<ResponseData>();

                if (httpResponse.IsSuccessStatusCode)
                    return responseData;
                else
                {
                    responseData.StatusCode = ((int)httpResponse.StatusCode);
                    responseData.Data = await httpResponse.Content.ReadAsStringAsync();
                    return responseData;
                }
            }
            catch (Exception ex)
            {
                return new ResponseData() { Success = false, StatusCode = 503, Message = "Client:" + ex.Message };
            }
        }
    }
}

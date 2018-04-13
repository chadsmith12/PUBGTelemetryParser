using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PUBGTelemetryParser.ApiService
{
    public abstract class BaseHttpService
    {
        protected async Task<ApiResponse<TData>> SendRequestAsync<TData>(Uri url, HttpMethod httpMethod = null, IDictionary<string, string> headers = null, object requestData = null)
        {
            ApiResponse<TData> result;

            var method = httpMethod ?? HttpMethod.Get;
            var data = requestData == null ? null : JsonConvert.SerializeObject(requestData);

            using (var request = new HttpRequestMessage(method, url))
            {
                if (data != null)
                {
                    request.Content = new StringContent(data, Encoding.UTF8, "application/json");
                }

                if (headers != null)
                {
                    foreach (var header in headers)
                    {
                        request.Headers.Add(header.Key, header.Value);
                    }
                }

                using (var client = new HttpClient())
                {
                    using (var response = await client.SendAsync(request, HttpCompletionOption.ResponseContentRead))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            result = new ApiResponse<TData>
                            {
                                Success = true,
                                Data = JsonConvert.DeserializeObject<TData>(await response.Content.ReadAsStringAsync())
                            };
                        }
                        else
                        {
                            result = new ApiResponse<TData>
                            {
                                ErrorCode = response.StatusCode,
                                ErrorMessage = response.ReasonPhrase,
                                Success = false
                            };
                        }
                    }
                }
            }

            return result;
        }
    }
}

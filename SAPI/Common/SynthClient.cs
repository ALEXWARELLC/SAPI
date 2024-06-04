using Newtonsoft.Json;
using SAPI.Models;
using System.Net.Http.Headers;

namespace SAPI.Common;

public class SynthClient
{
    private string _apikey = string.Empty;
    private string _host = string.Empty;
    public SynthClient(string Key, string Host)
    {
        _apikey = Key;
        _host = Host;
    }

    public async Task<SynthUser?> GetUser()
    {
        try
        {
            using (var _client = new HttpClient())
            {
                _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _apikey);
                _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await _client.GetAsync($"{_host}/api/client/account");

                if (response.IsSuccessStatusCode)
                {
                    var _user = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"User Details: {_user}");
                    return JsonConvert.DeserializeObject<SynthUser>(_user);
                }
            }
            return null;
        }
        catch (Exception ex)
        {
            throw new Exception($"There was an error while processing your request: {ex}");
        }
    }
}

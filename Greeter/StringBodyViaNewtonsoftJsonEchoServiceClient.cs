using Newtonsoft.Json;
using RestSharp;

namespace Greeter;

public class StringBodyViaNewtonsoftJsonEchoServiceClient : IEchoServiceClient
{
    private readonly RestClient _client = new("http://localhost:5009");

    public async Task<string> EchoGreeting()
    {
        var body = JsonConvert.SerializeObject(new GreetingDto("Hi"));
        var request = new RestRequest("echo").AddStringBody(body, DataFormat.Json);
        
        var response = await _client.PostAsync(request);
        return response.Content ?? "";
    }
}
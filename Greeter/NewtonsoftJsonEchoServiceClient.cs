using RestSharp;
using RestSharp.Serializers.NewtonsoftJson;

namespace Greeter;

public class NewtonsoftJsonEchoServiceClient
{
    private readonly RestClient _client = new("http://localhost:5009");

    public async Task<string> EchoGreeting()
    {
        _client.UseNewtonsoftJson();
        var request = new RestRequest("echo").AddJsonBody(new GreetingDto("Hi"));
        var response = await _client.PostAsync(request);
        return response.Content ?? "";
    }
}

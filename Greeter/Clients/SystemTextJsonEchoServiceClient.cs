using RestSharp;

namespace Greeter.Clients;

public class SystemTextJsonEchoServiceClient : IEchoServiceClient
{
    private readonly RestClient _client = new("http://localhost:5009");

    public async Task<string> EchoGreeting()
    {
        var request = new RestRequest("echo").AddJsonBody(new GreetingDto("Hi"));
        
        var response = await _client.PostAsync(request);
        return response.Content ?? "";
    }
}

namespace Greeter.Clients;

public interface IEchoServiceClient
{
    public Task<string> EchoGreeting();
}

namespace Greeter;

public interface IEchoServiceClient
{
    public Task<string> EchoGreeting();
}

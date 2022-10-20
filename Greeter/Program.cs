using Greeter;

await GreetWith(new SystemTextJsonEchoServiceClient(), "System.Text.Json");
await GreetWith(new NewtonsoftJsonEchoServiceClient(), "Newtonsoft.Json");
await GreetWith(new StringBodyViaNewtonsoftJsonEchoServiceClient(),
    "StringBody via Newtonsoft.Json using System.Text.Json");

async Task GreetWith(IEchoServiceClient client, string clientDescription)
{
    var echo = await client.EchoGreeting();
    Console.WriteLine($"{clientDescription} client: {echo}");
}

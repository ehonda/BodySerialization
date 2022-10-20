using Greeter;

var systemTextJsonClient = new SystemTextJsonEchoServiceClient();
var systemTextJsonEcho = await systemTextJsonClient.EchoGreeting();
Console.WriteLine($"System.Text.Json client: {systemTextJsonEcho}");

var newtonsoftJsonClient = new NewtonsoftJsonEchoServiceClient();
var newtonsoftJsonEcho = await newtonsoftJsonClient.EchoGreeting();
Console.WriteLine($"Newtonsoft.Json client: {newtonsoftJsonEcho}");

using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Greeter;

public record GreetingDto(
    [property: JsonPropertyName("Greeting")]
    [property: JsonProperty("Greeting")]
    string Greeting);

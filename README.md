# JSON body serialization experiments

## Current results:

```console
$ dotnet run -c Release
System.Text.Json client: {"Greeting":"Hi"}
Newtonsoft.Json client: {"greeting":"Hi"}
StringBody via Newtonsoft.Json using System.Text.Json client: {"Greeting":"Hi"}
```

## How to run

Navigate to the echo service directory and start it

```console
EchoService $ dotnet run -c Release
```

Then you can run the greeter and inspect echo service log output as well as what is returned on the different echo service client calls

```console
Greeter $ dotnet run -c Release
System.Text.Json client: {"Greeting":"Hi"}
Newtonsoft.Json client: {"greeting":"Hi"}
StringBody via Newtonsoft.Json using System.Text.Json client: {"Greeting":"Hi"}
```

producing echo service log output (excerpt)

```console
info: Microsoft.AspNetCore.HttpLogging.HttpLoggingMiddleware[1]
      Request:
      Protocol: HTTP/1.1
      Method: POST
      Scheme: http
      PathBase:
      Path: /echo
      Accept: application/json, text/json, text/x-json, text/javascript, application/xml, text/xml
      Host: localhost:5009
      User-Agent: RestSharp/108.0.2.0
      Accept-Encoding: gzip, deflate, br
      Content-Type: application/json; charset=utf-8
      Content-Length: 17
info: Microsoft.AspNetCore.HttpLogging.HttpLoggingMiddleware[3]
      RequestBody: {"Greeting":"Hi"}
info: Microsoft.AspNetCore.HttpLogging.HttpLoggingMiddleware[2]
      Response:
      StatusCode: 200
      Content-Type: text/plain; charset=utf-8
info: Microsoft.AspNetCore.HttpLogging.HttpLoggingMiddleware[4]
      ResponseBody: {"Greeting":"Hi"}
info: Microsoft.AspNetCore.HttpLogging.HttpLoggingMiddleware[1]
      Request:
      Protocol: HTTP/1.1
      Method: POST
      Scheme: http
      PathBase:
      Path: /echo
      Accept: application/json, text/json, text/x-json, text/javascript, application/xml, text/xml
      Host: localhost:5009
      User-Agent: RestSharp/108.0.2.0
      Accept-Encoding: gzip, deflate, br
      Content-Type: application/json; charset=utf-8
      Content-Length: 17
info: Microsoft.AspNetCore.HttpLogging.HttpLoggingMiddleware[3]
      RequestBody: {"greeting":"Hi"}
...
```
# Overview

Current results:

```console
$ dotnet run -c Release
System.Text.Json client: {"Greeting":"Hi"}
Newtonsoft.Json client: {"greeting":"Hi"}
StringBody via Newtonsoft.Json using System.Text.Json client: {"Greeting":"Hi"}
```
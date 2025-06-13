# ![Logo](./resources/n8n_32x32.png) n8n .NET SDK
Unofficial [RestEase](https://github.com/canton7/RestEase) C# Client for [n8n (Nodemation)](https://n8n.io).

## 📦 n8n.SDK
[![NuGet Badge](https://img.shields.io/nuget/v/n8n.SDK)](https://www.nuget.org/packages/n8n.SDK)<br>

## ⭐ Usage

### Register

``` c#
var configuration = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json")
    .AddJsonFile("appsettings.Development.json", optional: true)
    .Build();

services.AddNodemationSDK(configuration);

var serviceProvider = services.BuildServiceProvider();
```

### Example

``` c#
var api = serviceProvider.GetRequiredService<INodemationApi>();

var credentialType = await api.GetCredentialTypeAsync("openRouterApi");
```
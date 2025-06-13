## n8n SDK
Unofficial [RestEase](https://github.com/canton7/RestEase) C# Client for [n8n](https://n8n.io).

### ⭐ Usage

#### Register

``` c#
var configuration = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json")
    .AddJsonFile("appsettings.Development.json", optional: true)
    .Build();

services.AddNodemationSDK(configuration);

var serviceProvider = services.BuildServiceProvider();
```

#### Example

``` c#
var api = serviceProvider.GetRequiredService<INodemationApi>();

// TODO
```
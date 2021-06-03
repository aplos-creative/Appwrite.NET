### Appwrite for .NET
This project was based off the Appwrite generated sdk project. This project was designed to rely more on the HttpClient and a Typed HttpClient class for the Appwrite Client.


This project is no where near close to completed and is a work in progress. 

## How to use
Clone the repository and add a `Project Reference` to your .NET project for the Appwrite.NET project solution. 

If you are using WebApi then do the following in your `Startup.cs` Configure services block

```
var config = Configuration.GetAppwriteConfig();

services.AddAppwrite(config);

```


The `GetAppwriteConfig` can take a path string for the section in your configuration `appsettings.json` file where to get the Appwrite configuration.
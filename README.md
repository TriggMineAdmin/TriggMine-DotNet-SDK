# TriggMine-DotNet-SDK
## Description
TriggMine is an automated email marketing platform, tailored to the eCommerce needs. We've harnessed the power of behavioral-based email workflows! In real time, our system automatically tracks customers behavior and separates them into highly relevant, behavior-focused segments and sends them highly personalized emails.

It takes less than 30 minutes to launch fully automated email campaign! Now marketers can finally watch your email open rates, clicks and sales sky rocket, without hiring tech experts or touching a single line of code!

## NuGet
To install TriggMine.SDK from Visual Studio, run the following command in the [Package Manager Console](https://docs.microsoft.com/ru-ru/nuget/tools/package-manager-console).

`PM> Install-Package TriggMine.SDK`

## How-to
TriggMine API сan take 8 types of events. All events models send through SendEvent method which has static and async versions.

#### Event list with model type 
**Event type** | **Model** |
--|--|
Registration | ProspectEvent |
Cart | CartEvent |
History | HistoryEvents |
Login | LoginEvent |
Logout | LogoutEvent |
Navigation | NavigationEvent |
Order | OrderEvent |
Diagnostic | PluginDiagnosticEvent |


### Example instance
```C#
using TriggMine.SDK.Events;
using TriggMine.SDK.Models;

//Instance TriggMine API with your ApiKey and ApiUrl
//Your ApiKey && ApiUrl > https://client.triggmine.com.ua/login > Settings > Integration 
var triggmineApi = new TriggmineApi("YOUR API KEY", new Uri("YOUR API URL"));

//Registration event example
var response = triggmineApi.SendEvent(new ProspectEvent()
        {
            Id = Guid.NewGuid().ToString(),
            FirstName = "Denis",
            LastName = "Osiflyak",
            Email = "d.osiflyak@triggmine.com",
            DeviceId = "4c3d48512d48b2603092b5a45ba74c8c",
            SecondaryDeviceId = "465060737",
            RegistrationDate = DateTime.Now
        })
```
### Example static
```C#
using TriggMine.SDK.Events;
using TriggMine.SDK.Models;

//Registration model example
var prospect = new ProspectEvent()
        {
            Id = Guid.NewGuid().ToString(),
            FirstName = "Denis",
            LastName = "Osiflyak",
            Email = "d.osiflyak@triggmine.com",
            DeviceId = "4c3d48512d48b2603092b5a45ba74c8c",
            SecondaryDeviceId = "465060737",
            RegistrationDate = DateTime.Now
        };

//Your ApiKey && ApiUrl > https://client.triggmine.com.ua/login > Settings > Integration 
var response = TriggmineApi.SendEvent(prospect, "YOUR API KEY", new Uri("YOUR API URL"));
```

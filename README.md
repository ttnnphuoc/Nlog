# Logging in ASP .NET Core With NLog
Refer: https://mwaseemzakir.substack.com/p/episode-1-logging-in-asp-net-core

Logging is most important part of development , for figuring out the issues we need to add logging in our application especially if issue is occurring at production.

We have multiple options available for logging but two options are most popular , one of them is NLog and other one is Serilog.

NLog is a free logging platform for .NET with rich log routing and management capabilities. It makes it easy to produce and manage high-quality logs for your application regardless of its size or complexity.

Let’s see how can we install NLog and configure it for our ASP .NET Core Application

## Installing NLog

- Install these three packages from Nuget package to enable NLog in your application. Appended versions are latest as for now.
1.NLog (Latest 5.1.2)
2.NLog.Extensions.Logging (5.2.2)
3.NLog.Web.AspNetCore (5.2.2)

## Configure
- Configure NLog with appSettings.json

## Update Code
- Update Program.cs
- Set up NLog Dependency Injection



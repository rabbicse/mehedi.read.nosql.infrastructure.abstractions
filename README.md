# Mehedi.Read.Nosql.Infrastructure.Abstractions
Some useful base classes and interfaces, mainly used with the Read side NoSQL layer inside CleanArchitecture template.

## Technologies
- .NET Core 8
- C#
- xUnit

## Prerequisites
- net8.0
- Mehedi.Application.SharedKernel (>= 1.0.0)
- Mehedi.Core.SharedKernel (>= 1.0.0)

## Packaging
To pack nuget package write the following command
```
dotnet pack
```

To publish package of Mehedi.Read.NoSql.Infrastructure.Abstractions.1.0.0.nupkg write the following command
```
dotnet nuget push .\bin\Release\Mehedi.Read.NoSql.Infrastructure.Abstractions.1.0.0.nupkg --api-key <api-key> --source https://api.nuget.org/v3/index.json
```

## References
- [eShop](https://github.com/dotnet/eShop)
- [Ardalis.SharedKernel](https://github.com/ardalis/Ardalis.SharedKernel)
- [Clean Architecture Solution Template](https://github.com/jasontaylordev/CleanArchitecture)
- [ASP.NET Core C# CQRS Event Sourcing, REST API, DDD, SOLID Principles and Clean Architecture](https://github.com/jeangatto/ASP.NET-Core-Clean-Architecture-CQRS-Event-Sourcing)


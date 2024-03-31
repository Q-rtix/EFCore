# Entity Framework Core Converters

This library offers a range of custom converters that can be integrated into Entity Framework Core through the overriding of the ConfigureConventions method. These converters enable flexible and personalized data transformation between database data types and application data types.

## Table of Contents

- [Installation](#installation)
- [Converters](#converters)
- [Integrating the Converters](#integrating-the-converters)

## Installation

Using the NuGet package manager console within Visual Studio run the following command:

```
Install-Package Qrtix.EFCore.Converters
```

Or using the .NET Core CLI from a terminal window:

```
dotnet add package Qrtix.EFCore.Converters
```

## Converters

| Converters          | Description                                                                                                                                             |
|---------------------|---------------------------------------------------------------------------------------------------------------------------------------------------------|
| `TimeOnlyConverter` | Performs bidirectional conversion between the `TimeOnly` and `TimeSpan` types to enable Entity Framework Core compatibility with the `TimeOnly` struct. |
| `DateOnlyConverter` | Performs bidirectional conversion between the `DateOnly` and `DateTime` types to enable Entity Framework Core compatibility with the `DateOnly` struct. |

## Integrating the converters

```csharp
protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
{
	configurationBuilder.Properties<TimeOnly>().HaveConversion<TimeOnlyConverter>().HaveColumnType("time");
	configurationBuilder.Properties<DateOnly>().HaveConversion<DateOnlyConverter>().HaveColumnType("date");
	
	// add converters as you need
	
	base.ConfigureConventions(configurationBuilder);
}
```
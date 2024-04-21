# Introduction

Welcome to the documentation for **EFCore.Converters**, a library designed to facilitate the conversion between .NET's `DateOnly` and `TimeOnly` structs and their corresponding types in Entity Framework Core (EF Core), namely `DateTime` and `TimeSpan`.

## Purpose

EF Core natively supports a limited set of data types for use in database operations. While `DateTime` and `TimeSpan` are commonly used, .NET introduced new structs `DateOnly` and `TimeOnly` in version 6.0 to represent date and time values without the associated time zone and date components, respectively.

**EFCore.Converters** bridges this gap by providing converters that enable seamless integration of `DateOnly` and `TimeOnly` with EF Core, allowing developers to store and retrieve these types from the database effortlessly.

## Key Features

- Bidirectional conversion between `DateOnly` and `DateTime`.
- Bidirectional conversion between `TimeOnly` and `TimeSpan`.
- Simplifies storage and retrieval of `DateOnly` and `TimeOnly` in EF Core.

## Compatibility

- Compatible with Entity Framework Core.
- Supports .NET 6.0 and above.

## Installation

##### NuGet Package Manager

1. Open your project in Visual Studio.
2. Right-click on your project in Solution Explorer.
3. Select "Manage NuGet Packages..."
4. Search for "Qrtix.EFCore.Converters" in the NuGet Package Manager.
5. Click on "Install" to add the package to your project.

##### .NET CLI

You can also install **Qrtix.EFCore.Converters** using the .NET CLI:

```sh
dotnet add package Qrtix.EFCore.Converters
```


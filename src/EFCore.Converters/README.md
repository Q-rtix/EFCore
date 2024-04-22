# Entity Framework Core Converters

![NuGet Version](https://img.shields.io/nuget/v/Qrtix.EFCore.Converters?logo=nuget)
![NuGet Downloads](https://img.shields.io/nuget/dt/Qrtix.EFCore.Converters?style=flat&logo=nuget)
![GitHub Repo stars](https://img.shields.io/github/stars/Q-rtix/EFCore?style=flat&logo=github)

This library offers a range of custom converters that can be integrated into Entity Framework Core through the overriding of the ConfigureConventions method. These converters enable flexible and personalized data transformation between database data types and application data types.

Consult the online [documentation](https://q-rtix.github.io/EFCore/) for more details.

## Table of Contents

- [Installation](#installation)
- [Converters](#converters)
- [Integrating the Converters](#integrating-the-converters)
- [Contributing](#contributing)

## Installation

### NuGet Package Manager

1. Open your project in Visual Studio.
2. Right-click on your project in Solution Explorer.
3. Select "Manage NuGet Packages..."
4. Search for "Qrtix.EFCore.Converters" in the NuGet Package Manager.
5. Click on "Install" to add the package to your project.

### .NET CLI

You can also install **Qrtix.EFCore.Converters** using the .NET CLI:

```sh
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

## Contributing

**Did you find a bug?**

- Ensure the bug was not already reported by searching on GitHub
  under [Issues](https://github.com/Q-rtix/EFCore/issues).
- If you're unable to find an open issue addressing the
  problem, [open a new one](https://github.com/Q-rtix/EFCore/issues/new). Be sure to include a title and clear
  description, as much relevant information as possible, and a code sample or an executable test case demonstrating the
  expected behavior that is not occurring.

**Did you write a patch that fixes a bug?**

- Open a new GitHub pull request with the patch.
- Ensure the PR description clearly describes the problem and solution. Include the relevant issue number if applicable.

**Do you intend to add a new feature or change an existing one?**

- First suggest your change in the [EFCore ideas page](https://github.com/Q-rtix/EFCore/discussions/categories/ideas)
  for discussion.
- There are no fixed rules on what should and shouldn't be in this library, but some features are more valuable than
  others, and some require long-term maintenance that outweighs the value of the feature. So please get sign-off from
  the
  project leader (Carlos J. Ortiz) before putting in an excessive amount of work.

**Do you have questions about the source code?**

- Ask any question about how to use EFCore in
  the [EFCore discussion page](https://github.com/Q-rtix/EFCore/discussions/new?category=q-a).
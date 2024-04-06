# Getting Started

To get started with **EFCore.Converters**, follow these simple steps:

## 1. Install the Package

You can install the library via NuGet Package Manager Console:

```sh
Install-Package Qrtix.EFCore.Converters
```

Or use the .NET CLI:

```sh
dotnet add package Qrtix.EFCore.Converters
```

## 2. Configure Converters

After installing the package, configure the converters in your EF Core DbContext. For example:

```csharp
using Microsoft.EntityFrameworkCore;
using EFCore.Converters.DateTime;

public class YourDbContext : DbContext
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .Entity<YourEntity>()
            .Property(e => e.DateProperty)
            .HasConversion(new DateOnlyConverter());

        modelBuilder
            .Entity<YourEntity>()
            .Property(e => e.TimeProperty)
            .HasConversion(new TimeOnlyConverter());
    }
}
```

>[!IMPORTANT]
> Replace `YourEntity`, `DateProperty`, and `TimeProperty` with your actual entity and properties.

## 3. Start Using Converters

Once configured, you can use DateOnly and TimeOnly types in your entities, and EF Core will handle the conversion to 
DateTime and TimeSpan types automatically.

```csharp
public class YourEntity
{
    public int Id { get; set; }
    public DateOnly DateProperty { get; set; }
    public TimeOnly TimeProperty { get; set; }
}
```

That's it! You're now ready to use EFCore.Converters in your Entity Framework Core project.

For more advanced usage and customization options, refer to the [Advanced Usage](converters-advanced-usage.md) section.
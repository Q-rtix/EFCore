# Getting Started

To get started with **EFCore.RepositoryPattern**, follow these simple steps:

## Install the Package

You can install the library via NuGet Package Manager Console:

```sh
Install-Package Qrtix.EFCore.RepositoryPattern
```

Or use the NuGet Package Manager

1. Open your project in Visual Studio.
2. Right-click on your project in Solution Explorer.
3. Select "Manage NuGet Packages..."
4. Search for "Qrtix.EFCore.RepositoryPattern" in the NuGet Package Manager.
5. Click on "Install" to add the package to your project.

Or use the .NET CLI:

```sh
dotnet add package Qrtix.EFCore.Converters
```

## Usage

Once you have installed the EFCore.RepositoryPattern package, you can start using its repository pattern implementation
in your application.

### 1. Define your Entity classes:

Define your entity classes that represent the tables in your database. These classes will be used with the repositories
provided by EFCore.RepositoryPattern.

```csharp
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
}
```

### 2. Create DbContext:

Create a subclass of DbContext from Entity Framework Core and configure it to work with your database. This class will
be used to instantiate the repositories and unit of work.

```csharp
public class AppDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
}
```

### 3. Inject Dependencies:

Inject the required dependencies (repositories and unit of work) into your application's services or controllers using
your preferred dependency injection framework, such as Microsoft.Extensions.DependencyInjection.

That's it! You're now ready to use EFCore.RepositoryPattern in your Entity Framework Core project.
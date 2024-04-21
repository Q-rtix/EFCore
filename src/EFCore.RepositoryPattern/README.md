# Database Manager EFCore Repository Pattern

![NuGet Version](https://img.shields.io/nuget/v/Qrtix.EFCore.RepositoryPattern)

A library for implementing generic repositories and unit of work with Entity Framework Core.
This implementation uses a single instance of the DbContext for all repositories to avoid concurrency issues.

Consult the online [documentation](https://q-rtix.github.io/EFCore/) for more details.

## Table of Contents

- [Installation](#installation)
- [Creating the DbContext](#creating-the-dbcontext)
- [Injecting the Repository Pattern](#injecting-the-efcorerepositorypattern-services)
- [Creating the Service](#creating-the-service)
- [IUnitOfWork methods](#unitofwork)
- [IRepository methods](#repository-methods)

## Installation

Using the NuGet package manager console within Visual Studio run the following command:

```
Install-Package Ortix.EFCore.RepositoryPattern
```

Or using the .NET Core CLI from a terminal window:

```
dotnet add package Qrtix.EFCore.RepositoryPattern
```

## Creating the DbContext

Create your DbContext inheriting from `Microsoft.EntityFrameworkCore.DbContext`:

```csharp
public class MyDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }  

    protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
		base.OnModelCreating(modelBuilder);
	}
}
```

Configure your DbContext in the `Program` class:

```csharp
builder.Services.AddDbContext<DbContext, SuinQShopModuleDbContext>(opt =>
    {
        opt.UseSqlServer(builder.Configuration.GetConnectionString("ConnectionString"));
    });
```

## Injecting the RepositoryPattern's Services

Add the `RepositoryPattern` services to the Service Collection:

```csharp
builder.Services.AddRepositoryPattern();
```
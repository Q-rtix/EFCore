using System.Linq.Expressions;
using EFCore.RepositoryPattern.Repositories;
using EFCore.RepositoryPattern.Tests.Labs;
using FluentAssertions;
using Microsoft.EntityFrameworkCore;

namespace EFCore.RepositoryPattern.Tests.Repositories.RepositoryQueryExtensionsTest;

public class WithIncludePropertiesTests
{
	
// Can include properties in a query when includes is not null
	[Fact]
	public void CanIncludePropertiesWhenIncludesIsNotNull()
	{
		// Arrange
		var query = Lab.Products;
		var includes = new List<Expression<Func<Product, object>>>
		{
			e => e.Name,
			e => e.Price
		};

		// Act
		var result = query.WithIncludedProperties(includes);

		// Assert
		result.Should().NotBeNull();
		result.Should().Equal(query.Include(p => p.Name).Include(p => p.Price));
	}

// Can handle null query parameter
	[Fact]
	public void CanHandleNullQueryParameter()
	{
		// Arrange
		IQueryable<Product>? query = null;
		var includes = new List<Expression<Func<Product, object>>>
		{
			e => e.Name,
			e => e.Price
		};

		// Act
		var act = () => query.WithIncludedProperties(includes);

		// Assert
		act.Should().Throw<NullReferenceException>();
	}

// Can return the original query when includes is null
	[Fact]
	public void CanReturnOriginalQueryWhenIncludesIsNull()
	{
		// Arrange
		var query = new List<string>().AsQueryable();
		IEnumerable<Expression<Func<string, object>>> includes = null;

		// Act
		var result = query.WithIncludedProperties(includes);

		// Assert
		result.Should().BeSameAs(query);
	}


}
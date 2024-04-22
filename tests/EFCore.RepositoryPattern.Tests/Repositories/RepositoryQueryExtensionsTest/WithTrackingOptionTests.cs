using EFCore.RepositoryPattern.Repositories;
using FluentAssertions;
using Microsoft.EntityFrameworkCore;

namespace EFCore.RepositoryPattern.Tests.Repositories.RepositoryQueryExtensionsTest;

public class WithTrackingOptionTests
{
	[Fact]
	public void WithTrackingOption_DisableTracking_ReturnsAsNoTracking()
	{
		// Arrange
		var queryable = new List<string>().AsQueryable();

		// Act
		var result = queryable.WithTrackingOption(disableTracking: true);

		// Assert
		result.Should().BeSameAs(queryable.AsNoTracking());
	}

	[Fact]
	public void WithTrackingOption_EnableTracking_ReturnsOriginalQuery()
	{
		// Arrange
		var queryable = new List<string>().AsQueryable();

		// Act
		var result = queryable.WithTrackingOption();

		// Assert
		result.Should().BeSameAs(queryable);
	}
}
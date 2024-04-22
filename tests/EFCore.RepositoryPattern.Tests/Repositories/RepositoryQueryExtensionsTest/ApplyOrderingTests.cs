using EFCore.RepositoryPattern.Repositories;
using EFCore.RepositoryPattern.Tests.Labs;
using FluentAssertions;

namespace EFCore.RepositoryPattern.Tests.Repositories.RepositoryQueryExtensionsTest;

public class ApplyOrderingTests
{
	[Fact]
	public void ApplyOrderingToQueryWhenOrderByIsNotNull_ReturnOrderedQuery()
	{
		// Arrange
		var query = new List<int> { 3, 1, 2 }.AsQueryable();
		Func<IQueryable<int>, IOrderedQueryable<int>> orderBy = q => q.OrderBy(x => x);

		// Act
		var result =  query.ApplyOrdering(orderBy);

		// Assert
		result.Should().BeInAscendingOrder();
	}
	
	[Fact]
	public void WhenOrderByIsNull_returnsTheOriginalQuery()
	{
		// Arrange
		var query = Lab.Products;

		// Act
		var result = query.ApplyOrdering(null);

		// Assert
		result.Should().BeSameAs(query);
	}
	
	[Fact]
	public void WhenQueryIsNull_throwsAnException()
	{
		// Arrange
		IQueryable<object>? query = null;

		// Act
		Action act = () => query.ApplyOrdering(q => q.OrderBy(x => x));

		// Assert
		act.Should().Throw<ArgumentNullException>();
	}
}
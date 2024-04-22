using EFCore.RepositoryPattern.Repositories;
using Microsoft.EntityFrameworkCore;
using NSubstitute;

namespace EFCore.RepositoryPattern.Tests.Labs;

internal static class Lab
{
	public static IQueryable<Product> Products => new List<Product>
	{
		new() { Id = 1, Name = "Product 1", Price = 100 },
		new() { Id = 2, Name = "Product 2", Price = 20 },
		new() { Id = 3, Name = "Product 3", Price = 30 }
	}.AsQueryable();
}
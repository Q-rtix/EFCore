namespace EFCore.RepositoryPattern.Tests.Labs;

public class Product
{
	public int Id { get; set; }
	public required string Name { get; set; }
	public required decimal Price { get; set; }
}
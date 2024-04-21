using EFCore.RepositoryPattern.Repositories;
using EFCore.RepositoryPattern.UnitsOfWork;
using Microsoft.Extensions.DependencyInjection;

namespace EFCore.RepositoryPattern;

/// <summary>
/// Contain the methods to integrate this library.
/// </summary>
public static class DependencyInjection
{
	/// <summary>
	/// Integrate and configure the requisite dependencies and services for seamless operation of this library.
	/// </summary>
	/// <param name="services">An <see cref="IServiceCollection" /> to add the requisite dependencies and services.</param>
	/// <returns>An <see cref="IServiceCollection" /> with the requisite dependencies and services for seamless operation of this library.</returns>
	/// <exception cref="ArgumentNullException">If the <see cref="IServiceCollection" /> is null</exception>
	public static IServiceCollection AddRepositoryPattern(this IServiceCollection services)
	{
        ArgumentNullException.ThrowIfNull(services);

        services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
		services.AddScoped<IUnitOfWork, UnitOfWork>();

		return services;
	}
}
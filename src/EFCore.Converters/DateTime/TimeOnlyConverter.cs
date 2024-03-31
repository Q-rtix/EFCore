using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFCore.Converters.DateTime;

/// <summary>
///     Performs bidirectional conversion between the `TimeOnly` and `TimeSpan` types to enable Entity Framework Core
///     compatibility with the `TimeOnly` struct.
/// </summary>
public class TimeOnlyConverter : ValueConverter<TimeOnly, TimeSpan>
{
	/// <summary>
	///     Initializes a new instance of the <see cref="TimeOnlyConverter" /> class.
	/// </summary>
	public TimeOnlyConverter()
		: base(timeOnly => timeOnly.ToTimeSpan(),
			timeSpan => TimeOnly.FromTimeSpan(timeSpan))
	{
	}
}
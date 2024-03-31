using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFCore.Converters.DateTime;

/// <summary>
///     Performs bidirectional conversion between the `DateOnly` and `DateTime` types to enable Entity Framework Core
///     compatibility with the `DateOnly` struct.
/// </summary>
public class DateOnlyConverter : ValueConverter<DateOnly, System.DateTime>
{
	/// <summary>
	///     Initializes a new instance of the <see cref="DateOnlyConverter" /> class.
	/// </summary>
	public DateOnlyConverter()
		: base(dateOnly => dateOnly.ToDateTime(default),
			dateOnly => DateOnly.FromDateTime(dateOnly))
	{
	}
}
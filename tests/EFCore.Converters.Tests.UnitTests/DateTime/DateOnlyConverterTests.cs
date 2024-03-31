using EFCore.Converters.DateTime;

namespace EFCore.Converters.Tests.UnitTests.DateTime;

public class DateOnlyConverterTests
{
	[Fact]
	public void Convert_DateOnlyToDateTime_Success()
	{
		// Arrange
		var converter = new DateOnlyConverter();
		var dateOnly = new DateOnly(2024, 3, 31);

		// Act
		var dateTime = converter.ConvertToProvider(dateOnly);

		// Assert
		Assert.Equal(new System.DateTime(2024, 3, 31), dateTime);
	}

	[Fact]
	public void Convert_DateTimeToDateOnly_Success()
	{
		// Arrange
		var converter = new DateOnlyConverter();
		var dateTime = new System.DateTime(2024, 3, 31);

		// Act
		var dateOnly = converter.ConvertFromProvider(dateTime);

		// Assert
		Assert.Equal(new DateOnly(2024, 3, 31), dateOnly);
	}

	[Fact]
	public void Convert_NullDateOnlyToDateTime_ReturnsNull()
	{
		// Arrange
		var converter = new DateOnlyConverter();

		// Act
		var dateTime = converter.ConvertToProvider(null);

		// Assert
		Assert.Null(dateTime);
	}

	[Fact]
	public void Convert_NullDateTimeToDateOnly_ReturnsNull()
	{
		// Arrange
		var converter = new DateOnlyConverter();

		// Act
		var dateOnly = converter.ConvertFromProvider(null);

		// Assert
		Assert.Null(dateOnly);
	}

	[Fact]
	public void Convert_EdgeCaseDateTimeToDateOnly_Success()
	{
		// Arrange
		var converter = new DateOnlyConverter();
		var dateTime = new System.DateTime(1, 1, 1); // Earliest possible date

		// Act
		var dateOnly = converter.ConvertFromProvider(dateTime);

		// Assert
		Assert.Equal(new DateOnly(1, 1, 1), dateOnly);
	}
}
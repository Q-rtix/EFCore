using EFCore.Converters.DateTime;

namespace EFCore.Converters.Tests.UnitTests.DateTime;

public class TimeOnlyConverterTests
{
	[Fact]
	public void Convert_TimeOnlyToTimeSpan_Success()
	{
		// Arrange
		var converter = new TimeOnlyConverter();
		var timeOnly = new TimeOnly(13, 45, 30);

		// Act
		var timeSpan = converter.ConvertToProvider(timeOnly);

		// Assert
		Assert.Equal(new TimeSpan(13, 45, 30), timeSpan);
	}

	[Fact]
	public void Convert_TimeSpanToTimeOnly_Success()
	{
		// Arrange
		var converter = new TimeOnlyConverter();
		var timeSpan = new TimeSpan(13, 45, 30);

		// Act
		var timeOnly = converter.ConvertFromProvider(timeSpan);

		// Assert
		Assert.Equal(new TimeOnly(13, 45, 30), timeOnly);
	}

	[Fact]
	public void Convert_NullTimeOnlyToTimeSpan_ReturnsNull()
	{
		// Arrange
		var converter = new TimeOnlyConverter();

		// Act
		var timeSpan = converter.ConvertToProvider(null);

		// Assert
		Assert.Null(timeSpan);
	}

	[Fact]
	public void Convert_NullTimeSpanToTimeOnly_ReturnsNull()
	{
		// Arrange
		var converter = new TimeOnlyConverter();

		// Act
		var timeOnly = converter.ConvertFromProvider(null);

		// Assert
		Assert.Null(timeOnly);
	}

	[Fact]
	public void Convert_EdgeCaseTimeSpanToTimeOnly_Success()
	{
		// Arrange
		var converter = new TimeOnlyConverter();
		var timeSpan = new TimeSpan(23, 59, 59); // Latest possible time

		// Act
		var timeOnly = converter.ConvertFromProvider(timeSpan);

		// Assert
		Assert.Equal(new TimeOnly(23, 59, 59), timeOnly);
	}
}
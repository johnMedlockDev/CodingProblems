namespace CodingProblems.Console.Test;

[TestClass]
public class EasyTests
{
    private readonly Easy _sut = new();

    // https://edabit.com/challenge/uevxL5FNM77otyo9Z
    [TestMethod]
    public void ConvertNumberToCorrespondingMonthName_Given3_ExpectMarch()
    {
        var given = 3;
        var expected = "March";
        var actual = _sut.ConvertNumberToCorrespondingMonthName(given);

        _ = actual.Should().Be(expected);
    }

    [TestMethod]
    public void ConvertNumberToCorrespondingMonthName_Given12_ExpectDecember()
    {
        var given = 12;
        var expected = "December";
        var actual = _sut.ConvertNumberToCorrespondingMonthName(given);
        _ = actual.Should().Be(expected);
    }

    [TestMethod]
    public void ConvertNumberToCorrespondingMonthName_Given6_ExpectJune()
    {
        var given = 6;
        var expected = "June";
        var actual = _sut.ConvertNumberToCorrespondingMonthName(given);

        _ = actual.Should().Be(expected);
    }

    //  https://edabit.com/challenge/kMWmiNJM4szSv7dLd
    [TestMethod]
    public void FindTheSmallestAndBiggestNumbers_GivenMultipleValueArray_ExpectMinMax()
    {
        var given = new Int32[] { 1, 2, 3, 4, 5 };
        var expected = new Int32[] { 1, 5 };
        var actual = _sut.FindTheSmallestAndBiggestNumbers(given);

        _ = actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
    }

    [TestMethod]
    public void FindTheSmallestAndBiggestNumbers_GivenTwoValueArray_ExpectMinMax()
    {
        var given = new Int32[] { 2334454, 5 };
        var expected = new Int32[] { 5, 2334454 };
        var actual = _sut.FindTheSmallestAndBiggestNumbers(given);

        _ = actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
    }

    [TestMethod]
    public void FindTheSmallestAndBiggestNumbers_GivenOneValueArray_ExpectMinMax()
    {
        var given = new Int32[] { 1 };
        var expected = new Int32[] { 1, 1 };
        var actual = _sut.FindTheSmallestAndBiggestNumbers(given);

        _ = actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
    }
}
namespace CodingProblems.Console.Test;

[TestClass]
public class EasyTests
{
    private readonly Easy _sut = new();

    // https://edabit.com/challenge/uevxL5FNM77otyo9Z
    [TestMethod]
    public void ConvertNumberToCorrespondingMonthName_Given3ExpectMarch()
    {
        var given = 3;
        var expect = "March";
        var actual = _sut.ConvertNumberToCorrespondingMonthName(given);

        _ = actual.Should().Be(expect);
    }

    [TestMethod]
    public void ConvertNumberToCorrespondingMonthName_Given12ExpectDecember()
    {
        var given = 12;
        var expect = "December";
        var actual = _sut.ConvertNumberToCorrespondingMonthName(given);
        _ = actual.Should().Be(expect);
    }

    [TestMethod]
    public void ConvertNumberToCorrespondingMonthName_Given6ExpectJune()
    {
        var given = 6;
        var expect = "June";
        var actual = _sut.ConvertNumberToCorrespondingMonthName(given);

        _ = actual.Should().Be(expect);
    }
}
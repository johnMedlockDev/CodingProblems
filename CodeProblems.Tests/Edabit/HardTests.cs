using CodeProblems.Edabit;

namespace CodeProblems.Tests.Edabit;

[TestClass()]
public class HardTests
{

    private readonly Hard _sut = new();

    //https://edabit.com/challenge/YGhgctqPsKQxQQCFS
    [TestMethod()]
    public void ReverseAndNot_Test_1()
    {
        var given = 123;
        var expected = "321123";
        var actual = _sut.ReverseAndNot(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void ReverseAndNot_Test_2()
    {
        var given = 152;
        var expected = "251152";
        var actual = _sut.ReverseAndNot(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void ReverseAndNot_Test_3()
    {
        var given = 123456789;
        var expected = "987654321123456789";
        var actual = _sut.ReverseAndNot(given);
        _ = actual.Should().Be(expected);
    }
    //https://edabit.com/challenge/E4eAyJLjgGssf7GFJ
    //[TestMethod()]
    public void ReturnExponentsOfPrimeFactors_Test_1()
    {
        var givenA = new Int32[] { 2, 3, 5 };
        var givenB = 600;
        var expected = new Int32[] { 3, 1, 2 };
        var actual = _sut.ReturnExponentsOfPrimeFactors(givenA, givenB);
        _ = actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
    }
    //[TestMethod()]
    public void ReturnExponentsOfPrimeFactors_Test_2()
    {
        var givenA = new Int32[] { 2, 3, 5 };
        var givenB = 720;
        var expected = new Int32[] { 4, 2, 1 };
        var actual = _sut.ReturnExponentsOfPrimeFactors(givenA, givenB);
        _ = actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
    }
    //https://edabit.com/challenge/wunaXvZw3WctYioeC
    [TestMethod()]
    public void Uncensor_Test_1()
    {
        var givenA = "Wh*r* d*d my v*w*ls g*?";
        var givenB = "eeioeo";
        var expected = "Where did my vowels go?";
        var actual = _sut.Uncensor(givenA, givenB);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]

    public void Uncensor_Test_2()
    {
        var givenA = "abcd";
        var givenB = "";
        var expected = "abcd";
        var actual = _sut.Uncensor(givenA, givenB);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void Uncensor_Test_3()
    {
        var givenA = "*PP*RC*S*";
        var givenB = "UEAE";
        var expected = "UPPERCASE";
        var actual = _sut.Uncensor(givenA, givenB);
        _ = actual.Should().Be(expected);
    }
    //https://edabit.com/challenge/dZeNE4BJhyNgA99Fq
    [TestMethod()]
    public void ImaginaryCodingInterview_Test_1()
    {

        var givenA = new Int32[] { 5, 5, 10, 10, 15, 15, 20, 20 };
        var givenB = 120;
        var expected = "qualified";
        var actual = _sut.ImaginaryCodingInterview(givenA, givenB);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void ImaginaryCodingInterview_Test_2()
    {
        var givenA = new Int32[] { 2, 3, 8, 6, 5, 12, 10, 18 };
        var givenB = 64;
        var expected = "qualified";
        var actual = _sut.ImaginaryCodingInterview(givenA, givenB);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void ImaginaryCodingInterview_Test_3()
    {

        var givenA = new Int32[] { 5, 5, 10, 10, 25, 15, 20, 120 };
        var givenB = 120;
        var expected = "disqualified";
        var actual = _sut.ImaginaryCodingInterview(givenA, givenB);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void ImaginaryCodingInterview_Test_4()
    {
        var givenA = new Int32[] { 5, 5, 10, 10, 15, 15, 20, 20 };
        var givenB = 130;
        var expected = "disqualified";
        var actual = _sut.ImaginaryCodingInterview(givenA, givenB);
        _ = actual.Should().Be(expected);
    }
    //https://edabit.com/challenge/SkY5Nw3rS7WvkQmFc
    [TestMethod()]
    public void SmoothSentences_Test_1()
    {
        var given = "Marta appreciated deep perpendicular right trapezoids";
        var expected = true;
        var actual = _sut.SmoothSentences(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void SmoothSentences_Test_2()
    {
        var given = "Someone is outside the doorway";
        var expected = false;
        var actual = _sut.SmoothSentences(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void SmoothSentences_Test_3()
    {
        var given = "She eats super righteously";
        var expected = true;
        var actual = _sut.SmoothSentences(given);
        _ = actual.Should().Be(expected);
    }
    //https://edabit.com/challenge/8tyXtHqAT3LAuHMqu
    [TestMethod()]
    public void ValidHexCode_Test_1()
    {
        var given = "#CD5C5C";
        var expected = true;
        var actual = _sut.ValidHexCode(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void ValidHexCode_Test_2()
    {
        var given = "#EAECEE";
        var expected = true;
        var actual = _sut.ValidHexCode(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void ValidHexCode_Test_3()
    {
        var given = "#eaecee";
        var expected = true;
        var actual = _sut.ValidHexCode(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void ValidHexCode_Test_4()
    {
        var given = "#CD5C58C";
        var expected = false;
        var actual = _sut.ValidHexCode(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void ValidHexCode_Test_5()
    {
        var given = "#CD5C5Z";
        var expected = false;
        var actual = _sut.ValidHexCode(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void ValidHexCode_Test_6()
    {
        var given = "#CD5C&C";
        var expected = false;
        var actual = _sut.ValidHexCode(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void ValidHexCode_Test_7()
    {
        var given = "CD5C5C";
        var expected = false;
        var actual = _sut.ValidHexCode(given);
        _ = actual.Should().Be(expected);
    }
}
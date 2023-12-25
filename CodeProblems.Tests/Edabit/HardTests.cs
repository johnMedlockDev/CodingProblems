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
    //https://edabit.com/challenge/TAZywz6R2hu9tDQWc
    [TestMethod()]
    public void ConsecutiveNumbers_Test_1()
    {
        var given = new Int32[] { 5, 1, 4, 3, 2 };
        var expected = true;
        var actual = _sut.ConsecutiveNumbers(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void ConsecutiveNumbers_Test_2()
    {
        var given = new Int32[] { 5, 1, 4, 3, 2, 8 };
        var expected = false;
        var actual = _sut.ConsecutiveNumbers(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void ConsecutiveNumbers_Test_3()
    {
        var given = new Int32[] { 5, 6, 7, 8, 9, 9 };
        var expected = false;
        var actual = _sut.ConsecutiveNumbers(given);
        _ = actual.Should().Be(expected);
    }
    //https://edabit.com/challenge/g88PKZrCY6sWPBva7
    [TestMethod()]
    public void TrackTheRobot_Test_1()
    {
        var given = new String[] { "right 10", "up 50", "left 30", "down 10" };
        var expected = new Int32[] { -20, 40 };
        var actual = _sut.TrackTheRobot(given);
        _ = actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
    }
    [TestMethod()]
    public void TrackTheRobot_Test_2()
    {
        var given = Array.Empty<String>();
        var expected = new Int32[] { 0, 0 };
        var actual = _sut.TrackTheRobot(given);
        _ = actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
    }
    [TestMethod()]
    public void TrackTheRobot_Test_()
    {
        var given = new String[] { "right 100", "right 100", "up 500", "up 10000" };
        var expected = new Int32[] { 200, 10500 };
        var actual = _sut.TrackTheRobot(given);
        _ = actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
    }
    //https://edabit.com/challenge/X3btpQQEBeezX4jhK
    [TestMethod()]
    public void CupSwapping_Test_1()
    {
        var given = new String[] { "AB", "CA" };
        var expected = "C";
        var actual = _sut.CupSwapping(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void CupSwapping_Test_2()
    {
        var given = new String[] { "AC", "CA", "CA", "AC" };
        var expected = "B";
        var actual = _sut.CupSwapping(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void CupSwapping_Test_3()
    {
        var given = new String[] { "BA", "AC", "CA", "BC" };
        var expected = "A";
        var actual = _sut.CupSwapping(given);
        _ = actual.Should().Be(expected);
    }
    //https://edabit.com/challenge/FKb8JY75nkaHz7B3F
    [TestMethod()]
    public void NextPrime_Test_1()
    {
        var given = 12;
        var expected = 13;
        var actual = _sut.NextPrime(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void NextPrime_Test_2()
    {
        var given = 24;
        var expected = 29;
        var actual = _sut.NextPrime(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void NextPrime_Test_3()
    {
        var given = 11;
        var expected = 11;
        var actual = _sut.NextPrime(given);
        _ = actual.Should().Be(expected);
    }
    //https://edabit.com/challenge/wXCzoLtvvEEYBs3p9
    [TestMethod()]
    public void CountTheNumberOfDuplicateCharacters_Test_1()
    {
        var given = "abcde";
        var expected = 0;
        var actual = _sut.CountTheNumberOfDuplicateCharacters(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void CountTheNumberOfDuplicateCharacters_Test_2()
    {
        var given = "aabbcde";
        var expected = 2;
        var actual = _sut.CountTheNumberOfDuplicateCharacters(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void CountTheNumberOfDuplicateCharacters_Test_3()
    {
        var given = "Indivisibilities";
        var expected = 2;
        var actual = _sut.CountTheNumberOfDuplicateCharacters(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void CountTheNumberOfDuplicateCharacters_Test_4()
    {
        var given = "Aa";
        var expected = 0;
        var actual = _sut.CountTheNumberOfDuplicateCharacters(given);
        _ = actual.Should().Be(expected);
    }
    //https://edabit.com/challenge/t6R99zCQ7nesR7Rdk
    [TestMethod()]
    public void AlmostPalindrome_Test_1()
    {
        var given = "abcdcbg";
        var expected = true;
        var actual = _sut.AlmostPalindrome(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void AlmostPalindrome_Test_2()
    {
        var given = "abccia";
        var expected = true;
        var actual = _sut.AlmostPalindrome(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void AlmostPalindrome_Test_3()
    {
        var given = "abcdaaa";
        var expected = false;
        var actual = _sut.AlmostPalindrome(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void AlmostPalindrome_Test_4()
    {
        var given = "1234312";
        var expected = false;
        var actual = _sut.AlmostPalindrome(given);
        _ = actual.Should().Be(expected);
    }
    //https://edabit.com/challenge/y4esBva2cYph5QKg5
    [TestMethod()]
    public void AWeekLater_Test_1()
    {
        var given = "12/03/2020";
        var expected = "19/03/2020";
        var actual = _sut.AWeekLater(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void AWeekLater_Test_2()
    {
        var given = "21/12/1989";
        var expected = "28/12/1989";
        var actual = _sut.AWeekLater(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void AWeekLater_Test_3()
    {
        var given = "01/01/2000";
        var expected = "08/01/2000";
        var actual = _sut.AWeekLater(given);
        _ = actual.Should().Be(expected);
    }
    //https://edabit.com/challenge/p39Q6JFuran7t5LpS
    [TestMethod()]
    public void DoAllBigramsExist_Test_1()
    {
        var givenA = new String[] { "at", "be", "th", "au" };
        var givenB = new String[] { "beautiful", "the", "hat" };
        var expected = true;
        var actual = _sut.DoAllBigramsExist(givenA, givenB);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void DoAllBigramsExist_Test_2()
    {
        var givenA = new String[] { "ay", "be", "ta", "cu" };
        var givenB = new String[] { "maybe", "beta", "abet", "course" };
        var expected = false;
        var actual = _sut.DoAllBigramsExist(givenA, givenB);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void DoAllBigramsExist_Test_3()
    {

        var givenA = new String[] { "th", "fo", "ma", "or" };
        var givenB = new String[] { "the", "many", "for", "forest" };
        var expected = true;
        var actual = _sut.DoAllBigramsExist(givenA, givenB);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void DoAllBigramsExist_Test_4()
    {
        var givenA = new String[] { "oo", "mi", "ki", "la" };
        var givenB = new String[] { "milk", "chocolate", "cooks" };
        var expected = false;
        var actual = _sut.DoAllBigramsExist(givenA, givenB);
        _ = actual.Should().Be(expected);
    }
    //https://edabit.com/challenge/bqveyPRgcWZM7XzMQ
    [TestMethod()]
    public void ReverseCodingChallenge_Test_1()
    {
        var given = "A4B5C2";
        var expected = "AAAABBBBBCC";
        var actual = _sut.ReverseCodingChallenge(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void ReverseCodingChallenge_Test_2()
    {
        var given = "C2F1E5";
        var expected = "CCFEEEEE";
        var actual = _sut.ReverseCodingChallenge(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void ReverseCodingChallenge_Test_3()
    {
        var given = "T4S2V2";
        var expected = "TTTTSSVV";
        var actual = _sut.ReverseCodingChallenge(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void ReverseCodingChallenge_Test_4()
    {
        var given = "A1B2C3D4";
        var expected = "ABBCCCDDDD";
        var actual = _sut.ReverseCodingChallenge(given);
        _ = actual.Should().Be(expected);
    }
    //https://edabit.com/challenge/C6wN5vGodWvWL7ZaK
    [TestMethod()]
    public void SockPairs_Test_1()
    {
        var given = "AA";
        var expected = 1;
        var actual = _sut.SockPairs(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void SockPairs_Test_2()
    {
        var given = "ABABC";
        var expected = 2;
        var actual = _sut.SockPairs(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void SockPairs_Test_3()
    {
        var given = "CABBACCC";
        var expected = 4;
        var actual = _sut.SockPairs(given);
        _ = actual.Should().Be(expected);
    }
}
using CodeProblems.Edabit;

namespace CodeProblems.Tests.Edabit;

[TestClass()]
public class MediumTests
{
    private readonly Medium _sut = new();

    //https://edabit.com/challenge/2QvnWexKoLfcJkSsc
    [TestMethod()]
    public void ArrayOfMultiples_Test_1()
    {
        var givenA = 7;
        var givenB = 5;
        var expected = new Int32[] { 7, 14, 21, 28, 35 };
        var actual = _sut.ArrayOfMultiples(givenA, givenB);
        _ = actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
    }
    [TestMethod()]
    public void ArrayOfMultiples_Test_2()
    {
        var givenA = 12;
        var givenB = 10;
        var expected = new Int32[] { 12, 24, 36, 48, 60, 72, 84, 96, 108, 120 };
        var actual = _sut.ArrayOfMultiples(givenA, givenB);
        _ = actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
    }
    [TestMethod()]
    public void ArrayOfMultiples_Test_3()
    {
        var givenA = 17;
        var givenB = 6;
        var expected = new Int32[] { 17, 34, 51, 68, 85, 102 };
        var actual = _sut.ArrayOfMultiples(givenA, givenB);
        _ = actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
    }
    //https://edabit.com/challenge/99oN5igrbXddAjHEL
    [TestMethod()]
    public void ReverseTheCase_Test_1()
    {
        var given = "Happy Birthday";
        var expected = "hAPPY bIRTHDAY";
        var actual = _sut.ReverseTheCase(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void ReverseTheCase_Test_2()
    {
        var given = "MANY THANKS";
        var expected = "many thanks";
        var actual = _sut.ReverseTheCase(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void ReverseTheCase_Test_3()
    {
        var given = "sPoNtAnEoUs";
        var expected = "SpOnTaNeOuS";
        var actual = _sut.ReverseTheCase(given);
        _ = actual.Should().Be(expected);
    }
    //https://edabit.com/challenge/Q7g8sfg7DJq6CyMMu
    [TestMethod()]
    public void EqualityCheck_Test_1()
    {
        var givenA = 1;
        var givenB = true;
        var expected = false;
        var actual = _sut.EqualityCheck(givenA, givenB);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void EqualityCheck_Test_2()
    {
        var givenA = 0;
        var givenB = "0";
        var expected = false;
        var actual = _sut.EqualityCheck(givenA, givenB);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void EqualityCheck_Test_3()
    {
        var givenA = 1;
        var givenB = 1;
        var expected = true;
        var actual = _sut.EqualityCheck(givenA, givenB);
        _ = actual.Should().Be(expected);
    }
    //https://edabit.com/challenge/6qFnpAhd3kdmYcNG2
    [TestMethod()]
    public void ReturnTheIndexOfAllCapitalLetters_Test_1()
    {
        var given = "eDaBiT";
        var expected = new Int32[] { 1, 3, 5 };
        var actual = _sut.ReturnTheIndexOfAllCapitalLetters(given);
        _ = actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
    }
    [TestMethod()]
    public void ReturnTheIndexOfAllCapitalLetters_Test_2()
    {
        var given = "eQuINoX";
        var expected = new Int32[] { 1, 3, 4, 6 };
        var actual = _sut.ReturnTheIndexOfAllCapitalLetters(given);
        _ = actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
    }
    [TestMethod()]
    public void ReturnTheIndexOfAllCapitalLetters_Test_3()
    {
        var given = "determine";
        var expected = Array.Empty<Int32>();
        var actual = _sut.ReturnTheIndexOfAllCapitalLetters(given);
        _ = actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
    }
    [TestMethod()]
    public void ReturnTheIndexOfAllCapitalLetters_Test_4()
    {
        var given = "STRIKE";
        var expected = new Int32[] { 0, 1, 2, 3, 4, 5 };
        var actual = _sut.ReturnTheIndexOfAllCapitalLetters(given);
        _ = actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
    }
    [TestMethod()]
    public void ReturnTheIndexOfAllCapitalLetters_Test_5()
    {
        var given = "sUn";
        var expected = new Int32[] { 1 };
        var actual = _sut.ReturnTheIndexOfAllCapitalLetters(given);
        _ = actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
    }
    //https://edabit.com/challenge/JYEufqRvkusjr5R58
    [TestMethod()]
    public void FindTheBomb_Test_1()
    {
        var given = "There is a bomb.";
        var expected = "Duck!!!";
        var actual = _sut.FindTheBomb(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void FindTheBomb_Test_2()
    {
        var given = "Hey, did you think there is a bomb?";
        var expected = "Duck!!!";
        var actual = _sut.FindTheBomb(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void FindTheBomb_Test_3()
    {
        var given = "This goes boom!!!";
        var expected = "There is no bomb, relax.";
        var actual = _sut.FindTheBomb(given);
        _ = actual.Should().Be(expected);
    }
    //https://edabit.com/challenge/hqTYj7NbLnCcjxryi
    [TestMethod()]
    public void ConvertAllArrayItemsToString_Test_1()
    {
        var given = new Object[] { 1, 2, "a", "b" };
        var expected = new String[] { "1", "2", "a", "b" };
        var actual = _sut.ConvertAllArrayItemsToString(given);
        _ = actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
    }
    [TestMethod()]
    public void ConvertAllArrayItemsToString_Test_2()
    {
        var given = new Object[] { "abc", 123, "def", 456 };
        var expected = new String[] { "abc", "123", "def", "456" };
        var actual = _sut.ConvertAllArrayItemsToString(given);
        _ = actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
    }
    [TestMethod()]
    public void ConvertAllArrayItemsToString_Test_3()
    {
        var given = new Object[] { 1, 2, 3, 17, 24, 3, "a", "123b" };
        var expected = new String[] { "1", "2", "3", "17", "24", "3", "a", "123b" };
        var actual = _sut.ConvertAllArrayItemsToString(given);
        _ = actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
    }
    [TestMethod()]
    public void ConvertAllArrayItemsToString_Test_4()
    {
        var given = Array.Empty<Object>();
        var expected = Array.Empty<String>();
        var actual = _sut.ConvertAllArrayItemsToString(given);
        _ = actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
    }
    //https://edabit.com/challenge/nermqxzovZbfFBC9X
    [TestMethod()]
    public void FindTheLargestNumbersInAGroupOfArrays_Test_1()
    {
        var given = new Double[][] { [4, 2, 7, 1], [20, 70, 40, 90], [1, 2, 0] };
        var expected = new Double[] { 7, 90, 2 };
        var actual = _sut.FindTheLargestNumbersInAGroupOfArrays(given);
        _ = actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
    }
    [TestMethod()]
    public void FindTheLargestNumbersInAGroupOfArrays_Test_2()
    {
        var given = new Double[][] { [-34, -54, -74], [-32, -2, -65], [-54, 7, -43] };
        var expected = new Double[] { -34, -2, 7 };
        var actual = _sut.FindTheLargestNumbersInAGroupOfArrays(given);
        _ = actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
    }
    [TestMethod()]
    public void FindTheLargestNumbersInAGroupOfArrays_Test_3()
    {
        var given = new Double[][] { [0.4321, 0.7634, 0.652], [1.324, 9.32, 2.5423, 6.4314], [9, 3, 6, 3] };
        var expected = new Double[] { 0.7634, 9.32, 9 };
        var actual = _sut.FindTheLargestNumbersInAGroupOfArrays(given);
        _ = actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
    }
    //https://edabit.com/challenge/ZSvj2W3J6QRydkyh2
    [TestMethod()]
    public void CountTheLettersAndDigits_Test_1()
    {
        var given = "Hello World";
        var expected = "{ LETTERS =  10, DIGITS =  0 }";
        var actual = _sut.CountTheLettersAndDigits(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void CountTheLettersAndDigits_Test_2()
    {
        var given = "H3ll0 Wor1d";
        var expected = "{ LETTERS =  7, DIGITS =  3 }";
        var actual = _sut.CountTheLettersAndDigits(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void CountTheLettersAndDigits_Test_3()
    {
        var given = "149990";
        var expected = "{ LETTERS =  0, DIGITS =  6 }";
        var actual = _sut.CountTheLettersAndDigits(given);
        _ = actual.Should().Be(expected);
    }
    //https://edabit.com/challenge/zaokQWNdEudmFWpk7
    [TestMethod()]
    public void FindTheCharactersCounterpartCharCode_Test_1()
    {
        var given = "A";
        var expected = 65;
        var actual = _sut.FindTheCharactersCounterpartCharCode(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void FindTheCharactersCounterpartCharCode_Test_2()
    {
        var given = "a";
        var expected = 97;
        var actual = _sut.FindTheCharactersCounterpartCharCode(given);
        _ = actual.Should().Be(expected);
    }

    [TestMethod()]
    public void CountOnesInBinaryRepresentationOfInteger_Test_1()
    {
        var given = 0;
        var expected = 0;
        var actual = _sut.CountOnesInBinaryRepresentationOfInteger(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void CountOnesInBinaryRepresentationOfInteger_Test_2()
    {
        var given = 100;
        var expected = 3;
        var actual = _sut.CountOnesInBinaryRepresentationOfInteger(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void CountOnesInBinaryRepresentationOfInteger_Test_3()
    {
        var given = 999;
        var expected = 8;
        var actual = _sut.CountOnesInBinaryRepresentationOfInteger(given);
        _ = actual.Should().Be(expected);
    }
    //https://edabit.com/challenge/SXeEZPxDM9Y5HzLvw
    [TestMethod()]
    public void PositiveCountNegativeSum_Test_1()
    {
        var given = new Int32[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15 };
        var expected = new Int32[] { 10, -65 };
        var actual = _sut.PositiveCountNegativeSum(given);
        _ = actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
    }

    [TestMethod()]
    public void PositiveCountNegativeSum_Test_2()
    {
        var given = new Int32[] { 92, 6, 73, -77, 81, -90, 99, 8, -85, 34 };
        var expected = new Int32[] { 7, -252 };
        var actual = _sut.PositiveCountNegativeSum(given);
        _ = actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
    }
    [TestMethod()]
    public void PositiveCountNegativeSum_Test_3()
    {
        var given = new Int32[] { 91, -4, 80, -73, -28 };
        var expected = new Int32[] { 2, -105 };
        var actual = _sut.PositiveCountNegativeSum(given);
        _ = actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
    }
    [TestMethod()]
    public void PositiveCountNegativeSum_Test_4()
    {
        var given = Array.Empty<Int32>();
        var expected = Array.Empty<Int32>();
        var actual = _sut.PositiveCountNegativeSum(given);
        _ = actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
    }
    //https://edabit.com/challenge/gBYEFXeD9G2JMZ9dD
    [TestMethod()]
    public void ATMPINCodeValidation_Test_1()
    {
        var given = "1234";
        var expected = true;
        var actual = _sut.ATMPINCodeValidation(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void ATMPINCodeValidation_Test_2()
    {
        var given = "12345";
        var expected = false;
        var actual = _sut.ATMPINCodeValidation(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void ATMPINCodeValidation_Test_3()
    {
        var given = "a234";
        var expected = false;
        var actual = _sut.ATMPINCodeValidation(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void ATMPINCodeValidation_Test_4()
    {
        var given = "";
        var expected = false;
        var actual = _sut.ATMPINCodeValidation(given);
        _ = actual.Should().Be(expected);
    }
    //https://edabit.com/challenge/uCtG3Gtfx7fgNWM58
    [TestMethod()]
    public void FractionGreaterThanOne_Test_1()
    {
        var given = "1/2";
        var expected = false;
        var actual = _sut.FractionGreaterThanOne(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void FractionGreaterThanOne_Test_2()
    {
        var given = "7/4";
        var expected = true;
        var actual = _sut.FractionGreaterThanOne(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void FractionGreaterThanOne_Test_3()
    {
        var given = "10/10";
        var expected = false;
        var actual = _sut.FractionGreaterThanOne(given);
        _ = actual.Should().Be(expected);
    }
    //https://edabit.com/challenge/JF25KTZEcPzXhBvpM
    [TestMethod()]
    public void ReturnTheMiddleCharacterOfAString_Test_1()
    {
        var given = "test";
        var expected = "es";
        var actual = _sut.ReturnTheMiddleCharacterOfAString(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void ReturnTheMiddleCharacterOfAString_Test_2()
    {
        var given = "testing";
        var expected = "t";
        var actual = _sut.ReturnTheMiddleCharacterOfAString(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void ReturnTheMiddleCharacterOfAString_Test_3()
    {
        var given = "middle";
        var expected = "dd";
        var actual = _sut.ReturnTheMiddleCharacterOfAString(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void ReturnTheMiddleCharacterOfAString_Test_4()
    {
        var given = "A";
        var expected = "A";
        var actual = _sut.ReturnTheMiddleCharacterOfAString(given);
        _ = actual.Should().Be(expected);
    }
    //https://edabit.com/challenge/fcGARuJW6tcYyWMQw
    [TestMethod()]
    public void ScottishScreaming_Test_1()
    {
        var given = "hello world";
        var expected = "HELLE WERLD";
        var actual = _sut.ScottishScreaming(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void ScottishScreaming_Test_2()
    {
        var given = "Mr. Fox was very naughty";
        var expected = "MR. FEX WES VERY NEEGHTY";
        var actual = _sut.ScottishScreaming(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void ScottishScreaming_Test_3()
    {
        var given = "Butterflies are beautiful!";
        var expected = "BETTERFLEES ERE BEEETEFEL!";
        var actual = _sut.ScottishScreaming(given);
        _ = actual.Should().Be(expected);
    }
    //https://edabit.com/challenge/RFeBL2TzSf7mRMNJi
    [TestMethod()]
    public void MaskifyTheString_Test_1()
    {
        var given = "4556364607935616";
        var expected = "############5616";
        var actual = _sut.MaskifyTheString(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void MaskifyTheString_Test_2()
    {
        var given = "64607935616";
        var expected = "#######5616";
        var actual = _sut.MaskifyTheString(given);
        _ = actual.Should().Be(expected);
    }

    [TestMethod()]
    public void MaskifyTheString_Test_3()
    {
        var given = "1";
        var expected = "1";
        var actual = _sut.MaskifyTheString(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void MaskifyTheString_Test_4()
    {
        var given = "";
        var expected = "";
        var actual = _sut.MaskifyTheString(given);
        _ = actual.Should().Be(expected);
    }
    //https://edabit.com/challenge/b5HL5ju3Fpx5zjoXn
    [TestMethod()]
    public void GCDOfTwoNumbers_Test_1()
    {
        var givenA = 32;
        var givenB = 8;
        var expected = 8;
        var actual = _sut.GCDOfTwoNumbers(givenA, givenB);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void GCDOfTwoNumbers_Test_2()
    {
        var givenA = 8;
        var givenB = 12;
        var expected = 4;
        var actual = _sut.GCDOfTwoNumbers(givenA, givenB);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void GCDOfTwoNumbers_Test_3()
    {
        var givenA = 17;
        var givenB = 13;
        var expected = 1;
        var actual = _sut.GCDOfTwoNumbers(givenA, givenB);
        _ = actual.Should().Be(expected);
    }
    //https://edabit.com/challenge/4eSei6t8emzpyMwvu
    [TestMethod()]
    public void FilterOutStringsFromAnArray_Test_1()
    {
        var given = new Object[] { 1, 2, "a", "b" };
        var expected = new Int32[] { 1, 2 };
        var actual = _sut.FilterOutStringsFromAnArray(given);
        _ = actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
    }
    [TestMethod()]
    public void FilterOutStringsFromAnArray_Test_2()
    {
        var given = new Object[] { 1, "a", "b", 0, 15 };
        var expected = new Int32[] { 1, 0, 15 };
        var actual = _sut.FilterOutStringsFromAnArray(given);
        _ = actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
    }
    [TestMethod()]
    public void FilterOutStringsFromAnArray_Test_3()
    {
        var given = new Object[] { 1, 2, "aasf", "1", "123", 123 };
        var expected = new Int32[] { 1, 2, 123 };
        var actual = _sut.FilterOutStringsFromAnArray(given);
        _ = actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
    }
    //https://edabit.com/challenge/zcuASzWmpFHpPtrbH
    [TestMethod()]
    public void ReturnTheHighestAndLowestNumbers_Test_1()
    {
        var given = "1 2 3 4 5";
        var expected = "5 1";
        var actual = _sut.ReturnTheHighestAndLowestNumbers(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void ReturnTheHighestAndLowestNumbers_Test_2()
    {
        var given = "1 2 -3 4 5";
        var expected = "5 -3";
        var actual = _sut.ReturnTheHighestAndLowestNumbers(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void ReturnTheHighestAndLowestNumbers_Test_3()
    {
        var given = "1 9 3 4 -5";
        var expected = "9 -5";
        var actual = _sut.ReturnTheHighestAndLowestNumbers(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void ReturnTheHighestAndLowestNumbers_Test_4()
    {
        var given = "13";
        var expected = "13 13";
        var actual = _sut.ReturnTheHighestAndLowestNumbers(given);
        _ = actual.Should().Be(expected);
    }
    //https://edabit.com/challenge/qrJyh8ouvr2iseZy4
    [TestMethod()]
    public void CheckIfANumberIsAPalindrome_Test_1()
    {
        var given = 838;
        var expected = true;
        var actual = _sut.CheckIfANumberIsAPalindrome(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void CheckIfANumberIsAPalindrome_Test_2()
    {
        var given = 4433;
        var expected = false;
        var actual = _sut.CheckIfANumberIsAPalindrome(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void CheckIfANumberIsAPalindrome_Test_3()
    {
        var given = 443344;
        var expected = true;
        var actual = _sut.CheckIfANumberIsAPalindrome(given);
        _ = actual.Should().Be(expected);
    }
    //https://edabit.com/challenge/GvGSPC9wiY4bS9AMg
    [TestMethod()]
    public void FormatNumberwithCommaSeparatingThousands_Test_()
    {
        var given = 1000;
        var expected = "1,000";
        var actual = _sut.FormatNumberwithCommaSeparatingThousands(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void FormatNumberwithCommaSeparatingThousands_Test_2()
    {
        var given = 100000;
        var expected = "100,000";
        var actual = _sut.FormatNumberwithCommaSeparatingThousands(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void FormatNumberwithCommaSeparatingThousands_Test_3()
    {
        var given = 20;
        var expected = "20";
        var actual = _sut.FormatNumberwithCommaSeparatingThousands(given);
        _ = actual.Should().Be(expected);
    }
    //https://edabit.com/challenge/ynZfn2LifKN25fP84
    [TestMethod()]
    public void FindingNemo_Test_1()
    {
        var given = "I am finding Nemo !";
        var expected = "I found Nemo at 4!";
        var actual = _sut.FindingNemo(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void FindingNemo_Test_2()
    {
        var given = "Nemo is me";
        var expected = "I found Nemo at 1!";
        var actual = _sut.FindingNemo(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void FindingNemo_Test_3()
    {
        var given = "I Nemo am";
        var expected = "I found Nemo at 2!";
        var actual = _sut.FindingNemo(given);
        _ = actual.Should().Be(expected);
    }
    //https://edabit.com/challenge/N5G33s49LDXdhLdsT
    [TestMethod()]
    public void SortNumbersInDescendingOrder_Test_1()
    {
        var given = 123;
        var expected = 321;
        var actual = _sut.SortNumbersInDescendingOrder(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void SortNumbersInDescendingOrder_Test_2()
    {
        var given = 2619805;
        var expected = 9865210;
        var actual = _sut.SortNumbersInDescendingOrder(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void SortNumbersInDescendingOrder_Test_3()
    {
        var given = 73065;
        var expected = 76530;
        var actual = _sut.SortNumbersInDescendingOrder(given);
        _ = actual.Should().Be(expected);
    }
    //https://edabit.com/challenge/aQWAAz6SiApZBA8A8
    [TestMethod()]
    public void IsTheWordAnIsogram_Test_1()
    {
        var given = "Algorism";
        var expected = true;
        var actual = _sut.IsTheWordAnIsogram(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void IsTheWordAnIsogram_Test_2()
    {
        var given = "PasSword";
        var expected = false;
        var actual = _sut.IsTheWordAnIsogram(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void IsTheWordAnIsogram_Test_3()
    {
        var given = "Consecutive";
        var expected = false;
        var actual = _sut.IsTheWordAnIsogram(given);
        _ = actual.Should().Be(expected);
    }
    //https://edabit.com/challenge/8Sc582yHht2auBpCY
    [TestMethod()]
    public void StrangePair_Test_1()
    {
        var givenA = "ratio";
        var givenB = "orator";
        var expected = true;
        var actual = _sut.StrangePair(givenA, givenB);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void StrangePair_Test_2()
    {
        var givenA = "sparkling";
        var givenB = "groups";
        var expected = true;
        var actual = _sut.StrangePair(givenA, givenB);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void StrangePair_Test_3()
    {
        var givenA = "bush";
        var givenB = "hubris";
        var expected = false;
        var actual = _sut.StrangePair(givenA, givenB);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void StrangePair_Test_4()
    {
        var givenA = "";
        var givenB = "";
        var expected = true;
        var actual = _sut.StrangePair(givenA, givenB);
        _ = actual.Should().Be(expected);
    }
    //https://edabit.com/challenge/aoR4PFS6FfpJs6v79
    [TestMethod()]
    public void CheckIfANumberIsPrime_Test_1()
    {
        var given = 31;
        var expected = true;
        var actual = _sut.CheckIfANumberIsPrime(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void CheckIfANumberIsPrime_Test_2()
    {
        var given = 18;
        var expected = false;
        var actual = _sut.CheckIfANumberIsPrime(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void CheckIfANumberIsPrime_Test_3()
    {
        var given = 11;
        var expected = true;
        var actual = _sut.CheckIfANumberIsPrime(given);
        _ = actual.Should().Be(expected);
    }
    //https://edabit.com/challenge/biJhNvddqC5zmRuKz
    [TestMethod()]
    public void FridayThe13th_Test_1()
    {
        var givenA = 3;
        var givenB = 2020;
        var expected = true;
        var actual = _sut.FridayThe13th(givenA, givenB);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void FridayThe13th_Test_2()
    {
        var givenA = 10;
        var givenB = 2017;
        var expected = true;
        var actual = _sut.FridayThe13th(givenA, givenB);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void FridayThe13th_Test_3()
    {
        var givenA = 1;
        var givenB = 1985;
        var expected = false;
        var actual = _sut.FridayThe13th(givenA, givenB);
        _ = actual.Should().Be(expected);
    }
    //https://edabit.com/challenge/7F8ZhHpxeW7K65XRL
    [TestMethod()]
    public void ReturnTheSumOfTheTwoSmallestNumbers_Test_1()
    {
        var given = new Int64[] { 19, 5, 42, 2, 77 };
        var expected = 7;
        var actual = _sut.ReturnTheSumOfTheTwoSmallestNumbers(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void ReturnTheSumOfTheTwoSmallestNumbers_Test_2()
    {
        var given = new Int64[] { 10, 343445353, 3453445, 3453545353453 };
        var expected = 3453455;
        var actual = _sut.ReturnTheSumOfTheTwoSmallestNumbers(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void ReturnTheSumOfTheTwoSmallestNumbers_Test_3()
    {
        var given = new Int64[] { 2, 9, 6, -1 };
        var expected = 8;
        var actual = _sut.ReturnTheSumOfTheTwoSmallestNumbers(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void ReturnTheSumOfTheTwoSmallestNumbers_Test_4()
    {
        var given = new Int64[] { 879, 953, 694, -847, 342, 221, -91, -723, 791, -587 };
        var expected = 563;
        var actual = _sut.ReturnTheSumOfTheTwoSmallestNumbers(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void ReturnTheSumOfTheTwoSmallestNumbers_Test_()
    {
        var given = new Int64[] { 3683, 2902, 3951, -475, 1617, -2385 };
        var expected = 4519;
        var actual = _sut.ReturnTheSumOfTheTwoSmallestNumbers(given);
        _ = actual.Should().Be(expected);
    }
    //https://edabit.com/challenge/n5Q8vWopD3Kmc8ADi
    [TestMethod()]
    public void IsThePhoneNumberFormattedCorrectly_Test_1()
    {
        var given = "(123) 456-7890";
        var expected = true;
        var actual = _sut.IsThePhoneNumberFormattedCorrectly(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void IsThePhoneNumberFormattedCorrectly_Test_2()
    {
        var given = "1111)555 2345";
        var expected = false;
        var actual = _sut.IsThePhoneNumberFormattedCorrectly(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void IsThePhoneNumberFormattedCorrectly_Test_3()
    {
        var given = "098) 123 4567";
        var expected = false;
        var actual = _sut.IsThePhoneNumberFormattedCorrectly(given);
        _ = actual.Should().Be(expected);
    }
    //https://edabit.com/challenge/uz6HACQLjH9DE6HcP
    [TestMethod()]
    public void PiToNDecimalPlaces_Test_1()
    {
        var given = 5;
        var expected = 3.14159;
        var actual = _sut.PiToNDecimalPlaces(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void PiToNDecimalPlaces_Test_2()
    {
        var given = 4;
        var expected = 3.1416;
        var actual = _sut.PiToNDecimalPlaces(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void PiToNDecimalPlaces_Test_3()
    {
        var given = 15;
        var expected = 3.141592653589793;
        var actual = _sut.PiToNDecimalPlaces(given);
        _ = actual.Should().Be(expected);
    }
    //https://edabit.com/challenge/SfZx7qzXheYQxtQbF
    [TestMethod()]
    public void RemoveAllSpecialCharactersFromAString_Test_1()
    {
        var given = "The quick brown fox!";
        var expected = "The quick brown fox";
        var actual = _sut.RemoveAllSpecialCharactersFromAString(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void RemoveAllSpecialCharactersFromAString_Test_2()
    {
        var given = "%fd76$fd(-)6GvKlO.";
        var expected = "fd76fd-6GvKlO";
        var actual = _sut.RemoveAllSpecialCharactersFromAString(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void RemoveAllSpecialCharactersFromAString_Test_3()
    {
        var given = "D0n$c sed 0di0 du1";
        var expected = "D0nc sed 0di0 du1";
        var actual = _sut.RemoveAllSpecialCharactersFromAString(given);
        _ = actual.Should().Be(expected);
    }
    //https://edabit.com/challenge/5B4jvew2NvzKhfcQv
    [TestMethod()]
    public void PerfectNumber_Test_1()
    {
        var given = 6;
        var expected = true;
        var actual = _sut.PerfectNumber(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void PerfectNumber_Test_2()
    {
        var given = 28;
        var expected = true;
        var actual = _sut.PerfectNumber(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void PerfectNumber_Test_3()
    {
        var given = 496;
        var expected = true;
        var actual = _sut.PerfectNumber(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void PerfectNumber_Test_4()
    {
        var given = 12;
        var expected = false;
        var actual = _sut.PerfectNumber(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void PerfectNumber_Test_5()
    {
        var given = 97;
        var expected = false;
        var actual = _sut.PerfectNumber(given);
        _ = actual.Should().Be(expected);
    }
    //https://edabit.com/challenge/H77JNgLtEnQcX5hcu
    [TestMethod()]
    public void IsTheNumberSymmetrical_Test_1()
    {
        var given = 7227;
        var expected = true;
        var actual = _sut.IsTheNumberSymmetrical(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void IsTheNumberSymmetrical_Test_2()
    {
        var given = 12567;
        var expected = false;
        var actual = _sut.IsTheNumberSymmetrical(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void IsTheNumberSymmetrical_Test_3()
    {
        var given = 44444444;
        var expected = true;
        var actual = _sut.IsTheNumberSymmetrical(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void IsTheNumberSymmetrical_Test_4()
    {
        var given = 9939;
        var expected = false;
        var actual = _sut.IsTheNumberSymmetrical(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void IsTheNumberSymmetrical_Test_5()
    {
        var given = 1112111;
        var expected = true;
        var actual = _sut.IsTheNumberSymmetrical(given);
        _ = actual.Should().Be(expected);
    }
    //https://edabit.com/challenge/NRAbyiQP9ZNa4bDRT
    [TestMethod()]
    public void ReverseCodingChallenge_Test_1()
    {
        var given = 152;
        var expected = 10;
        var actual = _sut.ReverseCodingChallenge(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void ReverseCodingChallenge_Test_2()
    {
        var given = 832;
        var expected = 48;
        var actual = _sut.ReverseCodingChallenge(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void ReverseCodingChallenge_Test_3()
    {
        var given = 19;
        var expected = 9;
        var actual = _sut.ReverseCodingChallenge(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void ReverseCodingChallenge_Test_4()
    {
        var given = 133;
        var expected = 9;
        var actual = _sut.ReverseCodingChallenge(given);
        _ = actual.Should().Be(expected);
    }
    //https://edabit.com/challenge/AyCKKtuhYjNo9eYwJ
    [TestMethod()]
    public void LargestGap_Test_()
    {
        var given = new Int32[] { 9, 4, 26, 26, 0, 0, 5, 20, 6, 25, 5 };
        var expected = 11;
        var actual = _sut.LargestGap(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void LargestGap_Test_2()
    {
        var given = new Int32[] { 14, 13, 7, 1, 4, 12, 3, 7, 7, 12, 11, 5, 7 };
        var expected = 4;
        var actual = _sut.LargestGap(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void LargestGap_Test_3()
    {
        var given = new Int32[] { 13, 3, 8, 5, 5, 2, 13, 6, 14, 2, 11, 4, 10, 8, 1, 9 };
        var expected = 2;
        var actual = _sut.LargestGap(given);
        _ = actual.Should().Be(expected);
    }
    //https://edabit.com/challenge/TLWqG49uMLa7zgxPE
    [TestMethod()]
    public void TheKaracasEncryptionAlgorithm_Test_1()
    {
        var given = "banana";
        var expected = "0n0n0baca";
        var actual = _sut.TheKaracasEncryptionAlgorithm(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void TheKaracasEncryptionAlgorithm_Test_2()
    {
        var given = "karaca";
        var expected = "0c0r0kaca";
        var actual = _sut.TheKaracasEncryptionAlgorithm(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void TheKaracasEncryptionAlgorithm_Test_3()
    {
        var given = "burak";
        var expected = "k0r3baca";
        var actual = _sut.TheKaracasEncryptionAlgorithm(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void TheKaracasEncryptionAlgorithm_Test_4()
    {
        var given = "alpaca";
        var expected = "0c0pl0aca";
        var actual = _sut.TheKaracasEncryptionAlgorithm(given);
        _ = actual.Should().Be(expected);
    }
    //https://edabit.com/challenge/ToMXLjWDLQqFua7Wh
    [TestMethod()]
    public void NoYelling_Test_1()
    {
        var given = "What went wrong?????????";
        var expected = "What went wrong?";
        var actual = _sut.NoYelling(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void NoYelling_Test_2()
    {
        var given = "Oh my goodness!!!";
        var expected = "Oh my goodness!";
        var actual = _sut.NoYelling(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void NoYelling_Test_3()
    {
        var given = "I just!!! can!!! not!!! believe!!! it!!!";
        var expected = "I just!!! can!!! not!!! believe!!! it!";
        var actual = _sut.NoYelling(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void NoYelling_Test_4()
    {
        var given = "Oh my goodness!";
        var expected = "Oh my goodness!";
        var actual = _sut.NoYelling(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void NoYelling_Test_5()
    {
        var given = "I just cannot believe it.";
        var expected = "I just cannot believe it.";
        var actual = _sut.NoYelling(given);
        _ = actual.Should().Be(expected);
    }
    //https://edabit.com/challenge/egy6LWExtnR6JkwBg
    [TestMethod()]
    public void BasicValidateEmail_Test_1()
    {
        var given = "@gmail.com";
        var expected = false;
        var actual = _sut.BasicValidateEmail(given);
        _ = actual.Should().Be(expected);
    }

    [TestMethod()]
    public void BasicValidateEmail_Test_2()
    {
        var given = "hello.gmail@com";
        var expected = false;
        var actual = _sut.BasicValidateEmail(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void BasicValidateEmail_Test_3()
    {
        var given = "gmail";
        var expected = false;
        var actual = _sut.BasicValidateEmail(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void BasicValidateEmail_Test_4()
    {
        var given = "hello@gmail";
        var expected = false;
        var actual = _sut.BasicValidateEmail(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void BasicValidateEmail_Test_5()
    {
        var given = "hello@edabit.com";
        var expected = true;
        var actual = _sut.BasicValidateEmail(given);
        _ = actual.Should().Be(expected);
    }
    //https://edabit.com/challenge/u6HAot7ojYFTSm9aZ
    [TestMethod()]
    public void FindTheAmountOfPotatoes_Test_1()
    {
        var given = "potato";
        var expected = 1;
        var actual = _sut.FindTheAmountOfPotatoes(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void FindTheAmountOfPotatoes_Test_2()
    {
        var given = "potatopotato";
        var expected = 2;
        var actual = _sut.FindTheAmountOfPotatoes(given);
        _ = actual.Should().Be(expected);
    }
    [TestMethod()]
    public void FindTheAmountOfPotatoes_Test_3()
    {
        var given = "potatoapple";
        var expected = 1;
        var actual = _sut.FindTheAmountOfPotatoes(given);
        _ = actual.Should().Be(expected);
    }
}

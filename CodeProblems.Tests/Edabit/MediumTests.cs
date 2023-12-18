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
}
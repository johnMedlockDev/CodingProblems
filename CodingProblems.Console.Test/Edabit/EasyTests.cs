using CodingProblems.Console.Edabit;

namespace CodingProblems.Console.Tests.Edabit;

[TestClass]
public class EasyTests
{
	private readonly Easy _sut = new();

	// https://edabit.com/challenge/uevxL5FNM77otyo9Z
	[TestMethod]
	public void ConvertNumberToCorrespondingMonthName_Test_1()
	{
		var given = 3;
		var expected = "March";
		var actual = _sut.ConvertNumberToCorrespondingMonthName(given);
		_ = actual.Should().Be(expected);
	}

	[TestMethod]
	public void ConvertNumberToCorrespondingMonthName_Test_2()
	{
		var given = 12;
		var expected = "December";
		var actual = _sut.ConvertNumberToCorrespondingMonthName(given);
		_ = actual.Should().Be(expected);
	}

	[TestMethod]
	public void ConvertNumberToCorrespondingMonthName_Test_3()
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

	// https://edabit.com/challenge/J3WGSreYhc65cWyrc
	[TestMethod()]
	public void AbsoluteSum_GivenMixedSignArrayOfInt_ExpectPositiveOutput()
	{
		var given = new Int32[] { 2, -1, 4, 8, 10 };
		var expected = 25;
		var actual = _sut.AbsoluteSum(given);
		_ = actual.Should().Be(expected);
	}

	[TestMethod()]
	public void AbsoluteSum_GivenAllNegativeArrayOfInt_ExpectPositiveOutput()
	{
		var given = new Int32[] { -3, -4, -10, -2, -3 };
		var expected = 22;
		var actual = _sut.AbsoluteSum(given);
		_ = actual.Should().Be(expected);
	}

	[TestMethod()]
	public void AbsoluteSum_GivenAllPositiveArrayOfInt_ExpectPositiveOutput()
	{
		var given = new Int32[] { 2, 4, 6, 8, 10 };
		var expected = 30;
		var actual = _sut.AbsoluteSum(given);
		_ = actual.Should().Be(expected);
	}
	[TestMethod()]
	public void AbsoluteSum_GivenSingleNegativeValueArrayOfInt_ExpectPositiveOutput()
	{
		var given = new Int32[] { -1 };
		var expected = 1;
		var actual = _sut.AbsoluteSum(given);
		_ = actual.Should().Be(expected);
	}

	// https://edabit.com/challenge/esARjHfWfdRP6ePEC
	[TestMethod()]
	public void ToThePowerOf_Test_1()
	{
		var givenA = 5;
		var givenB = 5;
		var expected = 3125;
		var actual = _sut.ToThePowerOf(givenA, givenB);
		_ = actual.Should().Be(expected);
	}

	[TestMethod()]
	public void ToThePowerOf_Test_2()
	{
		var givenA = 10;
		var givenB = 10;
		var expected = 10_000_000_000;
		var actual = _sut.ToThePowerOf(givenA, givenB);
		_ = actual.Should().Be(expected);
	}

	[TestMethod()]
	public void ToThePowerOf_Test_3()
	{
		var givenA = 3;
		var givenB = 3;
		var expected = 27;
		var actual = _sut.ToThePowerOf(givenA, givenB);
		_ = actual.Should().Be(expected);
	}

	// https://edabit.com/challenge/WLH46r3aARtXXYKF6

	[TestMethod()]
	public void MultiplyByLength_Test_1()
	{
		var given = new Int32[] { 2, 3, 1, 0 };
		var expected = new Int32[] { 8, 12, 4, 0 };
		var actual = _sut.MultiplyByLength(given);
		_ = actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
	}

	[TestMethod()]
	public void MultiplyByLength_Test_2()
	{
		var given = new Int32[] { 4, 1, 1 };
		var expected = new Int32[] { 12, 3, 3 };
		var actual = _sut.MultiplyByLength(given);
		_ = actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
	}
	[TestMethod()]
	public void MultiplyByLength_Test_3()
	{
		var given = new Int32[] { 1, 0, 3, 3, 7, 2, 1 };
		var expected = new Int32[] { 7, 0, 21, 21, 49, 14, 7 };
		var actual = _sut.MultiplyByLength(given);
		_ = actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
	}

	[TestMethod()]
	public void MultiplyByLength_Test_4()
	{
		var given = new Int32[] { 0 };
		var expected = new Int32[] { 0 };
		var actual = _sut.MultiplyByLength(given);
		_ = actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
	}
	//https://edabit.com/challenge/K49LXsoMmS6tXxP7R
	[TestMethod()]
	public void HammingDistance_Test_1()
	{
		var givenA = "abcde";
		var givenB = "bcdef";
		var expected = 5;
		var actual = _sut.HammingDistance(givenA, givenB);

		_ = actual.Should().Be(expected);
	}
	[TestMethod()]
	public void HammingDistance_Test_2()
	{
		var givenA = "strong";
		var givenB = "strung";
		var expected = 1;
		var actual = _sut.HammingDistance(givenA, givenB);

		_ = actual.Should().Be(expected);
	}
	[TestMethod()]
	public void HammingDistance_Test_3()
	{
		var givenA = "abcde";
		var givenB = "abcde";
		var expected = 0;
		var actual = _sut.HammingDistance(givenA, givenB);

		_ = actual.Should().Be(expected);
	}

	// https://edabit.com/challenge/c4W4BNymgCC5WkfHp
	[TestMethod()]
	public void NameShuffle_Test_1()
	{
		var given = "Donald Trump";
		var expected = "Trump Donald";
		var actual = _sut.NameShuffle(given);

		_ = actual.Should().Be(expected);
	}

	[TestMethod()]
	public void NameShuffle_Test_2()
	{
		var given = "Rosie O'Donnell";
		var expected = "O'Donnell Rosie";
		var actual = _sut.NameShuffle(given);

		_ = actual.Should().Be(expected);
	}

	[TestMethod()]
	public void NameShuffle_Test_3()
	{
		var given = "Seymour Butts";
		var expected = "Butts Seymour";
		var actual = _sut.NameShuffle(given);

		_ = actual.Should().Be(expected);
	}
	//https://edabit.com/challenge/uBqpafqjoYNPuQ7Pr
	[TestMethod()]
	public void SmallerStringNumber_Test_1()
	{

		var givenA = "21";
		var givenB = "44";
		var expected = "21";
		var actual = _sut.SmallerStringNumber(givenA, givenB);

		_ = actual.Should().Be(expected);
	}
	[TestMethod()]
	public void SmallerStringNumber_Test_2()
	{
		var givenA = "1500";
		var givenB = "1";
		var expected = "1";
		var actual = _sut.SmallerStringNumber(givenA, givenB);

		_ = actual.Should().Be(expected);
	}

	[TestMethod()]
	public void SmallerStringNumber_Test_3()
	{
		var givenA = "5";
		var givenB = "5";
		var expected = "5";
		var actual = _sut.SmallerStringNumber(givenA, givenB);

		_ = actual.Should().Be(expected);
	}
	//https://edabit.com/challenge/PmhP5mXMRrBoH3WoB
	[TestMethod()]
	public void ReturnTheFactorial_Test_1()
	{
		var given = 3;
		var expected = 6;
		var actual = _sut.ReturnTheFactorial(given);
		_ = actual.Should().Be(expected);
	}

	[TestMethod()]
	public void ReturnTheFactorial_Test_2()
	{
		var given = 5;
		var expected = 120;
		var actual = _sut.ReturnTheFactorial(given);
		_ = actual.Should().Be(expected);
	}

	[TestMethod()]
	public void ReturnTheFactorial_Test_3()
	{
		var given = 12;
		var expected = 479001600;
		var actual = _sut.ReturnTheFactorial(given);
		_ = actual.Should().Be(expected);
	}
	//https://edabit.com/challenge/5ytLyHsZHfyDhBgXr
	[TestMethod()]
	public void HowManyVowels_Test_1()
	{
		var given = "Celebration";
		var expected = 5;
		var actual = _sut.HowManyVowels(given);
		_ = actual.Should().Be(expected);
	}

	[TestMethod()]
	public void HowManyVowels_Test_2()
	{
		var given = "Palm";
		var expected = 1;
		var actual = _sut.HowManyVowels(given);
		_ = actual.Should().Be(expected);
	}

	[TestMethod()]
	public void HowManyVowels_Test_3()
	{
		var given = "Prediction";
		var expected = 4;
		var actual = _sut.HowManyVowels(given);
		_ = actual.Should().Be(expected);
	}
	//https://edabit.com/challenge/RocWAnyqu5J4fiZxS
	[TestMethod()]
	public void SortNumbersInAscendingOrder_GiveArrayWithAllPositiveNumbers_ExpectSortedArray()
	{
		var given = new Int32[] { 1, 2, 10, 50, 5 };
		var expected = new Int32[] { 1, 2, 5, 10, 50 };
		var actual = _sut.SortNumbersInAscendingOrder(given);
		_ = actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
	}

	[TestMethod()]
	public void SortNumbersInAscendingOrder_GiveArrayWithMixedSignNumbers_ExpectSortedArray()
	{
		var given = new Int32[] { 80, 29, 4, -95, -24, 85 };
		var expected = new Int32[] { -95, -24, 4, 29, 80, 85 };
		var actual = _sut.SortNumbersInAscendingOrder(given);
		_ = actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
	}

	[TestMethod()]
	public void SortNumbersInAscendingOrder_GiveNull_ExpectEmptyArray()
	{
		Int32[]? given = null;
		var expected = Array.Empty<Int32>();
		var actual = _sut.SortNumbersInAscendingOrder(given);
		_ = actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
	}

	[TestMethod()]
	public void SortNumbersInAscendingOrder_GiveEmptyArray_ExpectEmptyArray()
	{

		var given = Array.Empty<Int32>();
		var expected = Array.Empty<Int32>();
		var actual = _sut.MultiplyByLength(given);
		_ = actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
	}
	//https://edabit.com/challenge/zhbYFanESDL3RfSyt
	[TestMethod()]
	public void CheckIfAStringContainsOnlyIdenticalCharacters_Test_1()
	{
		var given = "aaaaaa";
		var expected = true;
		var actual = _sut.CheckIfAStringContainsOnlyIdenticalCharacters(given);
		_ = actual.Should().Be(expected);
	}

	[TestMethod()]
	public void CheckIfAStringContainsOnlyIdenticalCharacters_Test_2()
	{
		var given = "aabaaa";
		var expected = false;
		var actual = _sut.CheckIfAStringContainsOnlyIdenticalCharacters(given);
		_ = actual.Should().Be(expected);
	}

	[TestMethod()]
	public void CheckIfAStringContainsOnlyIdenticalCharacters_Test_3()
	{
		var given = "ccccca";
		var expected = false;
		var actual = _sut.CheckIfAStringContainsOnlyIdenticalCharacters(given);
		_ = actual.Should().Be(expected);
	}

	[TestMethod()]
	public void CheckIfAStringContainsOnlyIdenticalCharacters_Test_4()
	{
		var given = "kk";
		var expected = true;
		var actual = _sut.CheckIfAStringContainsOnlyIdenticalCharacters(given);
		_ = actual.Should().Be(expected);
	}
	//https://edabit.com/challenge/7nzfry4P3WrrL7t38
	[TestMethod()]
	public void H4ck3rSp34k_Test_1()
	{
		var given = "javascript is cool";
		var expected = "j4v45cr1pt 15 c00l";
		var actual = _sut.H4ck3rSp34k(given);
		_ = actual.Should().Be(expected);
	}
	[TestMethod()]
	public void H4ck3rSp34k_Test_2()
	{
		var given = "programming is fun";
		var expected = "pr0gr4mm1ng 15 fun";
		var actual = _sut.H4ck3rSp34k(given);
		_ = actual.Should().Be(expected);
	}
	[TestMethod()]
	public void H4ck3rSp34k_Test_3()
	{
		var given = "become a coder";
		var expected = "b3c0m3 4 c0d3r";
		var actual = _sut.H4ck3rSp34k(given);
		_ = actual.Should().Be(expected);
	}
	//https://edabit.com/challenge/ivaEWKZbFMcR8emJ8
	[TestMethod()]
	public void CheckIfTheSameCase_Test_1()
	{
		var given = "hello";
		var expected = true;
		var actual = _sut.CheckIfTheSameCase(given);
		_ = actual.Should().Be(expected);
	}

	[TestMethod()]
	public void CheckIfTheSameCase_Test_2()
	{
		var given = "HELLO";
		var expected = true;
		var actual = _sut.CheckIfTheSameCase(given);
		_ = actual.Should().Be(expected);
	}

	[TestMethod()]
	public void CheckIfTheSameCase_Test_3()
	{
		var given = "Hello";
		var expected = false;
		var actual = _sut.CheckIfTheSameCase(given);
		_ = actual.Should().Be(expected);
	}

	[TestMethod()]
	public void CheckIfTheSameCase_Test_4()
	{
		var given = "ketcHUp";
		var expected = false;
		var actual = _sut.CheckIfTheSameCase(given);
		_ = actual.Should().Be(expected);
	}
	//https://edabit.com/challenge/rsW2hHobz6WG4cqbB
	[TestMethod()]
	public void RaucousApplause_Test_1()
	{
		var given = "ClaClaClaClap!";
		var expected = 4;
		var actual = _sut.RaucousApplause(given);
		_ = actual.Should().Be(expected);
	}

	[TestMethod()]
	public void RaucousApplause_Test_2()
	{
		var given = "ClClClaClaClaClap!";
		var expected = 6;
		var actual = _sut.RaucousApplause(given);
		_ = actual.Should().Be(expected);
	}

	[TestMethod()]
	public void RaucousApplause_Test_3()
	{
		var given = "CCClaClClap!Clap!ClClClap!";
		var expected = 9;
		var actual = _sut.RaucousApplause(given);
		_ = actual.Should().Be(expected);
	}
}
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
	//https://edabit.com/challenge/YciBg83ihMfGGsA7F
	[TestMethod()]
	public void ShapesWithNSides_Test_1()
	{
		var given = 3;
		var expected = "triangle";
		var actual = _sut.ShapesWithNSides(given);
		_ = actual.Should().Be(expected);
	}

	[TestMethod()]
	public void ShapesWithNSides_Test_2()
	{
		var given = 1;
		var expected = "circle";
		var actual = _sut.ShapesWithNSides(given);
		_ = actual.Should().Be(expected);
	}

	[TestMethod()]
	public void ShapesWithNSides_Test_3()
	{
		var given = 9;
		var expected = "nonagon";
		var actual = _sut.ShapesWithNSides(given);
		_ = actual.Should().Be(expected);
	}
	//https://edabit.com/challenge/xFaPak5hmiR3vpH6M
	[TestMethod()]
	public void Burrrrrrrp_Test_1()
	{
		var given = 3;
		var expected = "Burrrp";
		var actual = _sut.Burrrrrrrp(given);
		_ = actual.Should().Be(expected);
	}
	[TestMethod()]
	public void Burrrrrrrp_Test_2()
	{
		var given = 5;
		var expected = "Burrrrrp";
		var actual = _sut.Burrrrrrrp(given);
		_ = actual.Should().Be(expected);
	}
	[TestMethod()]
	public void Burrrrrrrp_Test_3()
	{
		var given = 9;
		var expected = "Burrrrrrrrrp";
		var actual = _sut.Burrrrrrrp(given);
		_ = actual.Should().Be(expected);
	}
	//https://edabit.com/challenge/YxoGXwpApf9De7y5w
	[TestMethod()]
	public void HowManyDsAreThere_Test_1()
	{
		var given = "My friend Dylan got distracted in school.";
		var expected = 4;
		var actual = _sut.HowManyDsAreThere(given);
		_ = actual.Should().Be(expected);
	}
	[TestMethod()]
	public void HowManyDsAreThere_Test_2()
	{
		var given = "Debris was scattered all over the yard.";
		var expected = 3;
		var actual = _sut.HowManyDsAreThere(given);
		_ = actual.Should().Be(expected);
	}

	[TestMethod()]
	public void HowManyDsAreThere_Test_3()
	{
		var given = "The rodents hibernated in their den.";
		var expected = 3;
		var actual = _sut.HowManyDsAreThere(given);
		_ = actual.Should().Be(expected);
	}
	//https://edabit.com/challenge/hjFH2T4Gay7m9ka2m
	[TestMethod()]
	public void RemoveTheFirstAndLastCharacters_Test_1()
	{
		var given = "hello";
		var expected = "ell";
		var actual = _sut.RemoveTheFirstAndLastCharacters(given);
		_ = actual.Should().Be(expected);
	}
	[TestMethod()]
	public void RemoveTheFirstAndLastCharacters_Test_2()
	{
		var given = "maybe";
		var expected = "ayb";
		var actual = _sut.RemoveTheFirstAndLastCharacters(given);
		_ = actual.Should().Be(expected);
	}
	[TestMethod()]
	public void RemoveTheFirstAndLastCharacters_Test_3()
	{
		var given = "benefit";
		var expected = "enefi";
		var actual = _sut.RemoveTheFirstAndLastCharacters(given);
		_ = actual.Should().Be(expected);
	}
	[TestMethod()]
	public void RemoveTheFirstAndLastCharacters_Test_4()
	{
		var given = "a";
		var expected = "a";
		var actual = _sut.RemoveTheFirstAndLastCharacters(given);
		_ = actual.Should().Be(expected);
	}
	//https://edabit.com/challenge/qwPdNdEtpNpMiSTRN
	[TestMethod()]
	public void BackToHome_Test_1()
	{
		var given = "NEWE";
		var expected = false;
		var actual = _sut.BackToHome(given);
		_ = actual.Should().Be(expected);
	}
	[TestMethod()]
	public void BackToHome_Test_2()
	{
		var given = "NENESSWW";
		var expected = true;
		var actual = _sut.BackToHome(given);
		_ = actual.Should().Be(expected);
	}

	[TestMethod()]
	public void BackToHome_Test_3()
	{
		var given = "NEESSW";
		var expected = false;
		var actual = _sut.BackToHome(given);
		_ = actual.Should().Be(expected);
	}
	//https://edabit.com/challenge/Ty9u8onXNjDPdQGMo
	[TestMethod()]
	public void StutteringFunction_Test_()
	{
		var given = "incredible";
		var expected = "in... in... incredible?";
		var actual = _sut.StutteringFunction(given);
		_ = actual.Should().Be(expected);
	}
	[TestMethod()]
	public void StutteringFunction_Test_2()
	{
		var given = "enthusiastic";
		var expected = "en... en... enthusiastic?";
		var actual = _sut.StutteringFunction(given);
		_ = actual.Should().Be(expected);
	}

	[TestMethod()]
	public void StutteringFunction_Test_3()
	{
		var given = "outstanding";
		var expected = "ou... ou... outstanding?";
		var actual = _sut.StutteringFunction(given);
		_ = actual.Should().Be(expected);
	}
	//https://edabit.com/challenge/mcdSLSmXjYMzEmug2
	[TestMethod()]
	public void DateFormat_Test_1()
	{
		var given = "11/12/2019";
		var expected = "20191211";
		var actual = _sut.DateFormat(given);
		_ = actual.Should().Be(expected);
	}
	[TestMethod()]
	public void DateFormat_Test_2()
	{
		var given = "12/31/2019";
		var expected = "20193112";
		var actual = _sut.DateFormat(given);
		_ = actual.Should().Be(expected);
	}
	[TestMethod()]
	public void DateFormat_Test_3()
	{
		var given = "01/15/2019";
		var expected = "20191501";
		var actual = _sut.DateFormat(given);
		_ = actual.Should().Be(expected);
	}
	//https://edabit.com/challenge/FrEEkHfph2pjfE4Ry
	[TestMethod()]
	public void FizzBuzzInterviewQuestion_Test_1()
	{
		var given = 3;
		var expected = "Fizz";
		var actual = _sut.FizzBuzzInterviewQuestion(given);
		_ = actual.Should().Be(expected);
	}

	[TestMethod()]
	public void FizzBuzzInterviewQuestion_Test_2()
	{
		var given = 5;
		var expected = "Buzz";
		var actual = _sut.FizzBuzzInterviewQuestion(given);
		_ = actual.Should().Be(expected);
	}

	[TestMethod()]
	public void FizzBuzzInterviewQuestion_Test_3()
	{
		var given = 15;
		var expected = "FizzBuzz";
		var actual = _sut.FizzBuzzInterviewQuestion(given);
		_ = actual.Should().Be(expected);
	}

	[TestMethod()]
	public void FizzBuzzInterviewQuestion_Test_4()
	{
		var given = 4;
		var expected = "4";
		var actual = _sut.FizzBuzzInterviewQuestion(given);
		_ = actual.Should().Be(expected);
	}
	//https://edabit.com/challenge/6qJzQujmkei3XEYvY
	[TestMethod()]
	public void SumOfResistanceInParallelCircuits_Test_1()
	{
		var given = new Int32[] { 6, 3 };
		var expected = 2;
		var actual = _sut.SumOfResistanceInParallelCircuits(given);
		_ = actual.Should().Be(expected);
	}
	[TestMethod()]
	public void SumOfResistanceInParallelCircuits_Test_2()
	{
		var given = new Int32[] { 10, 20, 10 };
		var expected = 4;
		var actual = _sut.SumOfResistanceInParallelCircuits(given);
		_ = actual.Should().Be(expected);
	}
	[TestMethod()]
	public void SumOfResistanceInParallelCircuits_Test_3()
	{
		var given = new Int32[] { 500, 500, 500 };
		var expected = 166.7;
		var actual = _sut.SumOfResistanceInParallelCircuits(given);
		_ = actual.Should().Be(expected);
	}
	//https://edabit.com/challenge/csfWZxcMSERJykqv5
	[TestMethod()]
	public void RecursionSum_Test_1()
	{
		var given = 5;
		var expected = 15;
		var actual = _sut.RecursionSum(given);
		_ = actual.Should().Be(expected);
	}

	[TestMethod()]
	public void RecursionSum_Test_2()
	{
		var given = 1;
		var expected = 1;
		var actual = _sut.RecursionSum(given);
		_ = actual.Should().Be(expected);
	}

	[TestMethod()]
	public void RecursionSum_Test_3()
	{
		var given = 12;
		var expected = 78;
		var actual = _sut.RecursionSum(given);
		_ = actual.Should().Be(expected);
	}
	//https://edabit.com/challenge/N28EPgcw96zm4Zv5J
	[TestMethod()]
	public void NextNumberGreaterThanAAndBAndDivisibleByB_Test_1()
	{
		var givenA = 17;
		var givenB = 8;
		var expected = 24;
		var actual = _sut.NextNumberGreaterThanAAndBAndDivisibleByB(givenA, givenB);
		_ = actual.Should().Be(expected);
	}
	[TestMethod()]
	public void NextNumberGreaterThanAAndBAndDivisibleByB_Test_2()
	{
		var givenA = 98;
		var givenB = 3;
		var expected = 99;
		var actual = _sut.NextNumberGreaterThanAAndBAndDivisibleByB(givenA, givenB);
		_ = actual.Should().Be(expected);
	}
	[TestMethod()]
	public void NextNumberGreaterThanAAndBAndDivisibleByB_Test_3()
	{
		var givenA = 14;
		var givenB = 11;
		var expected = 22;
		var actual = _sut.NextNumberGreaterThanAAndBAndDivisibleByB(givenA, givenB);
		_ = actual.Should().Be(expected);
	}
	//https://edabit.com/challenge/MrTxAwggfKFcQXBda
	[TestMethod()]
	public void RecursionToRepeatAStringNNumberOfTimes_Test_1()
	{
		var givenA = "ab";
		var givenB = 3;
		var expected = "ababab";
		var actual = _sut.RecursionToRepeatAStringNNumberOfTimes(givenA, givenB);
		_ = actual.Should().Be(expected);
	}
	[TestMethod()]
	public void RecursionToRepeatAStringNNumberOfTimes_Test_2()
	{
		var givenA = "kiwi";
		var givenB = 1;
		var expected = "kiwi";
		var actual = _sut.RecursionToRepeatAStringNNumberOfTimes(givenA, givenB);
		_ = actual.Should().Be(expected);
	}
	[TestMethod()]
	public void RecursionToRepeatAStringNNumberOfTimes_Test_3()
	{
		var givenA = "cherry";
		var givenB = 2;
		var expected = "cherrycherry";
		var actual = _sut.RecursionToRepeatAStringNNumberOfTimes(givenA, givenB);
		_ = actual.Should().Be(expected);
	}
	//https://edabit.com/challenge/xzWM9imvHoSd36iv7
	[TestMethod()]
	public void GetTheFileName_Test_1()
	{
		var given = "C:/Projects/pil_tests/ascii/edabit.txt";
		var expected = "edabit.txt";
		var actual = _sut.GetTheFileName(given);
		_ = actual.Should().Be(expected);
	}
	[TestMethod()]
	public void GetTheFileName_Test_2()
	{
		var given = "C:/Users/johnsmith/Music/Beethoven_5.mp3";
		var expected = "Beethoven_5.mp3";
		var actual = _sut.GetTheFileName(given);
		_ = actual.Should().Be(expected);
	}
	[TestMethod()]
	public void GetTheFileName_Test_3()
	{
		var given = "ffprobe.exe";
		var expected = "ffprobe.exe";
		var actual = _sut.GetTheFileName(given);
		_ = actual.Should().Be(expected);
	}
	//https://edabit.com/challenge/fKZHLzmR8anBrxgNt
	[TestMethod()]
	public void RepeatingLetters_Test_1()
	{
		var given = "String";
		var expected = "SSttrriinngg";
		var actual = _sut.RepeatingLetters(given);
		_ = actual.Should().Be(expected);
	}
	[TestMethod()]
	public void RepeatingLetters_Test_2()
	{
		var given = "Hello World!";
		var expected = "HHeelllloo  WWoorrlldd!!";
		var actual = _sut.RepeatingLetters(given);
		_ = actual.Should().Be(expected);
	}
	[TestMethod()]
	public void RepeatingLetters_Test_3()
	{
		var given = "1234!_ ";
		var expected = "11223344!!__  ";
		var actual = _sut.RepeatingLetters(given);
		_ = actual.Should().Be(expected);
	}
	//https://edabit.com/challenge/ugg9ZK7xY5vk5qJXr
	[TestMethod()]
	public void DoubleLetters_Test_1()
	{
		var given = "loop";
		var expected = true;
		var actual = _sut.DoubleLetters(given);
		_ = actual.Should().Be(expected);
	}
	[TestMethod()]
	public void DoubleLetters_Test_2()
	{
		var given = "yummy";
		var expected = true;
		var actual = _sut.DoubleLetters(given);
		_ = actual.Should().Be(expected);
	}
	[TestMethod()]
	public void DoubleLetters_Test_3()
	{
		var given = "orange";
		var expected = false;
		var actual = _sut.DoubleLetters(given);
		_ = actual.Should().Be(expected);
	}
	[TestMethod()]
	public void DoubleLetters_Test_4()
	{
		var given = "munchkin";
		var expected = false;
		var actual = _sut.DoubleLetters(given);
		_ = actual.Should().Be(expected);
	}
	//https://edabit.com/challenge/ypLHBBJtdME9pvTuN
	[TestMethod()]
	public void ReFormTheWord_Test_1()
	{
		var givenA = "seas";
		var givenB = "onal";
		var expected = "Seasonal";
		var actual = _sut.ReFormTheWord(givenA, givenB);
		_ = actual.Should().Be(expected);
	}
	[TestMethod()]
	public void ReFormTheWord_Test_2()
	{
		var givenA = "comp";
		var givenB = "lete";
		var expected = "Complete";
		var actual = _sut.ReFormTheWord(givenA, givenB);
		_ = actual.Should().Be(expected);
	}
	[TestMethod()]
	public void ReFormTheWord_Test_3()
	{
		var givenA = "lang";
		var givenB = "uage";
		var expected = "Language";
		var actual = _sut.ReFormTheWord(givenA, givenB);
		_ = actual.Should().Be(expected);
	}
	//https://edabit.com/challenge/ZCAugLuYPbzcC4Eos
	[TestMethod()]
	public void ModifyingTheLastCharacter_Test_1()
	{
		var givenA = "Hello";
		var givenB = 3;
		var expected = "Hellooo";
		var actual = _sut.ModifyingTheLastCharacter(givenA, givenB);
		_ = actual.Should().Be(expected);
	}
	[TestMethod()]
	public void ModifyingTheLastCharacter_Test_2()
	{
		var givenA = "hey";
		var givenB = 6;
		var expected = "heyyyyyy";
		var actual = _sut.ModifyingTheLastCharacter(givenA, givenB);
		_ = actual.Should().Be(expected);
	}
	[TestMethod()]
	public void ModifyingTheLastCharacter_Test_3()
	{
		var givenA = "excuse me what?";
		var givenB = 5;
		var expected = "excuse me what?????";
		var actual = _sut.ModifyingTheLastCharacter(givenA, givenB);
		_ = actual.Should().Be(expected);
	}
	//https://edabit.com/challenge/pdHrsZMdhwYNEX3wY
	[TestMethod()]
	public void ReverseTheOrderOfAString_Test_1()
	{
		var given = "Hello World";
		var expected = "dlroW olleH";
		var actual = _sut.ReverseTheOrderOfAString(given);
		_ = actual.Should().Be(expected);
	}
	[TestMethod()]
	public void ReverseTheOrderOfAString_Test_2()
	{
		var given = "The quick brown fox.";
		var expected = ".xof nworb kciuq ehT";
		var actual = _sut.ReverseTheOrderOfAString(given);
		_ = actual.Should().Be(expected);
	}
	[TestMethod()]
	public void ReverseTheOrderOfAString_Test_3()
	{
		var given = "Edabit is really helpful!";
		var expected = "!lufpleh yllaer si tibadE";
		var actual = _sut.ReverseTheOrderOfAString(given);
		_ = actual.Should().Be(expected);
	}
	//https://edabit.com/challenge/HkKNhhdfEGwxm9Fq6
	[TestMethod()]
	public void EliminateOddNumbersWithinAnArray_Test_1()
	{
		var given = new Int32[] { 1, 2, 3, 4, 5, 6, 7, 8 };
		var expected = new Int32[] { 2, 4, 6, 8 };
		var actual = _sut.EliminateOddNumbersWithinAnArray(given);
		_ = actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
	}
	[TestMethod()]
	public void EliminateOddNumbersWithinAnArray_Test_2()
	{
		var given = new Int32[] { 43, 65, 23, 89, 53, 9, 6 };
		var expected = new Int32[] { 6 };
		var actual = _sut.EliminateOddNumbersWithinAnArray(given);
		_ = actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
	}
	[TestMethod()]
	public void EliminateOddNumbersWithinAnArray_Test_3()
	{
		var given = new Int32[] { 718, 991, 449, 644, 380, 440 };
		var expected = new Int32[] { 718, 644, 380, 440 };
		var actual = _sut.EliminateOddNumbersWithinAnArray(given);
		_ = actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
	}
	//https://edabit.com/challenge/b59CKJivMhobiqWDu
	[TestMethod()]
	public void PhoneNumberFormatting_Test_1()
	{
		var given = new Int32[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
		var expected = "(123) 456-7890";
		var actual = _sut.PhoneNumberFormatting(given);
		_ = actual.Should().Be(expected);
	}
	[TestMethod()]
	public void PhoneNumberFormatting_Test_2()
	{
		var given = new Int32[] { 5, 1, 9, 5, 5, 5, 4, 4, 6, 8 };
		var expected = "(519) 555-4468";
		var actual = _sut.PhoneNumberFormatting(given);
		_ = actual.Should().Be(expected);
	}
	[TestMethod()]
	public void PhoneNumberFormatting_Test_3()
	{
		var given = new Int32[] { 3, 4, 5, 5, 0, 1, 2, 5, 2, 7 };
		var expected = "(345) 501-2527";
		var actual = _sut.PhoneNumberFormatting(given);
		_ = actual.Should().Be(expected);
	}
	//https://edabit.com/challenge/rMGErLnrGdDXWZJF5
	[TestMethod()]
	public void ReverseAndCapitalize_Test_1()
	{
		var given = "abc";
		var expected = "CBA";
		var actual = _sut.ReverseAndCapitalize(given);
		_ = actual.Should().Be(expected);
	}
	[TestMethod()]
	public void ReverseAndCapitalize_Test_2()
	{
		var given = "hellothere";
		var expected = "EREHTOLLEH";
		var actual = _sut.ReverseAndCapitalize(given);
		_ = actual.Should().Be(expected);
	}
	[TestMethod()]
	public void ReverseAndCapitalize_Test_3()
	{
		var given = "input";
		var expected = "TUPNI";
		var actual = _sut.ReverseAndCapitalize(given);
		_ = actual.Should().Be(expected);
	}
	//https://edabit.com/challenge/mDNt9RaNdcZwj6xNX
	[TestMethod()]
	public void IsTheAverageOfAllElementsAWholeNumber_Test_1()
	{
		var given = new Int32[] { 1, 3 };
		var expected = true;
		var actual = _sut.IsTheAverageOfAllElementsAWholeNumber(given);
		_ = actual.Should().Be(expected);
	}
	[TestMethod()]
	public void IsTheAverageOfAllElementsAWholeNumber_Test_2()
	{
		var given = new Int32[] { 1, 2, 3, 4 };
		var expected = false;
		var actual = _sut.IsTheAverageOfAllElementsAWholeNumber(given);
		_ = actual.Should().Be(expected);
	}
	[TestMethod()]
	public void IsTheAverageOfAllElementsAWholeNumber_Test_3()
	{
		var given = new Int32[] { 1, 5, 6 };
		var expected = true;
		var actual = _sut.IsTheAverageOfAllElementsAWholeNumber(given);
		_ = actual.Should().Be(expected);
	}
	[TestMethod()]
	public void IsTheAverageOfAllElementsAWholeNumber_Test_4()
	{
		var given = new Int32[] { 1, 1, 1 };
		var expected = true;
		var actual = _sut.IsTheAverageOfAllElementsAWholeNumber(given);
		_ = actual.Should().Be(expected);
	}
	[TestMethod()]
	public void IsTheAverageOfAllElementsAWholeNumber_Test_5()
	{
		var given = new Int32[] { 9, 2, 2, 5 };
		var expected = false;
		var actual = _sut.IsTheAverageOfAllElementsAWholeNumber(given);
		_ = actual.Should().Be(expected);
	}
	//https://edabit.com/challenge/Lmhmtj3QZw9cF5Zew
	[TestMethod()]
	public void RepeatingLettersNTimes_Test_1()
	{
		var givenA = "mice";
		var givenB = 5;
		var expected = "mmmmmiiiiiccccceeeee";
		var actual = _sut.RepeatingLettersNTimes(givenA, givenB);
		_ = actual.Should().Be(expected);
	}
	[TestMethod()]
	public void RepeatingLettersNTimes_Test_2()
	{
		var givenA = "hello";
		var givenB = 3;
		var expected = "hhheeellllllooo";
		var actual = _sut.RepeatingLettersNTimes(givenA, givenB);
		_ = actual.Should().Be(expected);
	}
	[TestMethod()]
	public void RepeatingLettersNTimes_Test_3()
	{
		var givenA = "stop";
		var givenB = 1;
		var expected = "stop";
		var actual = _sut.RepeatingLettersNTimes(givenA, givenB);
		_ = actual.Should().Be(expected);
	}
	//https://edabit.com/challenge/eETZxgueSqivPBmAX
	[TestMethod()]
	public void CalculateTheMean_Test_1()
	{
		var given = new Int32[] { 1, 0, 4, 5, 2, 4, 1, 2, 3, 3, 3 };
		var expected = 2.55;
		var actual = _sut.CalculateTheMean(given);
		_ = actual.Should().Be(expected);
	}
	[TestMethod()]
	public void CalculateTheMean_Test_2()
	{
		var given = new Int32[] { 2, 3, 2, 3 };
		var expected = 2.50;
		var actual = _sut.CalculateTheMean(given);
		_ = actual.Should().Be(expected);
	}
	[TestMethod()]
	public void CalculateTheMean_Test_3()
	{
		var given = new Int32[] { 3, 3, 3, 3, 3 };
		var expected = 3.00;
		var actual = _sut.CalculateTheMean(given);
		_ = actual.Should().Be(expected);
	}
	//https://edabit.com/challenge/W4x4o2M7ny6Cqkfhn
	[TestMethod()]
	public void ReturnTheFourLetterStrings_Test_1()
	{
		var given = new String[] { "Tomato", "Potato", "Pair" };
		var expected = new String[] { "Pair" };
		var actual = _sut.ReturnTheFourLetterStrings(given);
		_ = actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
	}
	[TestMethod()]
	public void ReturnTheFourLetterStrings_Test_2()
	{
		var given = new String[] { "Kangaroo", "Bear", "Fox" };
		var expected = new String[] { "Bear" };
		var actual = _sut.ReturnTheFourLetterStrings(given);
		_ = actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
	}
	[TestMethod()]
	public void ReturnTheFourLetterStrings_Test_3()
	{
		var given = new String[] { "Ryan", "Kieran", "Jason", "Matt" };
		var expected = new String[] { "Ryan", "Matt" };
		var actual = _sut.ReturnTheFourLetterStrings(given);
		_ = actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
	}
	//https://edabit.com/challenge/irKy94NboMHSMzjEL
	[TestMethod()]
	public void XsAndOsNobodyKnows_Test_1()
	{
		var given = "ooxx";
		var expected = true;
		var actual = _sut.XsAndOsNobodyKnows(given);
		_ = actual.Should().Be(expected);
	}
	[TestMethod()]
	public void XsAndOsNobodyKnows_Test_2()
	{
		var given = "xooxx";
		var expected = false;
		var actual = _sut.XsAndOsNobodyKnows(given);
		_ = actual.Should().Be(expected);
	}
	[TestMethod()]
	public void XsAndOsNobodyKnows_Test_3()
	{
		var given = "ooxXm";
		var expected = true;
		var actual = _sut.XsAndOsNobodyKnows(given);
		_ = actual.Should().Be(expected);
	}
	[TestMethod()]
	public void XsAndOsNobodyKnows_Test_4()
	{
		var given = "zpzpzpp";
		var expected = true;
		var actual = _sut.XsAndOsNobodyKnows(given);
		_ = actual.Should().Be(expected);
	}
	[TestMethod()]
	public void XsAndOsNobodyKnows_Test_5()
	{
		var given = "zzoo";
		var expected = false;
		var actual = _sut.XsAndOsNobodyKnows(given);
		_ = actual.Should().Be(expected);
	}
	//https://edabit.com/challenge/jRQSYLrcWLtxtYnx4
	[TestMethod()]
	public void AlphabetSoup_Test_1()
	{
		var given = "hello";
		var expected = "ehllo";
		var actual = _sut.AlphabetSoup(given);
		_ = actual.Should().Be(expected);
	}
	[TestMethod()]
	public void AlphabetSoup_Test_2()
	{
		var given = "edabit";
		var expected = "abdeit";
		var actual = _sut.AlphabetSoup(given);
		_ = actual.Should().Be(expected);
	}
	[TestMethod()]
	public void AlphabetSoup_Test_3()
	{
		var given = "hacker";
		var expected = "acehkr";
		var actual = _sut.AlphabetSoup(given);
		_ = actual.Should().Be(expected);
	}
	[TestMethod()]
	public void AlphabetSoup_Test_4()
	{
		var given = "geek";
		var expected = "eegk";
		var actual = _sut.AlphabetSoup(given);
		_ = actual.Should().Be(expected);
	}
	[TestMethod()]
	public void AlphabetSoup_Test_5()
	{
		var given = "javascript";
		var expected = "aacijprstv";
		var actual = _sut.AlphabetSoup(given);
		_ = actual.Should().Be(expected);
	}
	//https://edabit.com/challenge/qvo2Ae8WdRQfCwaQk
	[TestMethod()]
	public void RetrieveTheSubreddit_Test_1()
	{
		var given = "https://www.reddit.com/r/funny/";
		var expected = "funny";
		var actual = _sut.RetrieveTheSubreddit(given);
		_ = actual.Should().Be(expected);
	}
	[TestMethod()]
	public void RetrieveTheSubreddit_Test_2()
	{
		var given = "https://www.reddit.com/r/relationships/";
		var expected = "relationships";
		var actual = _sut.RetrieveTheSubreddit(given);
		_ = actual.Should().Be(expected);
	}
	[TestMethod()]
	public void RetrieveTheSubreddit_Test_3()
	{
		var given = "https://www.reddit.com/r/mildlyinteresting/";
		var expected = "mildlyinteresting";
		var actual = _sut.RetrieveTheSubreddit(given);
		_ = actual.Should().Be(expected);
	}
	//https://edabit.com/challenge/kjeS389wuyQ4Y4vZa
	[TestMethod()]
	public void AmongUsImposterFormula_Test_1()
	{
		var givenA = 1;
		var givenB = 10;
		var expected = "10%";
		var actual = _sut.AmongUsImposterFormula(givenA, givenB);
		_ = actual.Should().Be(expected);
	}
	[TestMethod()]
	public void AmongUsImposterFormula_Test_2()
	{
		var givenA = 2;
		var givenB = 5;
		var expected = "40%";
		var actual = _sut.AmongUsImposterFormula(givenA, givenB);
		_ = actual.Should().Be(expected);
	}
	[TestMethod()]
	public void AmongUsImposterFormula_Test_3()
	{
		var givenA = 1;
		var givenB = 8;
		var expected = "13%";
		var actual = _sut.AmongUsImposterFormula(givenA, givenB);
		_ = actual.Should().Be(expected);
	}
	//https://edabit.com/challenge/gFiX2TwoCKi6NZz5H
	[TestMethod()]
	public void LastDigitUltimate_Test_1()
	{
		var given = new Int32[] { 25, 21, 125 };
		var expected = true;
		var actual = _sut.LastDigitUltimate(given);
		_ = actual.Should().Be(expected);
	}
	[TestMethod()]
	public void LastDigitUltimate_Test_2()
	{
		var given = new Int32[] { 55, 226, 5190 };
		var expected = true;
		var actual = _sut.LastDigitUltimate(given);
		_ = actual.Should().Be(expected);
	}
	[TestMethod()]
	public void LastDigitUltimate_Test_3()
	{
		var given = new Int32[] { 12, 215, 2142 };
		var expected = false;
		var actual = _sut.LastDigitUltimate(given);
		_ = actual.Should().Be(expected);
	}
	//https://edabit.com/challenge/bhABvXWDsKSBjD5HR
	[TestMethod()]
	public void HashesAndPluses_Test_1()
	{
		var given = "###+";
		var expected = new Int32[] { 3, 1 };
		var actual = _sut.HashesAndPluses(given);
		_ = actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
	}
	[TestMethod()]
	public void HashesAndPluses_Test_2()
	{
		var given = "##+++#";
		var expected = new Int32[] { 3, 3 };
		var actual = _sut.HashesAndPluses(given);
		_ = actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
	}
	[TestMethod()]
	public void HashesAndPluses_Test_3()
	{
		var given = "#+++#+#++#";
		var expected = new Int32[] { 4, 6 };
		var actual = _sut.HashesAndPluses(given);
		_ = actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
	}
	[TestMethod()]
	public void HashesAndPluses_Test_4()
	{
		var given = "";
		var expected = new Int32[] { 0, 0 };
		var actual = _sut.HashesAndPluses(given);
		_ = actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
	}
	//https://edabit.com/challenge/sTTJNhDFDzCDxeiGZ
	[TestMethod()]
	public void IsTheStringAPalindrome_Test_1()
	{
		var given = "mom";
		var expected = true;
		var actual = _sut.IsTheStringAPalindrome(given);
		_ = actual.Should().Be(expected);
	}
	[TestMethod()]
	public void IsTheStringAPalindrome_Test_2()
	{
		var given = "scary";
		var expected = false;
		var actual = _sut.IsTheStringAPalindrome(given);
		_ = actual.Should().Be(expected);
	}
	[TestMethod()]
	public void IsTheStringAPalindrome_Test_3()
	{
		var given = "reviver";
		var expected = true;
		var actual = _sut.IsTheStringAPalindrome(given);
		_ = actual.Should().Be(expected);
	}
	[TestMethod()]
	public void IsTheStringAPalindrome_Test_4()
	{
		var given = "stressed";
		var expected = false;
		var actual = _sut.IsTheStringAPalindrome(given);
		_ = actual.Should().Be(expected);
	}
	//https://edabit.com/challenge/TofdXBRqnf7JFiZBC
	[TestMethod()]
	public void RemoveDuplicatesFromAnArray_Test_1()
	{
		var given = new Int32[] { 1, 0, 1, 0 };
		var expected = new Int32[] { 1, 0 };
		var actual = _sut.RemoveDuplicatesFromAnArray(given);
		_ = actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
	}
	[TestMethod()]
	public void RemoveDuplicatesFromAnArray_Test_2()
	{
		var given = new String[] { "The", "big", "cat" };
		var expected = new String[] { "The", "big", "cat" };
		var actual = _sut.RemoveDuplicatesFromAnArray(given);
		_ = actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
	}
	[TestMethod()]
	public void RemoveDuplicatesFromAnArray_Test_3()
	{
		var given = new String[] { "John", "Taylor", "John" };
		var expected = new String[] { "John", "Taylor" };
		var actual = _sut.RemoveDuplicatesFromAnArray(given);
		_ = actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
	}
	//https://edabit.com/challenge/eLm7MqFQhWNfr2u8p
	[TestMethod()]
	public void HowManySolutionsDoesThisQuadraticHave_Test_1()
	{
		var givenA = 1;
		var givenB = 0;
		var givenC = -1;
		var expected = 2;
		var actual = _sut.HowManySolutionsDoesThisQuadraticHave(givenA, givenB, givenC);
		_ = actual.Should().Be(expected);
	}
	[TestMethod()]
	public void HowManySolutionsDoesThisQuadraticHave_Test_2()
	{
		var givenA = 1;
		var givenB = 0;
		var givenC = 0;
		var expected = 1;
		var actual = _sut.HowManySolutionsDoesThisQuadraticHave(givenA, givenB, givenC);
		_ = actual.Should().Be(expected);
	}
	[TestMethod()]
	public void HowManySolutionsDoesThisQuadraticHave_Test_3()
	{
		var givenA = 1;
		var givenB = 0;
		var givenC = 1;
		var expected = 0;
		var actual = _sut.HowManySolutionsDoesThisQuadraticHave(givenA, givenB, givenC);
		_ = actual.Should().Be(expected);
	}
	//https://edabit.com/challenge/jZKws3Rv2R3JphCWc
	[TestMethod()]
	public void VowelReplacer_Test_1()
	{
		var givenA = "the aardvark";
		var givenB = '#';
		var expected = "th# ##rdv#rk";
		var actual = _sut.VowelReplacer(givenA, givenB);
		_ = actual.Should().Be(expected);
	}
	[TestMethod()]
	public void VowelReplacer_Test_2()
	{
		var givenA = "minnie mouse";
		var givenB = '?';
		var expected = "m?nn?? m??s?";
		var actual = _sut.VowelReplacer(givenA, givenB);
		_ = actual.Should().Be(expected);
	}
	[TestMethod()]
	public void VowelReplacer_Test_3()
	{
		var givenA = "shakespeare";
		var givenB = '*';
		var expected = "sh*k*sp**r*";
		var actual = _sut.VowelReplacer(givenA, givenB);
		_ = actual.Should().Be(expected);
	}
	//https://edabit.com/challenge/XofGbRFcoGqRv9gda
	[TestMethod()]
	public void BetweenWords_Test_1()
	{
		var givenA = "apple";
		var givenB = "banana";
		var givenC = "azure";
		var expected = false;
		var actual = _sut.BetweenWords(givenA, givenB, givenC);
		_ = actual.Should().Be(expected);
	}
	[TestMethod()]
	public void BetweenWords_Test_2()
	{
		var givenA = "monk";
		var givenB = "monument";
		var givenC = "monkey";
		var expected = false;
		var actual = _sut.BetweenWords(givenA, givenB, givenC);
		_ = actual.Should().Be(expected);
	}
	[TestMethod()]
	public void BetweenWords_Test_3()
	{
		var givenA = "bookend";
		var givenB = "boolean";
		var givenC = "boost";
		var expected = true;
		var actual = _sut.BetweenWords(givenA, givenB, givenC);
		_ = actual.Should().Be(expected);
	}
	//https://edabit.com/challenge/yu9e29LSdRXSsb5YG
	[TestMethod()]
	public void Equalityof3Values_Test_1()
	{
		var givenA = 3;
		var givenB = 4;
		var givenC = 3;
		var expected = 2;
		var actual = _sut.Equalityof3Values(givenA, givenB, givenC);
		_ = actual.Should().Be(expected);
	}
	[TestMethod()]
	public void Equalityof3Values_Test_2()
	{
		var givenA = 1;
		var givenB = 1;
		var givenC = 1;
		var expected = 3;
		var actual = _sut.Equalityof3Values(givenA, givenB, givenC);
		_ = actual.Should().Be(expected);
	}
	[TestMethod()]
	public void Equalityof3Values_Test_3()
	{
		var givenA = 3;
		var givenB = 4;
		var givenC = 1;
		var expected = 0;
		var actual = _sut.Equalityof3Values(givenA, givenB, givenC);
		_ = actual.Should().Be(expected);
	}
	//https://edabit.com/challenge/jh6BWPukQ3wRshbRR
	[TestMethod()]
	public void SpacesBetweenEachCharacter_Test_1()
	{
		var given = "space";
		var expected = "s p a c e";
		var actual = _sut.SpacesBetweenEachCharacter(given);
		_ = actual.Should().Be(expected);
	}
	[TestMethod()]
	public void SpacesBetweenEachCharacter_Test_2()
	{
		var given = "far out";
		var expected = "f a r   o u t";
		var actual = _sut.SpacesBetweenEachCharacter(given);
		_ = actual.Should().Be(expected);
	}
	[TestMethod()]
	public void SpacesBetweenEachCharacter_Test_3()
	{
		var given = "elongated musk";
		var expected = "e l o n g a t e d   m u s k";
		var actual = _sut.SpacesBetweenEachCharacter(given);
		_ = actual.Should().Be(expected);
	}
	//https://edabit.com/challenge/B4LF3aLb96oRyT9DT
	[TestMethod()]
	public void FindTheMissingNumber_Test_1()
	{
		var given = new Int32[] { 1, 2, 3, 4, 6, 7, 8, 9, 10 };
		var expected = 5;
		var actual = _sut.FindTheMissingNumber(given);
		_ = actual.Should().Be(expected);
	}
	[TestMethod()]
	public void FindTheMissingNumber_Test_2()
	{
		var given = new Int32[] { 7, 2, 3, 6, 5, 9, 1, 4, 8 };
		var expected = 10;
		var actual = _sut.FindTheMissingNumber(given);
		_ = actual.Should().Be(expected);
	}
	[TestMethod()]
	public void FindTheMissingNumber_Test_3()
	{
		var given = new Int32[] { 10, 5, 1, 2, 4, 6, 8, 3, 9 };
		var expected = 7;
		var actual = _sut.FindTheMissingNumber(given);
		_ = actual.Should().Be(expected);
	}
	//https://edabit.com/challenge/6k7ndtuxRPeSwNF93
	[TestMethod()]
	public void LargestSwap_Test_1()
	{
		var given = 27;
		var expected = false;
		var actual = _sut.LargestSwap(given);
		_ = actual.Should().Be(expected);
	}
	[TestMethod()]
	public void LargestSwap_Test_2()
	{
		var given = 43;
		var expected = true;
		var actual = _sut.LargestSwap(given);
		_ = actual.Should().Be(expected);
	}
	[TestMethod()]
	public void LargestSwap_Test_3()
	{
		var given = 14;
		var expected = false;
		var actual = _sut.LargestSwap(given);
		_ = actual.Should().Be(expected);
	}
	[TestMethod()]
	public void LargestSwap_Test_4()
	{
		var given = 53;
		var expected = true;
		var actual = _sut.LargestSwap(given);
		_ = actual.Should().Be(expected);
	}
	[TestMethod()]
	public void LargestSwap_Test_5()
	{
		var given = 99;
		var expected = true;
		var actual = _sut.LargestSwap(given);
		_ = actual.Should().Be(expected);
	}
	//https://edabit.com/challenge/HfMTT2WGoWxSrF52r
	[TestMethod()]
	public void FindTheIndex_Test_1()
	{
		var givenA = new Int32[] { 1, 2, 3, 4 };
		var givenB = 3;
		var expected = 2;
		var actual = _sut.FindTheIndex(givenA, givenB);
		_ = actual.Should().Be(expected);
	}
	[TestMethod()]
	public void FindTheIndex_Test_2()
	{
		var givenA = new Int32[] { 2, 4, 6, 8, 10 };
		var givenB = 8;
		var expected = 3;
		var actual = _sut.FindTheIndex(givenA, givenB);
		_ = actual.Should().Be(expected);
	}
	[TestMethod()]
	public void FindTheIndex_Test_3()
	{
		var givenA = new Int32[] { 1, 3, 5, 7, 9 };
		var givenB = 11;
		var expected = -1;
		var actual = _sut.FindTheIndex(givenA, givenB);
		_ = actual.Should().Be(expected);
	}
	//https://edabit.com/challenge/xvSXDZh2GHE6F28SA
	[TestMethod()]
	public void ValidZipCode_Test_1()
	{
		var given = "59001";
		var expected = true;
		var actual = _sut.ValidZipCode(given);
		_ = actual.Should().Be(expected);
	}
	[TestMethod()]
	public void ValidZipCode_Test_2()
	{
		var given = "853a7";
		var expected = false;
		var actual = _sut.ValidZipCode(given);
		_ = actual.Should().Be(expected);
	}
	[TestMethod()]
	public void ValidZipCode_Test_3()
	{
		var given = "732 32";
		var expected = false;
		var actual = _sut.ValidZipCode(given);
		_ = actual.Should().Be(expected);
	}
	[TestMethod()]
	public void ValidZipCode_Test_4()
	{
		var given = "393939";
		var expected = false;
		var actual = _sut.ValidZipCode(given);
		_ = actual.Should().Be(expected);
	}
	//https://edabit.com/challenge/HXsSRtx83xj7K94dW
	[TestMethod()]
	public void RemoveEveryVowelFromAString_Test_1()
	{
		var given = "I have never seen a thin person drinking Diet Coke.";
		var expected = " hv nvr sn  thn prsn drnkng Dt Ck.";
		var actual = _sut.RemoveEveryVowelFromAString(given);
		_ = actual.Should().Be(expected);
	}
	[TestMethod()]
	public void RemoveEveryVowelFromAString_Test_2()
	{
		var given = "We're gonna build a wall!";
		var expected = "W'r gnn bld  wll!";
		var actual = _sut.RemoveEveryVowelFromAString(given);
		_ = actual.Should().Be(expected);
	}
	[TestMethod()]
	public void RemoveEveryVowelFromAString_Test_3()
	{
		var given = "Happy Thanksgiving to all--even the haters and losers!";
		var expected = "Hppy Thnksgvng t ll--vn th htrs nd lsrs!";
		var actual = _sut.RemoveEveryVowelFromAString(given);
		_ = actual.Should().Be(expected);
	}
	//https://edabit.com/challenge/9Emx6unF8evWiXnJA
	[TestMethod()]
	public void PurgeAndOrganize_Test_1()
	{
		var given = new Int32[] { 1, 2, 4, 3 };
		var expected = new Int32[] { 1, 2, 3, 4 };
		var actual = _sut.PurgeAndOrganize(given);
		_ = actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
	}
	[TestMethod()]
	public void PurgeAndOrganize_Test_2()
	{
		var given = new Int32[] { 1, 4, 4, 4, 4, 4, 3, 2, 1, 2 };
		var expected = new Int32[] { 1, 2, 3, 4 };
		var actual = _sut.PurgeAndOrganize(given);
		_ = actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
	}
	[TestMethod()]
	public void PurgeAndOrganize_Test_3()
	{
		var given = new Int32[] { 6, 7, 3, 2, 1 };
		var expected = new Int32[] { 1, 2, 3, 6, 7 };
		var actual = _sut.PurgeAndOrganize(given);
		_ = actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
	}
	//https://edabit.com/challenge/moqcQ563NukBBbKDL
	[TestMethod()]
	public void LettersOnly_Test_1()
	{
		var given = "R!=:~0o0./c&}9k`60=y";
		var expected = "Rocky";
		var actual = _sut.LettersOnly(given);
		_ = actual.Should().Be(expected);
	}
	[TestMethod()]
	public void LettersOnly_Test_2()
	{
		var given = "^,]%4B|@56a![0{2m>b1&4i4";
		var expected = "Bambi";
		var actual = _sut.LettersOnly(given);
		_ = actual.Should().Be(expected);
	}
	[TestMethod()]
	public void LettersOnly_Test_3()
	{
		var given = "^U)6$22>8p).";
		var expected = "Up";
		var actual = _sut.LettersOnly(given);
		_ = actual.Should().Be(expected);
	}
	//https://edabit.com/challenge/DYNxn8fpWHutWZxEZ
	[TestMethod()]
	public void AnIntroductionToTheMapReducePattern_Test_1()
	{
		var given = new Int32[] { 3, 4 };
		var expected = 5;
		var actual = _sut.AnIntroductionToTheMapReducePattern(given);
		_ = actual.Should().Be(expected);
	}
	[TestMethod()]
	public void AnIntroductionToTheMapReducePattern_Test_2()
	{
		var given = new Int32[] { 0, 0, -10 };
		var expected = 10;
		var actual = _sut.AnIntroductionToTheMapReducePattern(given);
		_ = actual.Should().Be(expected);
	}
	[TestMethod()]
	public void AnIntroductionToTheMapReducePattern_Test_3()
	{
		var given = Array.Empty<Int32>();
		var expected = 0;
		var actual = _sut.AnIntroductionToTheMapReducePattern(given);
		_ = actual.Should().Be(expected);
	}
	[TestMethod()]
	public void AnIntroductionToTheMapReducePattern_Test_4()
	{
		var given = new Int32[] { 2, 3, 6, 1, 8 };
		var expected = 10.677078252031311;
		var actual = _sut.AnIntroductionToTheMapReducePattern(given);
		_ = actual.Should().Be(expected);
	}
	//https://edabit.com/challenge/MMRWB6cYnpsp3uTPT
	[TestMethod()]
	public void CumulativeArraySum_Test_1()
	{
		var given = new Int32[] { 1, 2, 3 };
		var expected = new Int32[] { 1, 3, 6 };
		var actual = _sut.CumulativeArraySum(given);
		_ = actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
	}
	[TestMethod()]
	public void CumulativeArraySum_Test_2()
	{
		var given = new Int32[] { 1, -2, 3 };
		var expected = new Int32[] { 1, -1, 2 };
		var actual = _sut.CumulativeArraySum(given);
		_ = actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
	}
	[TestMethod()]
	public void CumulativeArraySum_Test_3()
	{
		var given = new Int32[] { 3, 3, -2, 408, 3, 3 };
		var expected = new Int32[] { 3, 6, 4, 412, 415, 418 };
		var actual = _sut.CumulativeArraySum(given);
		_ = actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
	}
}
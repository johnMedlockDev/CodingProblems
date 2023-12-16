
namespace CodingProblems.Console.Edabit;
public class Easy
{
	public String ConvertNumberToCorrespondingMonthName(Int32 monthNumber)
	{
		return CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(monthNumber);

	}

	public Int32[] FindTheSmallestAndBiggestNumbers(Int32[] arr)
	{
		return arr == null || arr.Length == 0 ? Array.Empty<Int32>() : ([arr.Min(), arr.Max()]);
	}

	public Int32 AbsoluteSum(Int32[] arr)
	{
		return arr.Sum(Math.Abs);
	}

	public Int64 ToThePowerOf(Int32 numOne, Int32 numTwo)
	{
		return (Int64) Math.Pow(numOne, numTwo);
	}

	public Int32[] MultiplyByLength(Int32[] arr)
	{
		for (var i = 0; i < arr.Length; i++)
		{
			arr[i] = arr[i] * arr.Length;
		}

		return arr;
	}

	public Int32 HammingDistance(String wordOne, String wordTwo)
	{
		return wordOne == null || wordTwo == null || wordOne.Length != wordTwo.Length ? -1 : wordOne.Where((t, i) => t != wordTwo[i]).Count();
	}

	public String NameShuffle(String phrase)
	{
		return String.Join(" ", phrase.Split(' ').Reverse());
	}

	public String SmallerStringNumber(String sNumOne, String sNumTwo)
	{
		return Math.Min(Int32.Parse(sNumOne), Int32.Parse(sNumTwo)).ToString();
	}

	public Int64 ReturnTheFactorial(Int32 num)
	{
		var factorial = 1;

		for (var i = 1; i <= num; i++)
		{
			factorial *= i;
		}

		return factorial;
	}

	public Int32 HowManyVowels(String word)
	{
		return word.Count("aeiouAEIOU".Contains);
	}

	public Int32[] SortNumbersInAscendingOrder(Int32[]? arr)
	{
		return arr == null ? [] : [.. arr.OrderBy(x => x)];
	}

	public Boolean CheckIfAStringContainsOnlyIdenticalCharacters(String letters)
	{
		return !String.IsNullOrEmpty(letters) && letters.All(c => c == letters[0]);
	}

	public String H4ck3rSp34k(String word)
	{
		var replacements = new Dictionary<Char, Char> { ['a'] = '4', ['e'] = '3', ['i'] = '1', ['o'] = '0', ['s'] = '5' };
		return String.Concat(word.Select(c => replacements.TryGetValue(c, out var value) ? value : c));
	}
	public Boolean CheckIfTheSameCase(String word)
	{
		if (String.IsNullOrEmpty(word))
		{
			return true;
		}

		var isUpper = Char.IsUpper(word[0]);
		return word.All(c => Char.IsUpper(c) == isUpper);
	}
	public Int32 RaucousApplause(String word)
	{
		return word.Count(c => Char.ToUpperInvariant(c) == 'C');
	}

	public String ShapesWithNSides(Int32 numberOfSides)
	{
		var shapesDictionary = new Dictionary<Int32, String>
		{
			{ 1, "circle" },
			{ 2, "semi-circle" },
			{ 3, "triangle" },
			{ 4, "square" },
			{ 5, "pentagon" },
			{ 6, "hexagon" },
			{ 7, "heptagon" },
			{ 8, "octagon" },
			{ 9, "nonagon" },
			{ 10, "decagon" }
		};

		return shapesDictionary.TryGetValue(numberOfSides, out var shape) ? shape : "Unknown shape";
	}

	public String Burrrrrrrp(Int32 numberOfRs)
	{
		return "Bu" + new String('r', numberOfRs) + "p";
	}

	public Int32 HowManyDsAreThere(System.String sentence)
	{
		var sumOfD = 0;
		foreach (var letter in sentence)
		{
			if (letter is 'd' or 'D')
			{
				sumOfD++;
			}
		}

		return sumOfD;
	}

	public String RemoveTheFirstAndLastCharacters(String word)
	{
		return word.Length == 1 ? word : word[1..^1];
	}

	public Boolean BackToHome(String directions)
	{
		Dictionary<Char, Int32> directionCounts = [];

		foreach (var direction in directions)
		{
			if (directionCounts.ContainsKey(direction))
			{
				directionCounts[direction] += 1;
			}
			else
			{
				directionCounts[direction] = 0;
			}
		}

		var vFirst = -1;
		foreach (var kp in directionCounts)
		{
			if (vFirst == -1)
			{
				vFirst = kp.Value;
				continue;
			}

			if (kp.Value != vFirst)
			{
				return false;
			}
		}

		return true;
	}

	public String StutteringFunction(String word)
	{
		var sb = new StringBuilder();
		_ = sb.Append(word[..2]);
		_ = sb.Append("... ");
		_ = sb.Append(word[..2]);
		_ = sb.Append("... ");
		_ = sb.Append(word);
		_ = sb.Append('?');

		return sb.ToString();
	}
	public String DateFormat(String dateStr)
	{
		return DateTime.TryParseExact(dateStr, "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out var parsedDate)
			? parsedDate.ToString("yyyyddMM")
			: throw new ArgumentException("Invalid date format");
	}

	public String FizzBuzzInterviewQuestion(Int32 number)
	{
		var fizzBuzz = "";

		if (number % 3 == 0)
		{
			fizzBuzz += "Fizz";
		}

		if (number % 5 == 0)
		{
			fizzBuzz += "Buzz";
		}

		return fizzBuzz == "" ? number.ToString() : fizzBuzz;
	}

	public Double SumOfResistanceInParallelCircuits(Int32[] array)
	{
		var reciprocalSum = array.Sum(num => 1.0 / num);
		return Math.Round(1 / reciprocalSum, 1);
	}

	public Int32 RecursionSum(Int32 num)
	{
		if (num <= 0)
		{
			return 0; // Base case for non-positive integers
		}

		if (num == 1)
		{
			return 1; // Base case
		}

		return num + RecursionSum(num - 1); // Recursive call
	}

	public Int32 NextNumberGreaterThanAAndBAndDivisibleByB(Int32 numOne, Int32 numTwo)
	{
		var multiple = numOne + 1;
		while (true)
		{
			if (multiple % numTwo == 0)
			{
				break;
			}

			multiple++;
		}

		return multiple;
	}
	public String RecursionToRepeatAStringNNumberOfTimes(String txt, Int32 num)
	{
		if (num <= 0)
		{
			return ""; // Return empty string for non-positive integers
		}

		if (num == 1)
		{
			return txt; // Base case
		}

		return txt + RecursionToRepeatAStringNNumberOfTimes(txt, num - 1); // Recursive call
	}

	public String GetTheFileName(String pathStr)
	{
		return pathStr.Split('/').Last();
	}

	public String RepeatingLetters(String word)
	{
		var sb = new StringBuilder();

		foreach (var letter in word)
		{
			_ = sb.Append(letter);
			_ = sb.Append(letter);
		}

		return sb.ToString();
	}

	public Boolean DoubleLetters(String word)
	{
		var previousLetter = ' ';
		foreach (var letter in word)
		{
			if (previousLetter == ' ')
			{
				previousLetter = letter;
				continue;
			}

			if (previousLetter == letter)
			{
				return true;
			}

			previousLetter = letter;
		}

		return false;
	}

	public String ReFormTheWord(String wPartOne, String wPartTwo)
	{
		var sb = new StringBuilder();

		_ = sb.Append(wPartOne[0].ToString().ToUpper());
		_ = sb.Append(wPartOne[1..]);
		_ = sb.Append(wPartTwo);

		return sb.ToString();
	}
	public String ModifyingTheLastCharacter(String word, Int32 num)
	{
		return $"{word}{new String(word.ToCharArray().Last(), num - 1)}";
	}
	public String ReverseTheOrderOfAString(String phrase)
	{
		var sb = new StringBuilder(phrase.Length);
		for (var i = phrase.Length - 1; i >= 0; i--)
		{
			_ = sb.Append(phrase[i]);
		}

		return sb.ToString();
	}
	public Int32[] EliminateOddNumbersWithinAnArray(Int32[] array)
	{
		return (from num in array
				where num % 2 == 0
				select num).ToArray();
	}

	public String PhoneNumberFormatting(Int32[] array)
	{
		return String.Format("({0}{1}{2}) {3}{4}{5}-{6}{7}{8}{9}", array.Select(n => n.ToString()).ToArray());
	}

	public String ReverseAndCapitalize(String word)
	{
		var sb = new StringBuilder(word.Length);
		for (var i = word.Length - 1; i >= 0; i--)
		{
			_ = sb.Append(word[i].ToString().ToUpper());
		}

		return sb.ToString();
	}
	public Boolean IsTheAverageOfAllElementsAWholeNumber(Int32[] array)
	{
		return array.Average() % 1 == 0;
	}

	public String RepeatingLettersNTimes(String word, Int32 num)
	{
		var sb = new StringBuilder();

		foreach (var letter in word)
		{
			_ = sb.Append(new String(letter, num));

		}

		return sb.ToString();
	}

	public Double CalculateTheMean(Int32[] array)
	{
		return Math.Round(array.Average(), 2);
	}

	public String[] ReturnTheFourLetterStrings(String[] array)
	{
		return (from str in array
				where str.Length == 4
				select str).ToArray();
	}

	public Boolean XsAndOsNobodyKnows(String chars)
	{
		Int32 countX = 0, countO = 0;

		foreach (var c in chars.ToUpperInvariant())
		{
			if (c == 'X')
			{
				countX++;
			}

			if (c == 'O')
			{
				countO++;
			}
		}

		return countX == countO;
	}
}

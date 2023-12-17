namespace CodeProblems.Edabit;
public class Medium
{

	public Int32[] ArrayOfMultiples(Int32 num, Int32 length)
	{
		var nums = new List<Int32>();
		for (var i = 1; i < length + 1; i++)
		{
			nums.Add(num * i);
		}

		return [.. nums];
	}

	public String ReverseTheCase(String phrase)
	{
		var sb = new StringBuilder(phrase.Length);

		foreach (var letter in phrase.ToCharArray())
		{
			_ = Char.IsLower(letter) ? sb.Append(letter.ToString().ToUpper()) : sb.Append(letter.ToString().ToLower());
		}

		return sb.ToString();
	}

	public Boolean EqualityCheck<T>(Int32 number, T value)
	{
		return typeof(T) == typeof(Int32) && number.Equals(value);
	}

	public Int32[] ReturnTheIndexOfAllCapitalLetters(String word)
	{
		var indexList = new List<Int32>();
		for (var i = 0; i < word.Length; i++)
		{
			var currentLetter = word[i];
			if (Char.IsUpper(currentLetter))
			{
				indexList.Add(i);
			}
		}

		return [.. indexList];
	}

	public String FindTheBomb(String sentence)
	{
		return sentence.Contains("bomb") ? "Duck!!!" : "There is no bomb, relax.";
	}
	public String[] ConvertAllArrayItemsToString(Object[] array)
	{
		var strList = new List<String>();
		foreach (var item in array)
		{
			if (item is not null)
			{
				// complier says it can be null but it can't be.
#pragma warning disable CS8604 // Possible null reference argument.
				strList.Add(item.ToString());
#pragma warning restore CS8604 // Possible null reference argument.
			}
		}

		return [.. strList];
	}
	public Double[] FindTheLargestNumbersInAGroupOfArrays(Double[][] arrays)
	{
		var largestList = new List<Double>();

		foreach (var array in arrays)
		{
			var largest = Double.MinValue;
			for (var i = 0; i < array.Length; i++)
			{
				var currentValue = array[i];
				if (currentValue > largest)
				{
					largest = currentValue;
				}
			}

			largestList.Add(largest);
		}

		return [.. largestList];
	}

	public String CountTheLettersAndDigits(String phrase)
	{
		Int32 letters = 0, digits = 0;
		foreach (var c in phrase)
		{
			if (Char.IsLetter(c))
			{
				letters++;
				continue;
			}

			if (Char.IsNumber(c))
			{
				digits++;
			}
		}

		return "{ LETTERS =  " + letters + ", DIGITS =  " + digits + " }";
	}

	public Int32 FindTheCharactersCounterpartCharCode(String character)
	{
		return character.ToCharArray().First();
	}
	public Int32 CountOnesInBinaryRepresentationOfInteger(Int32 num)
	{
		return (Int32) Convert.ToString(num, 2).ToCharArray().ToList().Select(Char.GetNumericValue).Sum();
	}

	public Int32[] PositiveCountNegativeSum(Int32[] array)
	{
		if (array.Length == 0)
		{
			return [];
		}

		var positiveCount = 0;
		var negativeSum = 0;

		foreach (var num in array)
		{
			if (num > 0)
			{
				positiveCount++;
			}
			else
			{
				negativeSum += num;
			}
		}

		return [positiveCount, negativeSum];
	}

	public Boolean ATMPINCodeValidation(String pin)
	{
		if (pin.Length != 4)
		{
			return false;
		}

		foreach (var c in pin)
		{
			if (!Char.IsNumber(c))
			{
				return false;
			}
		}

		return true;
	}
}

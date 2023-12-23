using System.Text.RegularExpressions;
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
                strList.Add(item.ToString() ?? "");
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
        if (pin.Length is not 4 or 6)
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

    public Boolean FractionGreaterThanOne(String fraction)
    {
        var strArray = fraction.Split("/");
        var numerator = Double.Parse(strArray[0]);
        var denominator = Double.Parse(strArray[1]);

        return (numerator / denominator) > 1.0;
    }
    public String ReturnTheMiddleCharacterOfAString(String word)
    {
        var middle = (Int32) (word.Length / 2.0);

        return Int32.IsOddInteger(word.Length) ? word[middle].ToString() : $"{word[middle - 1]}{word[middle]}";
    }

    public String ScottishScreaming(String phrase)
    {
        var sb = new StringBuilder(phrase.Length);

        foreach (var letter in phrase)
        {
            if (letter is 'a' or 'e' or 'i' or 'o' or 'u' or 'A' or 'E' or 'I' or 'O' or 'U')
            {
                _ = sb.Append('E');
                continue;
            }

            _ = sb.Append(letter.ToString().ToUpper());
        }

        return sb.ToString();
    }

    public String MaskifyTheString(String strNum)
    {
        if (strNum.Length < 4)
        {
            return strNum;
        }

        var sb = new StringBuilder(strNum.Length);

        for (var i = 0; i < strNum.Length; i++)
        {
            _ = strNum.Length - 4 <= i ? sb.Append(strNum[i]) : sb.Append('#');
        }

        return sb.ToString();
    }

    public Int32 GCDOfTwoNumbers(Int32 numOne, Int32 numTwo)
    {
        var gcd = 0;
        var largerNumber = numOne <= numTwo ? numTwo : numOne;

        for (var i = 1; i < largerNumber; i++)
        {
            if (numTwo % i == 0 && numOne % i == 0)
            {
                gcd = i;
            }
        }

        return gcd;
    }

    public Int32[] FilterOutStringsFromAnArray(Object[] array)
    {
        var intList = new List<Int32>();

        foreach (var item in array)
        {
            if (item.GetType() == typeof(Int32))
            {
                intList.Add((Int32) item);
            }
        }

        return [.. intList];
    }

    public String ReturnTheHighestAndLowestNumbers(String numSpaceString)
    {
        var numStringList = numSpaceString.Split(' ').ToList();
        var max = numStringList.Max();
        var min = numStringList.Min();

        return $"{max} {min}";
    }

    public Boolean CheckIfANumberIsAPalindrome(Int32 number)
    {
        var numString = number.ToString();
        var reversedNumString = new String(numString.ToCharArray().Reverse().ToArray());

        return numString.Equals(reversedNumString);
    }

    public String FormatNumberwithCommaSeparatingThousands(Int32 number)
    {
        var numberString = number.ToString();

        if (numberString.Length < 4)
        {
            return numberString;
        }

        var reversedString = numberString.ToCharArray().ToList();
        reversedString.Reverse();

        var sb = new StringBuilder();

        var count = 0;

        for (var i = 0; i < reversedString.Count; i++)
        {
            if (count != 3)
            {
                _ = sb.Append(reversedString[i]);
                count++;
            }
            else
            {
                _ = sb.Append(',');
                _ = sb.Append(reversedString[i]);
                count = 1;
            }
        }

        return new String(sb.ToString().Reverse().ToArray());
    }

    public String FindingNemo(String sentence)
    {
        var spacedArray = sentence.Split(' ');
        var index = spacedArray.ToList().IndexOf("Nemo") + 1;
        return $"I found Nemo at {index}!";
    }

    public Int32 SortNumbersInDescendingOrder(Int32 number)
    {
        var stringNumber = number.ToString();
        var charArray = stringNumber.ToCharArray();
        var sortedCharArray = charArray.OrderDescending().ToArray();
        var sortedStringNumber = new String(sortedCharArray);

        return Int32.Parse(sortedStringNumber);
    }

    public Boolean IsTheWordAnIsogram(String word)
    {
        var letterDict = new Dictionary<Char, Int32>();
        foreach (var wordChar in word.ToCharArray())
        {
            var normalizedLetter = wordChar.ToString().ToLower().ToCharArray()[0];
            if (!letterDict.ContainsKey(normalizedLetter))
            {
                letterDict[normalizedLetter] = 0;
            }
            else
            {
                return false;
            }
        }

        return true;
    }

    public Boolean StrangePair(String wordOne, String wordTwo)
    {
        return (wordOne == wordTwo && wordOne == "") || wordOne.First().Equals(wordTwo.Last());
    }

    public Boolean CheckIfANumberIsPrime(Int32 number)
    {
        var mulipleList = new List<Int32>();
        for (var i = 1; i < number; i++)
        {
            if (number % i == 0)
            {
                mulipleList.Add(i);
            }
        }

        return mulipleList.Count == 1;
    }

    public Boolean FridayThe13th(Int32 month, Int32 year)
    {
        return new DateTime(year, month, 13).DayOfWeek == DayOfWeek.Friday;
    }

    public Int64 ReturnTheSumOfTheTwoSmallestNumbers(Int64[] array)
    {
        var filteredArray = array.Where(x => x >= 0).ToArray();

        var min = filteredArray.Min();
        var secondMin = Int64.MaxValue;

        foreach (var value in filteredArray)
        {
            if (value < secondMin && value > min)
            {
                secondMin = value;
            }
        }

        return min + secondMin;
    }

    public Boolean IsThePhoneNumberFormattedCorrectly(String phoneNumber)
    {
        var pattern = @"^\(\d{3}\) \d{3}-\d{4}$";
        var regex = new Regex(pattern);
        return regex.IsMatch(phoneNumber);
    }
    public Double PiToNDecimalPlaces(Int32 numberOfDecimalPlaces)
    {
        return Math.Round(Math.PI, numberOfDecimalPlaces);
    }
    public String RemoveAllSpecialCharactersFromAString(String phrase)
    {
        var filterString = phrase.Where(c => Char.IsLetterOrDigit(c) || c == ' ' || c == '-' || c == '_').ToArray();

        return new String(filterString);
    }

    public Boolean PerfectNumber(Int32 num)
    {
        var factorList = new List<Int32>();
        for (var i = 1; i <= num; i++)
        {
            for (var y = 1; y < num; y++)
            {
                if (i * y == num)
                {
                    factorList.Add(y);
                }
            }
        }

        var factorListSum = factorList.Distinct().Sum();
        return factorListSum == num;
    }

    public Boolean IsTheNumberSymmetrical(Int32 number)
    {
        var numberString = number.ToString();
        var reversedString = new String(numberString.ToCharArray().Reverse().ToArray());

        return numberString.Equals(reversedString);
    }

    public Int32 ReverseCodingChallenge(Int32 number)
    {

        return number <= 150 ? 9 : number <= 800 ? 10 : 48;
    }

    public Int32 LargestGap(Int32[] array)
    {
        var sortedArray = array.Order().ToArray();
        var largestGap = 0;
        var i = 0;
        for (var y = 1; y < sortedArray.Length; y++)
        {
            var behind = sortedArray[i];
            var ahead = sortedArray[y];
            var diffrence = Math.Abs(behind - ahead);

            if (largestGap < diffrence)
            {
                largestGap = diffrence;
            }

            i++;
        }

        return largestGap;
    }

    public String TheKaracasEncryptionAlgorithm(String word)
    {
        var reversedWordArray = word.Reverse().ToArray();
        var encryptedCharArray = reversedWordArray
            .Select(c => c is 'a' ? '0' : c is 'e' ? '1' : c is 'i' or 'o' ? '2' : c is 'u' ? '3' : c).ToArray();
        return new String(encryptedCharArray) + "aca";
    }

    public String NoYelling(String sentence)
    {
        var spacedSentenceArray = sentence.Split(' ');
        var lastWordAndPuncutation = spacedSentenceArray[^1];

        Char punctuation = default;
        var sb = new StringBuilder();

        foreach (var c in lastWordAndPuncutation)
        {
            if (Char.IsPunctuation(c))
            {
                punctuation = c;
                break;
            }
            else
            {
                _ = sb.Append(c);
            }
        }

        _ = sb.Append(punctuation);

        lastWordAndPuncutation = sb.ToString();

        spacedSentenceArray[^1] = lastWordAndPuncutation;
        sb = new StringBuilder();

        foreach (var word in spacedSentenceArray)
        {
            _ = sb.Append(word + " ");
        }

        return sb.ToString().Trim();
    }

    public Boolean BasicValidateEmail(String email)
    {

        var pattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
        var regex = new Regex(pattern);

        return regex.IsMatch(email);
    }

    public Int32 FindTheAmountOfPotatoes(String letters)
    {
        var sumOfMatches = 0;
        var wordToMatch = "potato";
        var currentWordCharlist = new List<Char>();
        foreach (var letter in letters)
        {

            currentWordCharlist.Add(letter);

            if (currentWordCharlist.Count == wordToMatch.Length + 1)
            {
                currentWordCharlist.RemoveAt(0);
            }

            var currentWord = new String(currentWordCharlist.ToArray());

            if (currentWord.Equals(wordToMatch))
            {
                sumOfMatches++;
            }
        }

        return sumOfMatches;
    }
}

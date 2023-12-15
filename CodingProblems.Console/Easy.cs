using System.Text;

namespace CodingProblems.Console;
public class Easy
{
    public String ConvertNumberToCorrespondingMonthName(Int32 monthNumber)
    {
        var months = new Dictionary<Int32, String>
        {
            { 1, "January" },
            { 2, "February" },
            { 3, "March" },
            { 4, "April" },
            { 5, "May" },
            { 6, "June" },
            { 7, "July" },
            { 8, "August" },
            { 9, "September" },
            { 10, "October" },
            { 11, "November" },
            { 12, "December" }
        };
        _ = months.TryGetValue(monthNumber, out var monthName);
        return monthName ?? "";
    }

    public Int32[] FindTheSmallestAndBiggestNumbers(Int32[] arr)
    {
        var min = Int32.MaxValue;
        var max = Int32.MinValue;

        foreach (var num in arr)
        {
            if (num < min)
            {
                min = num;
            }

            if (num > max)
            {
                max = num;
            }
        }

        return [min, max];
    }

    public Int32 AbsoluteSum(Int32[] arr)
    {
        var sum = 0;
        foreach (var num in arr)
        {
            sum += Math.Abs(num);
        }

        return sum;
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
        // Implemented assuming the words are the same length
        if (wordOne.Length != wordTwo.Length)
        {
            return -1;
        }

        if (wordOne.Equals(wordTwo))
        {
            return 0;
        }

        var sumOfDifferences = 0;

        for (var i = 0; i < wordOne.Length; i++)
        {
            sumOfDifferences += wordOne[i] == wordTwo[i] ? 0 : 1;
        }

        return sumOfDifferences;
    }

    public String NameShuffle(String phrase)
    {
        if (String.IsNullOrWhiteSpace(phrase))
        {
            throw new ArgumentException($"'{nameof(phrase)}' cannot be null or whitespace.", nameof(phrase));
        }

        var phraseSplit = phrase.Split(' ');

        var newPhrase = "";
        for (var i = phraseSplit.Length - 1; i >= 0; i--)
        {
            newPhrase += phraseSplit[i];
            newPhrase += " ";
        }

        newPhrase = newPhrase.Trim();

        return newPhrase;
    }

    public String SmallerStringNumber(String sNumOne, String sNumTwo)
    {
        var numOne = Int32.Parse(sNumOne);
        var numTwo = Int32.Parse(sNumTwo);

        if (numOne == numTwo)
        {
            return sNumOne;
        }
        else if (numOne < numTwo)
        {
            return sNumOne;
        }

        return sNumTwo;
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
        var vowelSum = 0;
        foreach (var letter in word)
        {
            switch (letter)
            {
                case 'a':
                    vowelSum++;
                    continue;
                case 'e':
                    vowelSum++;
                    continue;
                case 'i':
                    vowelSum++;
                    continue;
                case 'o':
                    vowelSum++;
                    continue;
                case 'u':
                    vowelSum++;
                    continue;
            }
        }

        return vowelSum;
    }

    public Int32[] SortNumbersInAscendingOrder(Int32[]? arr)
    {
        if (arr is null)
        {
            return [];
        }

        Array.Sort(arr);
        return arr;
    }

    public Boolean CheckIfAStringContainsOnlyIdenticalCharacters(String letters)
    {
        var firstLetter = letters[0];

        foreach (var letter in letters)
        {
            if (letter != firstLetter)
            {
                return false;
            }
        }

        return true;
    }

    public String H4ck3rSp34k(String word)
    {
        var finalString = new StringBuilder();

        foreach (var letter in word.ToCharArray())
        {
            var l = letter;

            if (letter == 'a')
            {
                l = '4';
            }

            if (letter == 'e')
            {
                l = '3';
            }

            if (letter == 'i')
            {
                l = '1';
            }

            if (letter == 'o')
            {
                l = '0';
            }

            if (letter == 's')
            {
                l = '5';
            }

            _ = finalString.Append(l);

        }

        return finalString.ToString();
    }
}

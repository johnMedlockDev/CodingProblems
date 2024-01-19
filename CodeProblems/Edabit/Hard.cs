namespace CodeProblems.Edabit;
public class Hard
{
    public String ReverseAndNot(Int32 number)
    {
        return new String(number.ToString().Reverse().ToArray()) + number.ToString();
    }

    public Int32[] ReturnExponentsOfPrimeFactors(int[] arr, int target)
    {
        int[] exponents = new int[arr.Length];

        for (int i = 0; i < arr.Length; i++)
        {
            int factor = arr[i];
            int exponent = 0;

            while (target % factor == 0)
            {
                target /= factor;
                exponent++;
            }

            exponents[i] = exponent;
        }

        return exponents;
    }

    public String Uncensor(String sentence, String letters)
    {
        var replacementChar = '*';
        var sb = new StringBuilder();
        var index = 0;

        foreach (var letter in sentence)
        {
            if (letter == replacementChar)
            {
                _ = sb.Append(letters[index]);
                index++;
            }
            else
            {
                _ = sb.Append(letter);
            }
        }

        return sb.ToString();
    }

    public String ImaginaryCodingInterview(Int32[] timeArray, Int32 timeLimit)
    {

        if (timeArray.Length is not 8 || timeLimit > 120)
        {
            return "disqualified";
        }

        var ve1 = timeArray[0];
        var ve2 = timeArray[1];

        if (ve1 > 5 || ve2 > 5)
        {
            return "disqualified";
        }

        var e1 = timeArray[2];
        var e2 = timeArray[3];

        if (e1 > 10 || e2 > 10)
        {
            return "disqualified";
        }

        var m1 = timeArray[4];
        var m2 = timeArray[5];

        if (m1 > 15 || m2 > 15)
        {
            return "disqualified";
        }

        var h1 = timeArray[6];
        var h2 = timeArray[7];

        return h1 > 20 || h2 > 20 ? "disqualified" : "qualified";
    }

    public Boolean SmoothSentences(String sentence)
    {
        var words = sentence.Split(' ');

        for (var i = 0; i < words.Length - 1; i++)
        {
            var before = words[i];
            var after = words[i + 1];

            if (!before[^1].Equals(after[0]))
            {
                return false;
            }
        }

        return true;
    }

    public Boolean ValidHexCode(String hexcode)
    {

        if (hexcode[0] != '#' || hexcode.Length != 7)
        {
            return false;
        }

        var validCharList = new List<Char>() { 'a', 'b', 'c', 'd', 'e', 'f', 'A', 'B', 'C', 'D', 'E', 'F', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        for (var i = 1; i < hexcode.Length; i++)
        {
            if (!validCharList.Contains(hexcode[i]))
            {
                return false;
            }
        }

        return true;
    }

    public Boolean ConsecutiveNumbers(Int32[] array)
    {
        var sortedArray = array.Order().ToArray();
        var previous = sortedArray[0];

        for (var i = 1; i < sortedArray.Length; i++)
        {
            var current = sortedArray[i];

            var currentNotEqualPreviousPlusOne = !(current == previous + 1);

            if (currentNotEqualPreviousPlusOne)
            {
                return false;
            }

            previous = current;
        }

        return true;
    }

    public Int32[] TrackTheRobot(String[] array)
    {
        var directionDict = new Dictionary<String, Int32>
        {
            { "right", 0 },
            { "up", 0 },
            { "left", 0 },
            { "down", 0 }
        };

        foreach (var strpPair in array)
        {
            var pairArray = strpPair.Split(' ');
            var direction = pairArray[0];
            var directionValue = pairArray[1];

            directionDict[direction] += Int32.Parse(directionValue);
        }

        var firstValue = directionDict["right"] - directionDict["left"];
        var secondValue = directionDict["up"] - directionDict["down"];

        return [firstValue, secondValue];
    }

    public String CupSwapping(String[] array)
    {
        var ballAddresses = new Boolean[] { false, true, false };

        foreach (var swap in array)
        {
            if (swap.Equals("AB"))
            {
                var currentFirst = ballAddresses[0];
                var currentSecond = ballAddresses[1];
                ballAddresses[0] = currentSecond;
                ballAddresses[1] = currentFirst;
            }

            if (swap.Equals("AC"))
            {
                var currentFirst = ballAddresses[0];
                var currentSecond = ballAddresses[2];
                ballAddresses[0] = currentSecond;
                ballAddresses[2] = currentFirst;
            }

            if (swap.Equals("BC"))
            {
                var currentFirst = ballAddresses[1];
                var currentSecond = ballAddresses[2];
                ballAddresses[1] = currentSecond;
                ballAddresses[2] = currentFirst;
            }

            if (swap.Equals("BA"))
            {
                var currentFirst = ballAddresses[1];
                var currentSecond = ballAddresses[0];
                ballAddresses[1] = currentSecond;
                ballAddresses[0] = currentFirst;
            }

            if (swap.Equals("CA"))
            {
                var currentFirst = ballAddresses[2];
                var currentSecond = ballAddresses[0];
                ballAddresses[2] = currentSecond;
                ballAddresses[0] = currentFirst;
            }

            if (swap.Equals("CB"))
            {
                var currentFirst = ballAddresses[2];
                var currentSecond = ballAddresses[1];
                ballAddresses[2] = currentSecond;
                ballAddresses[1] = currentFirst;
            }
        }

        return ballAddresses[0] ? "A" : ballAddresses[1] ? "B" : "C";
    }

    public Int32 NextPrime(Int32 number)
    {
        var currentNumber = number;
        while (true)
        {
            var mulipleList = new List<Int32>();
            for (var i = 1; i < currentNumber; i++)
            {
                if (currentNumber % i == 0)
                {
                    mulipleList.Add(i);
                }
            }

            if (mulipleList.Count == 1)
            {
                return currentNumber;
            }

            currentNumber++;
        }
    }

    public Int32 CountTheNumberOfDuplicateCharacters(String letters)
    {
        var letterCountDict = new Dictionary<Char, Int32>();
        foreach (var letter in letters)
        {
            if (!letterCountDict.ContainsKey(letter))
            {
                letterCountDict[letter] = 1;
            }
            else
            {
                letterCountDict[letter] += 1;
            }
        }

        var duplicateSum = 0;

        foreach (var keyValuePair in letterCountDict)
        {
            if (keyValuePair.Value > 1)
            {
                duplicateSum++;
            }
        }

        return duplicateSum;
    }

    public Boolean AlmostPalindrome(String characters)
    {
        var charactersReversed = new String(characters.ToCharArray().Reverse().ToArray());

        var differences = 0;
        for (var i = 0; i < characters.Length; i++)
        {
            var currentChar = characters[i];
            var currentReversedChar = charactersReversed[i];

            if (currentChar != currentReversedChar)
            {
                differences++;
            }
        }

        return differences == 2;
    }
    public String AWeekLater(String date)
    {
        var dateNumArray = date.Split('/');
        var day = Int32.Parse(dateNumArray[0]);
        var month = Int32.Parse(dateNumArray[1]);
        var year = Int32.Parse(dateNumArray[2]);
        var currentDate = new DateOnly(year, month, day);

        return currentDate.AddDays(7).ToString("dd/MM/yyyy");
    }

    public Boolean DoAllBigramsExist(String[] wordParts, String[] words)
    {

        var sb = new StringBuilder();
        words.ToList().ForEach(word => sb.Append(word));
        var arrayString = sb.ToString();

        foreach (var word in wordParts)
        {

            if (!arrayString.Contains(word))
            {
                return false;
            }
        }

        return true;
    }

    public String ReverseCodingChallenge(String charNumberPairs)
    {
        var charNumberDict = new Dictionary<Char, Int32>();

        var charNumberPairArray = charNumberPairs.ToArray();
        var currentChar = ' ';
        for (var i = 0; i < charNumberPairArray.Length; i++)
        {
            if (i == 0 || i % 2 == 0)
            {
                currentChar = charNumberPairArray[i];
                charNumberDict[currentChar] = 0;
            }
            else
            {
                charNumberDict[currentChar] = Int32.Parse(charNumberPairArray[i].ToString());
            }
        }

        var sb = new StringBuilder();
        foreach (var keyValuePair in charNumberDict)
        {
            var letter = keyValuePair.Key;
            var value = keyValuePair.Value;
            for (var i = 0; i < value; i++)
            {
                _ = sb.Append(letter);
            }
        }

        return sb.ToString();
    }

    public Int32 SockPairs(String letters)
    {
        var letterArray = letters.ToCharArray();
        var charNumberDict = new Dictionary<Char, Int32>();

        foreach (var letter in letterArray)
        {
            if (!charNumberDict.ContainsKey(letter))
            {
                charNumberDict[letter] = 1;
            }
            else
            {
                charNumberDict[letter] += 1;
            }
        }

        var sumOfPairs = 0.0;
        foreach (var keyValuePair in charNumberDict)
        {
            sumOfPairs += Math.Round(keyValuePair.Value / 2.0, 0, MidpointRounding.ToZero);
        }

        return (Int32) sumOfPairs;
    }
}


namespace CodeProblems.Edabit;
public class Hard
{
    public String ReverseAndNot(Int32 number)
    {
        return new String(number.ToString().Reverse().ToArray()) + number.ToString();
    }

    public Int32[] ReturnExponentsOfPrimeFactors(Int32[] array, Int32 number)
    {
        //todo
        //        ProductEqualTarget(new int[] { 2, 3, 5 }, 600) ➞ [3, 1, 2]
        //// Because 2^3*3^1*5^2 = 600

        //ProductEqualTarget(new int[] { 2, 3, 5 }, 720) ➞ [4, 2, 1]
        //// Because 2^4*3^2*5^1 = 720
        ///

        //var exponentList = new List<int>();
        //foreach (Int32 factor in array)
        //{
        //    var newPrimeFactor = number / factor; //300 2
        //    var newPrimeFactor = number / factor; //150 2
        //    var newPrimeFactor = number / factor; //75 2
        //    var newPrimeFactor = number / factor; //25 3
        //    var newPrimeFactor = number / factor; //5 5

        //}

        return [];
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
}

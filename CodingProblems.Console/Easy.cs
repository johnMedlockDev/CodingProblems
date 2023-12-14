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
}

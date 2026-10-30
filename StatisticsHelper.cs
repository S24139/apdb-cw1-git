public static class StatisticsHelper
{
    public static int CalculateSum(int[] numbers)
    {
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        return sum;
    }

    public static double CalculateAverage(int[] numbers)
    {
        int sum = CalculateSum(numbers);
        return (double)sum / numbers.Length;
    }

    public static int CalculateMax(int[] numbers)
    {
        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        return max;
    }
}
public class LoopFibonacci
{
    public static int CalculateFibonacciSum(int index)
    {
        int sum = 0;

        for (int i = 0; i < index; ++i)
        {
            sum += CalculateFibonacci(i);

        }

        return sum;
    }

    public static int CalculateFibonacci(int index)
    {
        if (index == 0) return 0;
        if (index == 1) return 1;

        int result = 0;
        int previous = 0;
        int currentValue = 0;

        for (int iterationIndex = 0; iterationIndex < index - 1; iterationIndex++)
        {
            result = previous + currentValue;

            previous = currentValue;
            currentValue = result;
        }

        return result;
    }
}
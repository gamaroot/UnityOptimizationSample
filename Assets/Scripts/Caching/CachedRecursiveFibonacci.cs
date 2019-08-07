public class CachedRecursiveFibonacci
{
    public static int CalculateFibonacciSum(int index)
    {
        int sum = 0;
        int result = -1;
        for (int iterationIndex = 0; iterationIndex < index; iterationIndex++)
        {
            result = CalculateRecursiveFibonacci(iterationIndex, result);
            sum += result;
        }

        return sum;
    }

    public static int CalculateFibonacci(int index)
    {
        if (index == 0)
        {
            return 0;
        }
        else if (index == 1)
        {
            return 1;
        }

        int b = CalculateRecursiveFibonacci(index - 2);
        int a = CalculateRecursiveFibonacci(index - 1, b);

        return a + b;
    }

    private static int CalculateRecursiveFibonacci(int index, int cachedPreviousValue = -1)
    {
        if (index == 0)
        {
            return 0;
        }
        else if (index == 1)
        {
            return 1;
        }
        else
        {
            int previousValue = cachedPreviousValue == -1 ? CalculateFibonacci(index - 1) : cachedPreviousValue;

            return previousValue + CalculateFibonacci(index - 2);
        }
    }
}
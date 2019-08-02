public class CachedRecursiveFibonacci
{
    public static int CalculateFibonacciSum(int index)
    {
        int sum = 0;
        int result = -1;
        for (int iterationIndex = 0; iterationIndex < index; iterationIndex++)
        {
            result = CalculateFibonacciRec(iterationIndex, result);
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

        var b = CalculateFibonacciRec(index - 2,-1);
        var a =  CalculateFibonacciRec(index-1,b);

        
        return a+b;
    }

    private static int CalculateFibonacciRec(int index, int cached = -1)
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
            int previous = cached == -1 ? CalculateFibonacci(index - 1) : cached;

            return previous + CalculateFibonacci(index - 2);
        }
    }
}
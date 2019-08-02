public class RecursiveFibonacci
{
    public static int CalculateFibonacciSum(int index)
    {
        int sum = 0;
        for (int iterationIndex = 0; iterationIndex < index; iterationIndex++)
        {
            sum += CalculateFibonacci(iterationIndex);
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
        else
        {
            return CalculateFibonacci(index - 1) + CalculateFibonacci(index - 2);
        }
    }
}
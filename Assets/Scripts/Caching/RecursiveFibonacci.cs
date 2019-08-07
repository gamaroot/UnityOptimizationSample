using System.Threading;
using System.Threading.Tasks;

public class RecursiveFibonacci
{
    public static int CalculateFibonacciSum(int fibonacciIndex)
    {
        int sum = 0;
        Parallel.For(0, fibonacciIndex, (iterationIndex) =>
        {
            int toAdd = CalculateFibonacci(iterationIndex);
            Interlocked.Add(ref sum, toAdd);
        });

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
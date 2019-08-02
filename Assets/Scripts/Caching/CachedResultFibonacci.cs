public class CachedResultFibonacci
{
    private static int _cachedPreviousFibonacciResult = 0;
    private static int _cachedCurrentFibonacciResult = 0;
    private static int _cachedFibonacciResultIndex = 0;

    public static int CalculateFibonacci(int index)
    {
        if (index == 0) return 0;
        if (index == 1) return 1;

        if (index == _cachedFibonacciResultIndex)
            return _cachedCurrentFibonacciResult;

        int result = 0;
        int previousValue = 0;
        int currentValue = 1;
        
        if (_cachedFibonacciResultIndex != 0 &&      // Is there a cached result?
            index > _cachedFibonacciResultIndex / 2) // Is it worth to start from cached index?
        {
            previousValue = _cachedPreviousFibonacciResult;
            currentValue = _cachedCurrentFibonacciResult;

            if (index > _cachedFibonacciResultIndex) // Needs to increment the cached result
            {
                for (int iterationIndex = 0; iterationIndex < index - _cachedFibonacciResultIndex; iterationIndex++)
                {
                    result = previousValue + currentValue;

                    previousValue = currentValue;
                    currentValue = result;
                }
            }
        }
        else // Execute the normal operation
        {
            for (int iterationIndex = 0; iterationIndex < (index - 1); iterationIndex++)
            {
                result = previousValue + currentValue;

                previousValue = currentValue;
                currentValue = result;
            }
        }

        _cachedFibonacciResultIndex = index;
        _cachedPreviousFibonacciResult = previousValue;
        _cachedCurrentFibonacciResult = currentValue;
        return result;
    }
}
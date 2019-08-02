using UnityEngine;
using System.Diagnostics;
using System.Numerics;
using TMPro;

public class CachingSample : MonoBehaviour
{
    [SerializeField] private TMP_InputField fibonacciIndexInputField;

    [Header("Cached Result Fibonacci")]
    [SerializeField] private TextMeshProUGUI cachedResultFibonacciTimeElapsedText;
    [SerializeField] private TextMeshProUGUI cachedResultFibonacciResultText;

    [Header("Loop Fibonacci")]
    [SerializeField] private TextMeshProUGUI loopFibonacciTimeElapsedText;
    [SerializeField] private TextMeshProUGUI loopFibonacciResultText;

    [Header("Recursive Fibonacci")]
    [SerializeField] private TextMeshProUGUI recursiveFibonacciTimeElapsedText;
    [SerializeField] private TextMeshProUGUI recursiveFibonacciResultText;

    public void OnExecuteButtonClick()
    {
        string inputValue = this.fibonacciIndexInputField.text;
        if (!string.IsNullOrWhiteSpace(inputValue))
        {
            this.TestFibonacciSum(int.Parse(inputValue));
        }
    }

    public void OnExecuteRandomlyButtonClick()
    {
        int randomIndex = Random.Range(0, 99999);
        this.fibonacciIndexInputField.text = randomIndex.ToString();
        this.TestFibonacciSum(randomIndex);
    }

    private void TestFibonacciSum(int index)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        int firstResult = RecursiveFibonacci.CalculateFibonacciSum(index);
        stopwatch.Stop();

        this.cachedResultFibonacciResultText.text = firstResult.ToString();
        this.cachedResultFibonacciTimeElapsedText.text = string.Format("Time Elapsed: {0}ms", stopwatch.Elapsed.TotalMilliseconds);

        stopwatch.Reset();

        stopwatch.Start();
        int secondResult = CachedRecursiveFibonacci.CalculateFibonacciSum(index);
        stopwatch.Stop();

        this.loopFibonacciResultText.text = secondResult.ToString();
        this.loopFibonacciTimeElapsedText.text = string.Format("Time Elapsed: {0}ms", stopwatch.Elapsed.TotalMilliseconds);

        stopwatch.Reset();

        stopwatch.Start();
        int thirdResult = LoopFibonacci.CalculateFibonacciSum(index);
        stopwatch.Stop();

        this.recursiveFibonacciResultText.text = thirdResult.ToString();
        this.recursiveFibonacciTimeElapsedText.text = string.Format("Time Elapsed: {0}ms", stopwatch.Elapsed.TotalMilliseconds);
    }

    private void TestFibonacci(int index)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        int firstResult = RecursiveFibonacci.CalculateFibonacci(index);
        stopwatch.Stop();

        this.cachedResultFibonacciResultText.text = firstResult.ToString();
        this.cachedResultFibonacciTimeElapsedText.text = string.Format("Time Elapsed: {0}ms", stopwatch.Elapsed.TotalMilliseconds);

        stopwatch.Reset();

        stopwatch.Start();
        int secondResult = CachedRecursiveFibonacci.CalculateFibonacci(index);
        stopwatch.Stop();

        this.loopFibonacciResultText.text = secondResult.ToString();
        this.loopFibonacciTimeElapsedText.text = string.Format("Time Elapsed: {0}ms", stopwatch.Elapsed.TotalMilliseconds);

        stopwatch.Reset();

        stopwatch.Start();
        int thirdResult = LoopFibonacci.CalculateFibonacci(index);
        stopwatch.Stop();

        this.recursiveFibonacciResultText.text = thirdResult.ToString();
        this.recursiveFibonacciTimeElapsedText.text = string.Format("Time Elapsed: {0}ms", stopwatch.Elapsed.TotalMilliseconds);
    }
}
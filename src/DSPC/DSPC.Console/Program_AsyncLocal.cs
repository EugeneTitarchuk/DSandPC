using System.Diagnostics;
using System.Threading;

public class Program
{
    static AsyncLocal<decimal?> _asyncLocal = new AsyncLocal<decimal?>();

    public static void Main()
    {
        var stopwatch = Stopwatch.StartNew();

        _asyncLocal.Value = 200;



        var options = new ParallelOptions { MaxDegreeOfParallelism = 1 };
        Parallel.For(0, 100, options, /* async */ i => 
        {
            var currentValue = _asyncLocal.Value;

            _asyncLocal.Value = Compute(i);
        });

        var currentValue = _asyncLocal.Value;

        Console.WriteLine($"It took: {stopwatch.ElapsedMilliseconds}ms to run");
    }

    static Random random = new Random();
    static decimal Compute(int value)
    {
        var randomMilliseconds = random.Next(10, 50);
        var end = DateTime.Now + TimeSpan.FromMilliseconds(randomMilliseconds);

        // just use CPU for some period of time
        while (end > DateTime.Now) { }

        return value + 0.5m;
    }
}

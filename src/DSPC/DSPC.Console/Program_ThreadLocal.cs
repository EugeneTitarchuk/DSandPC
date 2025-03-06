//using System.Diagnostics;

//public class Program
//{
//    static ThreadLocal<decimal> _threadLocal = new ThreadLocal<decimal>();

//    public static void Main()
//    {
//        var stopwatch = Stopwatch.StartNew();

//        var options = new ParallelOptions { MaxDegreeOfParallelism = 2 };
//        Parallel.For(0, 100, options, i =>
//        {
//            var currentValue = _threadLocal.Value;

//            _threadLocal.Value = Compute(i);
//        });

//        Console.WriteLine($"It took: {stopwatch.ElapsedMilliseconds}ms to run");
//    }

//    static Random random = new Random();
//    static decimal Compute(int value)
//    {
//        var randomMilliseconds = random.Next(10, 50);
//        var end = DateTime.Now + TimeSpan.FromMilliseconds(randomMilliseconds);

//        // just use CPU for some period of time
//        while (end > DateTime.Now) { }

//        return value + 0.5m;
//    }
//}

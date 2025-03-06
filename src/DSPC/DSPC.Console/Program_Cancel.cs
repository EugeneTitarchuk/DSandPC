//using System.Diagnostics;

//public class Program
//{
//    public static void Main()
//    {
//        var stopwatch = new Stopwatch();

//        stopwatch.Start();

//        var cancellationTokenSource = new CancellationTokenSource();
//        cancellationTokenSource.CancelAfter(2000);

//        var parallelOptions = new ParallelOptions
//        {
//            CancellationToken = cancellationTokenSource.Token,
//            MaxDegreeOfParallelism = 1
//        };

//        int total = 0;
//        Parallel.For(0, 100, parallelOptions, (i) =>
//        {
//            Interlocked.Add(ref total, (int)Compute(i));
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

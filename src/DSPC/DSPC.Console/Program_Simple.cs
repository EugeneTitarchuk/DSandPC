//using System.Diagnostics;

//public class Program
//{
//    public static void Main()
//    {
//        var stopwatch = new Stopwatch();

//        stopwatch.Start();

//        decimal total = 0;

//        for (int i = 0; i < 100; i++)
//        {
//            total += Compute(i);
//        }

//        Console.WriteLine(total);

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

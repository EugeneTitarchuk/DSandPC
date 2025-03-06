//using System.Diagnostics;

//public class Program
//{
//    static object lock1 = new object();
//    static object lock2 = new object();
//    public static void Main()
//    {
//        var stopwatch = new Stopwatch();

//        stopwatch.Start();


//        var t1 = Task.Run(() =>
//        {
//            lock (lock1)
//            {
//                Thread.Sleep(1);
//                lock (lock2)
//                {
//                    Console.WriteLine("Hello!");
//                }
//            }
//        });

//        var t2 = Task.Run(() =>
//        {
//            lock (lock2)
//            {
//                Thread.Sleep(1);
//                lock (lock1)
//                {
//                    Console.WriteLine("World");
//                }
//            }
//        });

//        Task.WaitAll(t1, t2);

//        Console.WriteLine($"It took: {stopwatch.ElapsedMilliseconds}ms to run");
//    }
//}

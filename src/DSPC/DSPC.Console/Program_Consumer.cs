using System.Collections.Concurrent;

class Program
{
    static ConcurrentQueue<int> queue = new ConcurrentQueue<int>();
    static SemaphoreSlim semaphore = new SemaphoreSlim(0);

    static async Task Producer()
    {
        for (int i = 1; i <= 10; i++)
        {
            queue.Enqueue(i);
            Console.WriteLine($"Produced: {i}");
            semaphore.Release(); // signal consumer

            await Task.Delay(500); // do something important
        }
    }

    static async Task Consumer()
    {
        while (true)
        {
            await semaphore.WaitAsync(); // wait for new items in queue

            if (queue.TryDequeue(out int item))
            {
                Console.WriteLine($"Consumed: {item}");
                await Task.Delay(1000); // process items
            }
        }
    }

    static async Task Main()
    {
        var producerTask = Producer();
        var consumerTask = Consumer();

        await Task.WhenAll(producerTask, consumerTask);
    }
}
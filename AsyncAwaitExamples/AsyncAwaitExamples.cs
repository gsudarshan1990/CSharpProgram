using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwaitExamples
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("=== Async/Await Examples ===\n");

            // Example 1: Basic async/await
            await BasicAsyncExample();

            // Example 2: Sequential vs Parallel execution
            await SequentialVsParallelExample();

            // Example 3: Error handling
            await ErrorHandlingExample();

            // Example 4: Cancellation
            await CancellationExample();

            // Example 5: File I/O
            await FileIOExample();

            // Example 6: Async enumerable
            await AsyncEnumerableExample();

            Console.WriteLine("All examples completed!");
        }

        // Example 1: Basic async/await
        static async Task BasicAsyncExample()
        {
            Console.WriteLine("1. Basic Async/Await:");
            string result = await ProcessDataAsync("Hello World", 500);
            Console.WriteLine($"Result: {result}\n");
        }

        static async Task<string> ProcessDataAsync(string data, int delay)
        {
            await Task.Delay(delay);
            return $"Processed: {data}";
        }

        // Example 2: Sequential vs Parallel execution
        static async Task SequentialVsParallelExample()
        {
            Console.WriteLine("2. Sequential vs Parallel:");

            // Sequential execution
            var start = DateTime.Now;
            await Task.Delay(300);
            await Task.Delay(300);
            await Task.Delay(300);
            var sequential = DateTime.Now - start;

            // Parallel execution
            start = DateTime.Now;
            await Task.WhenAll(Task.Delay(300), Task.Delay(300), Task.Delay(300));
            var parallel = DateTime.Now - start;

            Console.WriteLine($"Sequential: {sequential.TotalMilliseconds:F0}ms");
            Console.WriteLine($"Parallel: {parallel.TotalMilliseconds:F0}ms\n");
        }

        // Example 3: Error handling
        static async Task ErrorHandlingExample()
        {
            Console.WriteLine("3. Error Handling:");
            
            try
            {
                await TaskThatThrowsAsync();
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Caught: {ex.Message}");
            }

            // Multiple tasks with errors
            try
            {
                await Task.WhenAll(
                    TaskThatThrowsAsync(),
                    Task.Delay(100),
                    TaskThatThrowsAsync()
                );
            }
            catch (Exception ex)
            {
                Console.WriteLine($"WhenAll caught: {ex.Message}");
            }
            Console.WriteLine();
        }

        static async Task TaskThatThrowsAsync()
        {
            await Task.Delay(50);
            throw new InvalidOperationException("Async operation failed");
        }

        // Example 4: Cancellation
        static async Task CancellationExample()
        {
            Console.WriteLine("4. Cancellation Token:");
            
            using var cts = new CancellationTokenSource();
            cts.CancelAfter(1500); // Cancel after 1.5 seconds

            try
            {
                await LongRunningTaskAsync(cts.Token);
                Console.WriteLine("Task completed");
            }
            catch (OperationCanceledException)
            {
                Console.WriteLine("Task was cancelled");
            }
            Console.WriteLine();
        }

        static async Task LongRunningTaskAsync(CancellationToken token)
        {
            for (int i = 1; i <= 5; i++)
            {
                token.ThrowIfCancellationRequested();
                Console.WriteLine($"Step {i}/5");
                await Task.Delay(500, token);
            }
        }

        // Example 5: File I/O
        static async Task FileIOExample()
        {
            Console.WriteLine("5. Async File I/O:");
            
            string fileName = "async_test.txt";
            string content = "Hello from async file operations!";

            try
            {
                await File.WriteAllTextAsync(fileName, content);
                string readContent = await File.ReadAllTextAsync(fileName);
                Console.WriteLine($"File content: {readContent}");
                
                if (File.Exists(fileName))
                    File.Delete(fileName);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"File error: {ex.Message}");
            }
            Console.WriteLine();
        }

        // Example 6: Async enumerable
        static async Task AsyncEnumerableExample()
        {
            Console.WriteLine("6. Async Enumerable:");
            
            await foreach (var number in GenerateNumbersAsync())
            {
                Console.WriteLine($"Generated: {number}");
            }
            Console.WriteLine();
        }

        static async IAsyncEnumerable<int> GenerateNumbersAsync()
        {
            for (int i = 1; i <= 3; i++)
            {
                await Task.Delay(200);
                yield return i * i;
            }
        }
    }

    
}

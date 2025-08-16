// Utility class with common async patterns
    public static class AsyncUtilities
    {
        // Retry with exponential backoff
        public static async Task<T> RetryAsync<T>(Func<Task<T>> operation, int maxRetries = 3)
        {
            for (int i = 0; i < maxRetries; i++)
            {
                try
                {
                    return await operation();
                }
                catch when (i < maxRetries - 1)
                {
                    await Task.Delay(TimeSpan.FromMilliseconds(Math.Pow(2, i) * 100));
                }
            }
            return await operation();
        }

        // Task with timeout
        public static async Task<T> WithTimeoutAsync<T>(Task<T> task, TimeSpan timeout)
        {
            using var cts = new CancellationTokenSource(timeout);
            var timeoutTask = Task.Delay(timeout, cts.Token);
            
            if (await Task.WhenAny(task, timeoutTask) == timeoutTask)
                throw new TimeoutException($"Operation timed out after {timeout.TotalSeconds}s");
            
            return await task;
        }
    }

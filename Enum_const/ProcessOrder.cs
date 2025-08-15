using System;

namespace EnumExamples
{
    // Basic enum for order status
    public enum OrderStatus
    {
        Pending,
        Processing,
        Shipped,
        Delivered,
        Cancelled
    }

    // Enum with explicit values for priority levels
    public enum Priority
    {
        Low = 1,
        Medium = 2,
        High = 3,
        Critical = 4
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Simple C# Enum Examples ===\n");

            // Using OrderStatus enum
            Console.WriteLine("1. Order Status Example:");
            OrderStatus currentOrder = OrderStatus.Processing;
            Console.WriteLine($"Current order status: {currentOrder}");
            Console.WriteLine($"Status as integer: {(int)currentOrder}");
            
            // Switch statement with OrderStatus
            ProcessOrder(currentOrder);
            ProcessOrder(OrderStatus.Delivered);
            Console.WriteLine();

            // Using Priority enum
            Console.WriteLine("2. Priority Level Example:");
            Priority taskPriority = Priority.High;
            Console.WriteLine($"Task priority: {taskPriority}");
            Console.WriteLine($"Priority value: {(int)taskPriority}");
            
            // Compare priority levels
            Priority urgentTask = Priority.Critical;
            if (urgentTask > taskPriority)
            {
                Console.WriteLine($"{urgentTask} has higher priority than {taskPriority}");
            }
            Console.WriteLine();

            // Parsing enum from string
            Console.WriteLine("3. Parsing Enum from String:");
            if (Enum.TryParse<OrderStatus>("Shipped", out OrderStatus parsedStatus))
            {
                Console.WriteLine($"Successfully parsed: {parsedStatus}");
            }
            
            if (Enum.TryParse<Priority>("Medium", out Priority parsedPriority))
            {
                Console.WriteLine($"Successfully parsed: {parsedPriority} (Value: {(int)parsedPriority})");
            }
        }

        static void ProcessOrder(OrderStatus status)
        {
            string message = status switch
            {
                OrderStatus.Pending => "Order is waiting to be processed",
                OrderStatus.Processing => "Order is being prepared",
                OrderStatus.Shipped => "Order is on its way",
                OrderStatus.Delivered => "Order has been delivered",
                OrderStatus.Cancelled => "Order has been cancelled",
                _ => "Unknown order status"
            };
            
            Console.WriteLine($"  {status}: {message}");
        }
    }
}

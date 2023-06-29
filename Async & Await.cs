using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsynchAwaitApp
{
    class Program
    {
        static string processConnectToDatabase = "(Connecting to database)";
        static string processGetDataFromDatabase = "(Getting data from database)";

        static void Main(string[] args)
        {
            Console.WriteLine("First we are inside the main method.");
            RunProcess(1, 1_000_000);

            var dbTask = ConnectToDatabaseProcessAndGetData();
            Console.WriteLine("Back to the main method");

            // Checking the status of the task
            if (dbTask.Status == TaskStatus.RanToCompletion)
            {
                Console.WriteLine($"Process {processConnectToDatabase} is completed");
            }
            else
            {
                Console.WriteLine($"Process {processConnectToDatabase} is NOT completed.");
            }

            RunProcess(2, 1_000_000);
            RunProcess(3, 1_000_000);

            Console.ReadLine();
        }

        public static async Task ConnectToDatabaseProcessAndGetData()
        {
            Console.WriteLine($"\nControl is with process {processConnectToDatabase}.");
            Console.WriteLine($"Process {processConnectToDatabase} has started.");
            Console.WriteLine($"Process {processConnectToDatabase} is Running.");

            // Waiting for an asynchronous task to complete
            await Task.Run(() =>
            {
                Console.WriteLine("Start executing process in the await section.");
                Thread.Sleep(10000);
                Console.WriteLine("\nProcess in the await section is complete.");
            });

            Console.WriteLine($"\nProcess {processConnectToDatabase} is complete!");
            Console.WriteLine($"Control is with process {processConnectToDatabase} again");

            // Looping and simulating data retrieval
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Getting data..... " + i);
            }

            Console.WriteLine($"Process {processConnectToDatabase} is complete!");
        }

        private static void RunProcess(int processNumber, int processLoopCondition)
        {
            Console.WriteLine($"\nControl is with process {processNumber}.");
            Console.WriteLine($"Process ({processNumber}) has started.");
            Console.WriteLine($"Process ({processNumber}) is Running.");

            // Looping without performing any specific operation
            for (int i = 1; i <= processLoopCondition; i++)
            {
                // No specific code here, just looping
            }

            Console.WriteLine($"Process ({processNumber}) is complete!");
            Console.WriteLine("\nControl is back to the main method...");
        }
    }
}

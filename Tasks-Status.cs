using System;
using System.Threading.Tasks;
using System.Timers;
class Program
{
    static System.Timers.Timer timer;
    static Task task;

    static void Main(string[] args)
    {
        task = new Task(() =>
        {
            for (int i = 0; i < 500; i++)
            {
                Console.WriteLine(i);

            }
        });
        task.Start();

        timer = new System.Timers.Timer();
        timer.Elapsed += CheckTheTask;

        timer.Interval = 100;
        timer.Enabled = true;

        Console.ReadLine();

    }

    private static void CheckTheTask(object sender,ElapsedEventArgs e)
    {
        if(task.Status == TaskStatus.Running)
        {
            Console.WriteLine("Task is runing.....");
        }
        else if(task.Status == TaskStatus.RanToCompletion)
        {
            Console.WriteLine("Completed");
            timer.Enabled = false;
        }    
    }
}



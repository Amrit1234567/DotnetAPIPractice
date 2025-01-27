﻿namespace Test
{
    
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Task firstTask = new Task(()=>{
                Thread.Sleep(100);
                Console.WriteLine("Task 1");     
            });
            firstTask.Start();

            Task secondTask = ConsoleAfterDelayAsync("Task 2", 150);
            Task thirdTask = ConsoleAfterDelayAsync("Task 3", 50);

            Console.WriteLine("After the task was created");
            await firstTask;
        }

        static void ConsoleAfterDelay(string text, int delayTime){
            Thread.Sleep(delayTime);
            Console.WriteLine(text);
        }
        static async Task ConsoleAfterDelayAsync(string text, int delayTime){
            await Task.Delay(delayTime);
            Console.WriteLine(text);
        }

            
    }
}

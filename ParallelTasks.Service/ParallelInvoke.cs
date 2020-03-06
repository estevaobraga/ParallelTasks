using System.Collections.Generic;
using System.Threading.Tasks;
using ParallelTasks.Domain;

namespace ParallelTasks.Service
{
    public static class ParallelInvoke
    {
        public static async Task InvokeParallelFor(int loopCounter)
        {
            Parallel.For(0, loopCounter, (int index) =>
            {
                Calculator.CalculateInterest();
            });
        }

        public static async Task InvokeListTasks(int loopCounter)
        {
            List<Task> tasks = new List<Task>();

            for (int i = 0; i < loopCounter; i++)
            {
                Task task = new Task(() => Calculator.CalculateInterest());
                task.Start();
                tasks.Add(task);
            }

            Task.WaitAll(tasks.ToArray());
        }

        public static void InvokeSyncLoop(int loopCounter)
        {
            for (int i = 0; i < loopCounter; i++)
            {
                var asdf = Calculator.CalculateInterest();
            }
        }
    }
}
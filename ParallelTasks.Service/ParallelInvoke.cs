using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelTasks.Service
{
    public static class ParallelInvoke
    {
        private static int waitingTime = 1000;

        public static async Task InvokeParallelFor(int loopCounter)
        {
            await Task.Factory.StartNew(() =>
            {
                Parallel.For(0, loopCounter, async (int index) =>
                {
                    await Task.Factory.StartNew(() => { Thread.Sleep(waitingTime); });
                });
            });
        }

        public static async Task InvokeListTasks(int loopCounter)
        {
            List<Task> tasks = new List<Task>();

            for (int i = 0; i < loopCounter; i++)
            {
                Task task = Task.Factory.StartNew(() => { Thread.Sleep(waitingTime); });
                tasks.Add(task);
            }

            await Task.WhenAll(tasks);
        }

        public static async Task InvokeSyncLoop(int loopCounter)
        {
            await Task.Factory.StartNew(() =>
            {
                for (int i = 0; i < loopCounter; i++)
                {
                    Thread.Sleep(waitingTime);
                }
            });
        }
    }
}
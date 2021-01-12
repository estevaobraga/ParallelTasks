using System.Threading.Tasks;
using ParallelTasks.Service;
using Xunit;

namespace ParallelTasks.Unit.Test
{
    public class ParallelInvokeTest
    {
        [Theory]
        [InlineData(10)]
        public async Task InvokeParallelTasksValidTimeExecutionToPrallelForInteration(int loopCounter)
        {
            // Act
            await ParallelInvoke.InvokeParallelFor(loopCounter);
            
            // Assert
            
        }

        [Theory]
        [InlineData(10)]
        public async Task InvokeListTasksValidTimeExecutionToParallelInteration(int loopCounter)
        {
            // Act
            await ParallelInvoke.InvokeListTasks(loopCounter);
            
            // Assert
            
        }
        
        [Theory]
        [InlineData(10)]
        public async Task InvokeSyncLoopValidTimeExecutionToSyncInteration(int loopCounter)
        {
            // Act
            await ParallelInvoke.InvokeSyncLoop(loopCounter);
            
            // Assert
            
        }
    }
}
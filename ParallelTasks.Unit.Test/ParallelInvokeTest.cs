using System.Threading.Tasks;
using ParallelTasks.Service;
using Xunit;

namespace ParallelTasks.Unit.Test
{
    public class ParallelInvokeTest
    {
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(50)]
        public async Task InvokeParallelTasksValidTimeExecutionForPrallelInteration(int loopCounter)
        {
            // Act
            await ParallelInvoke.InvokeParallelFor(loopCounter);
            
            // Assert
            
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(50)]
        public async Task InvokeListTasksValidTimeExecutionForParallelInteration(int loopCounter)
        {
            // Act
            await ParallelInvoke.InvokeListTasks(loopCounter);
            
            // Assert
            
        }
        
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(50)]
        public void InvokeSyncLoopValidTimeExecutionForSyncInteration(int loopCounter)
        {
            // Act
            ParallelInvoke.InvokeSyncLoop(loopCounter);
            
            // Assert
            
        }
    }
}
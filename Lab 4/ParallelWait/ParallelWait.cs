using System.Threading;
using Pool_Thread;
using NLog;

namespace ParallelWait
{
    static class ParallelWait
    {
        public delegate void TaskDelegate();
        public const int threadCount = 10;
        public static TaskQueue _taskQueue = new TaskQueue(threadCount);

        private const int maxSizeBuffer = 20;
        private const int maxTimerSeconds = 100;
        public static LogBuffer log = new LogBuffer(maxSizeBuffer, maxTimerSeconds);
        //private static Logger _log = LogManager.GetCurrentClassLogger();

        public static void WaitAll(TaskDelegate[] taskDelegates)
        {
            //дожидается, пока выполнятся все делегаты
            int numberOfTasks = taskDelegates.Length;
            int amountDone = 0;
            ManualResetEvent signal = new ManualResetEvent(false); //несигнальное состояние 

            foreach (var func in taskDelegates)
            {
                amountDone++;
                _taskQueue.EnqueueTask(() => func());
                log.Add("Executing task " + amountDone);
                //_log.Info("Executing task " + amountDone);
                TaskExecuted(ref numberOfTasks, signal);
            }
            //блокировка потоков и выполнение их до завешения
            log.Add("Waiting for " + taskDelegates.Length + " tasks");
            //_log.Info("Waiting for " + taskDelegates.Length + " tasks");
            signal.WaitOne();
            log.Add("Tasks executed");
            //_log.Info("Tasks executed");
        }

        private static void TaskExecuted(ref int numberOfTasks, ManualResetEvent signal)
        {
            if (Interlocked.Decrement(ref numberOfTasks) == 0)
            {
                //освобождение потоков
                _taskQueue.DisposePool();
                signal.Set();
            }
        }
    }
}

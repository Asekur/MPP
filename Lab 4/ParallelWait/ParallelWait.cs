using System.Threading;
using Pool_Thread;
using NLog;

namespace ParallelWait
{
    class ParallelWait
    {
        public static TaskQueue _taskQueue;
        public delegate void TaskDelegate();
        public static int threadCount = 10;

        public static LogBuffer log = new LogBuffer(4, 100);
        //private static Logger _log = LogManager.GetCurrentClassLogger();

        public ParallelWait()
        {
            _taskQueue = new TaskQueue(threadCount);
        }

        public ParallelWait(TaskQueue queue)
        {
            _taskQueue = queue;
            threadCount = queue.Count();
        }

        public void WaitAll(TaskDelegate[] taskDelegates)
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

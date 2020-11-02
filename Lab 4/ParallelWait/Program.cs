using NLog;

namespace ParallelWait
{
    class Program
    {
        const int maxIndex = 20;
        public delegate void TaskDelegate();
        //private static Logger _log = LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {
            ParallelWait parallelWait = new ParallelWait();

            //от -2^31 до 2^31-1
            int counter = 1;
            ParallelWait.TaskDelegate[] delegates = new ParallelWait.TaskDelegate[maxIndex];

            for (int i = 0; i < maxIndex; i++)
            {
                delegates[i] = (() => counter *= 2);
            }

            parallelWait.WaitAll(delegates);
            ParallelWait.log.Add("Counter: " + counter);
            //_log.Info("Counter: " + counter);
            ParallelWait.log.Dispose();
        }
    }
}

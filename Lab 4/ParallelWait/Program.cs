using NLog;

namespace ParallelWait
{
    class Program
    {
        const int maxIndex = 20;
        public delegate void TaskDelegate();

        static void Main(string[] args)
        {
            ParallelWait parallelWait = new ParallelWait();

            int counter = 0;
            ParallelWait.TaskDelegate[] delegates = new ParallelWait.TaskDelegate[maxIndex];

            for (int i = 0; i < maxIndex; i++)
            {
                delegates[i] = (() => counter++);
            }

            parallelWait.WaitAll(delegates);
            ParallelWait.log.Add("Counter: " + counter);
            //_log.Info("Counter: " + counter);
            ParallelWait.log.Dispose();
        }
    }
}

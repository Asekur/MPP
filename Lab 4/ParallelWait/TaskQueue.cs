using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Threading;

namespace Pool_Thread
{
    class TaskQueue
    {
        private static Thread[] _threadPool;
        //announce the delegate
        public delegate void TaskDelegate();
        private static ConcurrentQueue<TaskDelegate> _tasksQueue = new ConcurrentQueue<TaskDelegate>();
        private static bool _isRun = true;

        //create new thread pool
        public TaskQueue(int threadsCount)
        {
            _threadPool = new Thread[threadsCount];
            for (int i = 0; i < threadsCount; i++)
            {
                _threadPool[i] = new Thread(NewThreadTask);
                _threadPool[i].Name = "Thread " + i.ToString();
                Console.WriteLine(_threadPool[i].Name + " starts");
                _threadPool[i].Start();
            }
        }

        //task for each thread 
        static void NewThreadTask()
        {
            while (_isRun)
            {
                TaskDelegate taskDelegate;
                Thread.Sleep(500);
                if (_tasksQueue.TryDequeue(out taskDelegate))
                { 
                    //getting out from queue
                    Console.WriteLine(Thread.CurrentThread.Name + " is doing task");
                    taskDelegate();
                }
            }

            //free thread
            Console.WriteLine(Thread.CurrentThread.Name + " die");
            Thread.CurrentThread.Interrupt();
        }

        //delegates to queue and their performance 
        public void EnqueueTask(TaskDelegate task)
        {
            _tasksQueue.Enqueue(task);
        }

        public void DisposePool()
        {
            while (true)
            {
                Thread.Sleep(500);
                if (_tasksQueue.Count == 0) break;
            }
            Console.WriteLine();
            _isRun = false;
        }

        public int Count()
        {
            int count = _threadPool.Length;
            foreach (var obj in _threadPool)
            {
                if (obj.ThreadState == ThreadState.Stopped)
                {
                    count--;
                }
            }
            return count;
        }
    }
}

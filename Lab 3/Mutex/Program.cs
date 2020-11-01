using System.Threading;
using System.Text;
using System.IO;
using System;

namespace Mutex
{
    class Program
    {
        //для мини-пула потоков
        private const int threadCount = 4;
        public static Thread[] ThreadQueue = new Thread[threadCount];
        private static bool _isActive = true;
        private static readonly Mutex _mutex = new Mutex();

        //для записи в файл
        const string filePath = @"C:\Users\Angelina\Desktop\fortesting.txt";
        const string text = "angelina";

        static void Main(string[] args)
        {
            //MiniPool();
            //DisposePool();
            _mutex.LockMutex();
            WriteData();
            _mutex.UnlockMutex();
        }

        private static void WriteData()
        {
            FileStream fs = File.Open(filePath, FileMode.Create, FileAccess.ReadWrite, FileShare.None);
            StreamWriter sw = new StreamWriter(fs, Encoding.Default);
            OSHandle osHandle = new OSHandle(fs.Handle);

            osHandle.Dispose();
            try
            {
                sw.WriteLine(text);
                sw.Close();
                fs.Close();
                Console.WriteLine("Successful writing");
            }
            catch
            {
                Console.WriteLine("Cannot write to file");
            }
            Console.ReadKey();
        }

        private static void MiniPool()
        {
            for (int i = 0; i < ThreadQueue.Length; i++)
            {
                ThreadQueue[i] = new Thread(new ThreadStart(Task));
                ThreadQueue[i].Name = "Thread #" + i;
                ThreadQueue[i].Start();
            }
        }

        private static void Task()
        {
            while (_isActive)
            {
                _mutex.LockMutex();
                Thread.Sleep(200);
                _mutex.UnlockMutex();
            }
        }

        private static void DisposePool()
        {
            //dispose
            Thread.Sleep(1000);
            _mutex.LockMutex();
            _isActive = false;
            _mutex.UnlockMutex();
        }
    }
}

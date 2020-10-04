using System;
using System.IO;

namespace Pool_Thread
{
    class Program
    {
        static void Main(string[] args)
        {
            string source, dest;

            Console.Write("Source: ");
            source = Console.ReadLine();
            Console.Write("Dest: ");
            dest = Console.ReadLine();
            //add task of copying files

            if (!Directory.Exists(source) || !Directory.Exists(dest))
            {
                Console.WriteLine("Not existing directory");
                Console.ReadKey();
                return;
            }

            //create pool thread
            const int amountThreads = 100;
            TaskQueue newThreads = new TaskQueue(amountThreads);
            Console.WriteLine();

            //while non-copyied files in source exists
            foreach (var file in FileCopy.GetAmountInSource(source))
            {
                Directory.CreateDirectory(dest);
                newThreads.EnqueueTask(() => FileCopy.StartCopy(source, dest, file));
            }
            newThreads.DisposePool();

            Console.ReadKey();
            if (newThreads.Count() == 0)
            {
                Console.WriteLine("\nAll tasks have been completed. Total: " + FileCopy.GetResultAmount());
            }
            Console.ReadKey();
        }
    }
}

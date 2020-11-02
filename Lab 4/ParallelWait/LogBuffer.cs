using System;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Threading;
using System.Text;

namespace ParallelWait
{
    class LogBuffer : IDisposable
    {
        private readonly int _maxBufferSize;
        private Timer _timer;
        private readonly List<string> _buffer = new List<string>();
        private readonly object _object = new object();

        public LogBuffer(int maxBufferSize, int interval)
        {
            _maxBufferSize = maxBufferSize;
            NewFolder();
            StartTimer(interval);
        }

        public void NewFolder()
        {
            try
            {
                Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "\\log");
            }
            catch
            {
                Console.WriteLine("Cannot create folder");
            }
        }

        private void StartTimer(int interval)
        {
            _timer = new Timer(
                e => Flush(), //callback
                null, //информация, используемая методом ответного вызова
                TimeSpan.FromSeconds(interval), //время до начала вызова метода
                TimeSpan.FromSeconds(interval)); //время между вызовами метода
        }

        public async void Add(string item)
        {
            lock (_object)
            {
                _buffer.Add("[INFO] " + DateTime.Now.ToString() + " " + item);
            }
            if (_buffer.Count > _maxBufferSize)
            {
                await Task.Run(() => Flush());
            }
        }

        private void Flush()
        {
            lock (_object)
            {
                FileStream fs = File.Open(AppDomain.CurrentDomain.BaseDirectory + "\\log\\log.txt", FileMode.Append);
                StreamWriter sw = new StreamWriter(fs, Encoding.Default);
                foreach (var log in _buffer)
                {
                    sw.WriteLine(log);
                }
                _buffer.Clear();
                sw.Close();
                fs.Close();
            }
        }

        public void Dispose()
        {
            Flush();
            _timer.Dispose();
        }

    }
}

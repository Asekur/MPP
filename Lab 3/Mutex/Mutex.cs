using System;
using System.Threading;
using NLog;

namespace Mutex
{
    class Mutex : IMutex
    {
        private static Logger _log = LogManager.GetCurrentClassLogger();
        private const int sleepTime = 200;
        private const int _unlockVariable = 0; //free

        private int _lockVariable = 0; //busy
        private int BusyThread
        {
            //идентификатор управляемого потока
            get { return Thread.CurrentThread.ManagedThreadId; }
        }

        public Mutex()
        {
        }

        public void LockMutex()
        {
            //вернет исходное значение _lockVariable
            while (Interlocked.CompareExchange(ref _lockVariable, BusyThread, _unlockVariable) != _unlockVariable)
            {
                //попытки захватить мьютекс (неудачная)
                _log.Info("Thread " + Thread.CurrentThread.Name + " is waiting when mutex will be unlocked");
                Thread.Sleep(sleepTime);
            }

            _log.Info("Mutex has been blocked by " + Thread.CurrentThread.Name + " thread");
        }

        public void UnlockMutex()
        {
            if (Interlocked.CompareExchange(ref _lockVariable, _unlockVariable, BusyThread) != BusyThread)
            {
                _log.Warn("No chance unlock mutex by " + Thread.CurrentThread.Name + " thread");
                throw new Exception("Unable to unlock mutex by " + Thread.CurrentThread.Name + " thread");
            }
            else
            {
                //можно освобождать мьютекс
                _log.Info("Mutex has been unlocked by " + Thread.CurrentThread.Name + " thread");
            }
            Thread.Sleep(100);
        }
    }
}

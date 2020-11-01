using System;
using System.Runtime.InteropServices;
using NLog;

namespace Mutex
{
    class OSHandle : IDisposable
    {
        //установить и получить дескриптор операционной системы
        public IntPtr Handle { get; set; }
        private static Logger _log = LogManager.GetCurrentClassLogger();

        //из библиотеки получаем функцию по аннулированию дескриптора объекта
        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        private static extern bool CloseHandle(IntPtr handle);

        public OSHandle()
        {
            _log.Info("Descriptor is create");
        }

        public OSHandle(IntPtr osId)
        {
            this.Handle = osId;
            _log.Info("Descriptor is create");
        }

        public void Dispose()
        {
            //принудительное освобождение дескриптора
            if (this.Handle != IntPtr.Zero)
            {
                if (CloseHandle(this.Handle))
                {
                    _log.Info("Descriptor is disposed");
                }
                else
                {
                    _log.Info("Descriptor isn't disposed");
                }
            }
            else
            {
                _log.Info("Descriptor isn't disposed");
            }
        }

        public void Finalize()
        {
            //автоматическое освобождение дескриптора
            _log.Info("Descriptor is finalized");
            Dispose();
        }
    }
}

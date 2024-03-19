using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace v1
{
    class Timer
    {
        private readonly Action _callback;
        private readonly int _interval;
        private bool _isRunning;
        private System.Threading.Thread _thread;

        public Timer(Action callback, int interval)
        {
            _callback = callback;
            _interval = interval;
        }
        public void Start()
        {
            if (_isRunning) return;
            _isRunning = true;
            _thread = new System.Threading.Thread(Run);
            _thread.Start();
        }
        public void Stop()
        {
            _isRunning = false;
            _thread?.Join();
        }
        private void Run()
        {
            while (_isRunning)
            {
                _callback();
                System.Threading.Thread.Sleep(_interval * 1000);
            }
        }
    }
}

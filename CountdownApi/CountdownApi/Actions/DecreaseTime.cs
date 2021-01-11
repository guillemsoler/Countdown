using CountdownApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Timers;

namespace CountdownApi.Actions
{
    public class DecreaseTime
    {
        private Timer _substractTimer;
        private static CountdownModel _counter;
        public void StartSubstaction(CountdownModel counter)
        {
            _counter = counter;
            _substractTimer = new Timer(1000);
            _substractTimer.Elapsed += SubstractTime;
            _substractTimer.AutoReset = true;
            _substractTimer.Enabled = true;
        }

        private static void SubstractTime(Object source, ElapsedEventArgs e)
        {
            if (_counter.RemainingTime > 0)
            {
                _counter.RemainingTime = _counter.RemainingTime -= 1;
            }
        }
    }
}

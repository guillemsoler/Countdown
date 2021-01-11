using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CountdownApi.Utils
{
    public class Timer
    {
        public static void CalculateNumber(int number, ref int time)
        {
            if (time < 0)
            {
                time = number;
            }
            else
            {
                time = time - 1;
            }
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CountdownWebAPP.Models
{
    public class CountdownModel
    {
        public long Id { get; set; }
        public int RemainingTime { get; set; }

        public CountdownModel(int remainingTime)
        {
            RemainingTime = remainingTime;
        }
    }
}

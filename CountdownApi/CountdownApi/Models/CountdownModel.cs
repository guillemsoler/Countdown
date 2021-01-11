using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CountdownApi.Models
{
    public class CountdownModel
    {
        public long Id { get; set; }
        public int RemainingTime { get; set; }
    }
}

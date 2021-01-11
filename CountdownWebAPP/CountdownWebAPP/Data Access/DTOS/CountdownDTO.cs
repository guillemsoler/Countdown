using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CountdownWebAPP.Data_Access.DTOS
{
    public class CountdownDTO
    {
        public long Id { get; set; }
        public int RemainingTime { get; set; }
    }
}

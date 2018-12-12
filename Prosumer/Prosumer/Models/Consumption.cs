using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProsumerInfo.Models
{
    public class Consumption
    {
        public long id { set; get; }

        private string KWH { set; get; } 
        private string consumption_time { set; get; }

        public long _ProsumerID;
        public Prosumer _prosumer;

        public Consumption(float kwh, DateTime timestamp)
        {
            KWH = kwh.ToString();
            consumption_time = timestamp.ToShortTimeString();
        }
       
    }
}

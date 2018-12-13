using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProsumerInfo.Models
{
    public class Consumption
    {
        private string kwh { set; get; } 
        private string consumption_time { set; get; }

        public long _prosumerID;
        public Prosumer _prosumer;

        public long id { set; get; }

        public Consumption(float kwh, DateTime timestamp)
        {
            KWH = kwh.ToString();
            Consumption_time = timestamp.ToShortTimeString();
        }

        public Consumption()
        {
        }

        public string KWH {
            set { kwh = value; }
            get { return kwh; }
        }
        public string Consumption_time {
            set { consumption_time = value; }
            get { return consumption_time; }
        }
    }
}

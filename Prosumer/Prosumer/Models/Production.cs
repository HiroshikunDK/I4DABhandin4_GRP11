using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProsumerInfo.Models
{
    public class Production
    {
        
        private string KWH { set; get; }
        private string ProductionTime { set; get; }

        public long _prosumerID;
        public Prosumer _prosumer;
        public long id { set; get; }

        public Production(float kwh, DateTime timestamp)
        {
            KWH = kwh.ToString();
            ProductionTime = timestamp.ToShortTimeString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProsumerInfo.Models
{
    public class Production
    {
        
        private string kwh { set; get; }
        private string productionTime { set; get; }

        public long _prosumerID;
        public Prosumer _prosumer;
        public long id { set; get; }

        public Production(float kwh, DateTime timestamp)
        {
            KWH = kwh.ToString();
            ProductionTime = timestamp.ToShortTimeString();
        }

        public Production()
        {}


        public string KWH {
            set { kwh = value; }
            get { return kwh; }
        }

        public string ProductionTime {
            set { productionTime = value; }
            get { return productionTime; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ProsumerInfo.Models
{
    public class Prosumer
    {

        public long id { set; get; }
        private string prosumerType { set; get; }
        private string x10_ID { set; get; }

        public Consumption consumption;
        public Production production;

        public long _pcID;
        public ProsumerConsumption _pc;

        public Prosumer(string type, string X10ID)
        {
            prosumerType = type;
            X10_ID = X10ID;
        }

        public Prosumer() { }

        public string ProsumerType { 
            set{ prosumerType = value; }
            get { return prosumerType; }
        }
        public string X10_ID {
            set { x10_ID = value; }
            get { return x10_ID; }
        }

    }
}

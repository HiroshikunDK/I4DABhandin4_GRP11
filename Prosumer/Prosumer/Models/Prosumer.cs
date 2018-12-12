using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ProsumerInfo.Models
{
    public class Prosumer
    {

        private long id { set; get; }
        private string prosumerType { set; get; }
        private string X10_ID { set; get; }

        public Consumption consumption;
        public Production production;

        public long _pcID;
        public ProsumerConsumption _pc;

        public Prosumer(string type, string X10ID)
        {
            prosumerType = type;
            X10_ID = X10ID;
        }


    }
}

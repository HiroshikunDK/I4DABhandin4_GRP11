using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProsumerInfo.Models
{
    public class ProsumerConsumption
    {
        public long id { set; get; }

        private string PC_Timestamp { set; get; }
        private string ProsumerBalance { set; get; }

        public long prosumerID;
        public Prosumer _prosumer;

        public ProsumerConsumption(DateTime timestamp, float balance)
        {
            PC_Timestamp = timestamp.ToShortTimeString();
            ProsumerBalance = balance.ToString();
        }


    }
}

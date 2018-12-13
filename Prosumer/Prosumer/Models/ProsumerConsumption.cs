using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProsumerInfo.Models
{
    public class ProsumerConsumption
    {
        public long id { set; get; }

        private string pc_Timestamp { set; get; }
        private string prosumerBalance { set; get; }

        public long prosumerID;
        public Prosumer _prosumer;

        #region Constructors

        public ProsumerConsumption(DateTime timestamp, float balance)
        {
            PC_Timestamp = timestamp.ToShortTimeString();
            ProsumerBalance = balance.ToString();
        }
        public ProsumerConsumption()
        {
        }

        #endregion

        #region Properties 
       public string PC_Timestamp
       {
            get { return pc_Timestamp; }
            set { pc_Timestamp = value; }
       }
        public string ProsumerBalance
        {
            set {prosumerBalance = value; }
            get { return prosumerBalance; }
        }
        #endregion

    }
}

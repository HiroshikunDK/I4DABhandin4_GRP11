using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartgridInfo.Models
{
    public class Smartmeter
    {
        private long id { set; get; }
        private string smID { set; get; }


        public VillageSmartGrid _villageSmartGrid { set; get; }
        public long vsgID { set; get; }

        public Request _request { set; get; }
        public long _reqID { set; get; }

        public long ID
        {
            set { id = value; }
            get { return id; }
        }
        public string SMID
        {
            set { smID = value; }
            get { return smID; }
        }
    }
}

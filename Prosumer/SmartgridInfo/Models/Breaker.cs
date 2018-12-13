using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartgridInfo.Models
{
    public class Breaker
    {
        private long id { set; get; }
        private string  breakerID { set; get; }
        private string  connector1{set; get;}
        private string connector2 { set; get; }

        public long _vsgID { set; get; }
        public VillageSmartGrid _villagesmartgrid { set; get; }

        public long ID
        {
            set { id = value; }
            get { return id; }
        }
        public string BreakID
        {
            set { breakerID = value; }
            get { return breakerID; }
        }

        public string Connector1
        {
            set { connector1= value; }
            get { return connector1; }
        }
        public string Connector2
        {
            set { connector2 = value; }
            get { return connector2; }
        }
    }
}

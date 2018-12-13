using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartgridInfo.Models
{
    public class Request
    {
        private long id { set; get; }
        private string _powerBalance { set; get; }
        private string _timestamp { set; get; }

        public long _smID { set; get; }
        public Smartmeter _smartmeter { set; get; }

        public long ID
        {
            set { id = value; }
            get { return id; }
        }
        public string PowerBalance
        {
            set { _powerBalance = value; }
            get { return _powerBalance; }
        }
        public string TimeStamp
        {
            set { _timestamp = value; }
            get { return _timestamp; }
        }
    }
}

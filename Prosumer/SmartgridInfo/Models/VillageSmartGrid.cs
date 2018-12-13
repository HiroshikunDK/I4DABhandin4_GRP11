using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartgridInfo.Models
{
    public class VillageSmartGrid
    {
        private long id { set; get; }
        private string _name { set; get; }

        public long _ppID { set; get; }
        public Smartmeter _smartmeter { set; get; }
        public Breaker _breaker { set; get; }
        public long _breakerID { set; get; }

        public VillageSmartGrid(string name)
        {
            Name = name;
        }

        public VillageSmartGrid()
        {
        }

        public long ID {
            set { id = value; }
            get { return id; } }
        private string Name {
            set { _name = value; }
            get { return _name; } }
    }
}

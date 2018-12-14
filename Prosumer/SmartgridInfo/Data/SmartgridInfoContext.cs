using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SmartgridInfo.Models;

namespace SmartgridInfo.Models
{
    public class SmartgridInfoContext : DbContext
    {
        public SmartgridInfoContext (DbContextOptions<SmartgridInfoContext> options)
            : base(options)
        {
        }

        public DbSet<SmartgridInfo.Models.VillageSmartGrid> VillageSmartGrid { get; set; }

        public DbSet<SmartgridInfo.Models.Smartmeter> Smartmeter { get; set; }
    }
}

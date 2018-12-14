using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProsumerInfo.Models
{
    public class ProsumerInfoContext : DbContext
    {
        public ProsumerInfoContext (DbContextOptions<ProsumerInfoContext> options)
            : base(options)
        {
        }

        public DbSet<ProsumerInfo.Models.ProsumerConsumption> ProsumerConsumption { get; set; }
        public DbSet<ProsumerInfo.Models.Prosumer> Prosumer { get; set; }
        public DbSet<ProsumerInfo.Models.Production> Production { get; set; }
        public DbSet<ProsumerInfo.Models.Consumption> Consumption { get; set; }
    }
}

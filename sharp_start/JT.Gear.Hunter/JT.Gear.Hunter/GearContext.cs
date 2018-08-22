using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File.Cutter
{
    public class GearContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet <GearItem> GearItems { get; set; }
        public DbSet <ItemList> ItemLists { get; set; }
        public DbSet <Trip> Trips { get; set; }

    }
}

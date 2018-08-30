﻿using Microsoft.EntityFrameworkCore;

namespace GearMaiden.Models
{
    public class GearContext : DbContext
    {
        public GearContext(DbContextOptions<GearContext> options)
            : base(options)
        { }

        public DbSet<Category> Categories { get; set; }
        public DbSet <GearItem> GearItems { get; set; }
        public DbSet <ItemList> ItemLists { get; set; }
        public DbSet <Trip> Trips { get; set; }

    }
}
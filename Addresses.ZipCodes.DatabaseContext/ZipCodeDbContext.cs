// Copyright © Christopher Dorst. All rights reserved.
// Licensed under the GNU General Public License, Version 3.0. See the LICENSE document in the repository root for license information.

using Addresses.States.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace Addresses.ZipCodes.DatabaseContext
{
    /// <summary>EntityFrameworkCore database context for ZipCode entities</summary>
    public class ZipCodeDbContext : StateDbContext
    {
        /// <summary>Constructs ZipCodeDbContext EntityFrameworkCore database context using given options</summary>
        public ZipCodeDbContext(DbContextOptions options) : base(options)
        {
        }

        /// <summary>Contains set of ZipCode entities</summary>
        public DbSet<ZipCode> ZipCodes { get; set; }

        /// <summary>Configures EntityFramework database creation - adds unique index to model</summary>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ZipCode>().HasIndex(new ZipCode().GetUniqueIndex()).IsUnique();
        }
    }
}

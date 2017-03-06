using MerchantDAL.DbEntities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerchantDAL
{
    public class MerchantDbContext : DbContext
    {
        public DbSet<Merchant> Merchant { get; set; }
        public DbSet<Address> Address { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

        public MerchantDbContext(string connectionString) : base(connectionString)
        {

        }
    }
}

using System.Data.Entity;
using Elementi.DataLayer.Models;

namespace Elementi.DataLayer
{
    public class ElementiContext : DbContext
    {
        public ElementiContext() : base("ElementiDB")
        {

        }
        public DbSet<ElementC> ElementiC { get; set; }
        public DbSet<ElementP> ElementiP { get; set; }
        public DbSet<Pretraga> Pretrage { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}

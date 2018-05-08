namespace BizDataLibrary.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BizModel : DbContext
    {
        public BizModel()
            : base("name=BizModel")
        {
        }

        public virtual DbSet<Procurement> Procurement { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<SalesMan> SalesMan { get; set; }
        public virtual DbSet<Selling> Selling { get; set; }
        public virtual DbSet<SellingSource> SellingSource { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}

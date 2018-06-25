namespace CarDB.DAL.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Cars : DbContext
    {
        public Cars()
            : base("name=Cars")
        {
        }

        public virtual DbSet<newEquipment> newEquipment { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}

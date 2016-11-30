namespace Domain
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DBEntity : DbContext
    {
        public DBEntity()
            : base("name=DBEntity")
        {
        }

        public virtual DbSet<SYS_USER> SYS_USER { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
    }
}

namespace foodie
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model : DbContext
    {
        public Model()
            : base("name=food")
        {
        }

        public virtual DbSet<recipes> recipes { get; set; }
        public virtual DbSet<regions2> regions2 { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<recipes>()
                .Property(e => e.instructions)
                .IsUnicode(false);

            modelBuilder.Entity<recipes>()
                .Property(e => e.timeNeeded)
                .HasPrecision(5, 2);

            modelBuilder.Entity<recipes>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<recipes>()
                .Property(e => e.photo)
                .IsUnicode(false);

            modelBuilder.Entity<regions2>()
                .HasMany(e => e.recipes)
                .WithOptional(e => e.regions2)
                .HasForeignKey(e => e.IDfrom);
        }
    }
}

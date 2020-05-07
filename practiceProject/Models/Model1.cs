namespace practiceProject.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<userlist> userlists { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<userlist>()
                .Property(e => e.user_Name)
                .IsUnicode(false);

            modelBuilder.Entity<userlist>()
                .Property(e => e.user_Password)
                .IsUnicode(false);

            modelBuilder.Entity<userlist>()
                .Property(e => e.gender)
                .IsUnicode(false);

            modelBuilder.Entity<userlist>()
                .Property(e => e.birth_Time)
                .IsUnicode(false);

            modelBuilder.Entity<userlist>()
                .Property(e => e.email)
                .IsUnicode(false);
        }
    }
}

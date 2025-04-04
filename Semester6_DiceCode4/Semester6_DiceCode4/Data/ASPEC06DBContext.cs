using Microsoft.EntityFrameworkCore;
using Semester6_DiceCode4.Models;

namespace Semester6_DiceCode4.Data
{
    public class ASPEC06DBContext : DbContext
    {
        public ASPEC06DBContext(DbContextOptions<ASPEC06DBContext> options) : base(options) { }

        public DbSet<Student> Studenten { get; set; }
        public DbSet<Docent> Docenten { get; set; }
        public DbSet<Vak> Vakken { get; set; }
        public DbSet<Toets> Toetsen { get; set; }
        public DbSet<StudentVak> StudentVakken { get; set; }
        public DbSet<CijferWijziging> CijferWijzigingen { get; set; }  


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentVak>()
                .HasKey(sv => new { sv.StudentId, sv.VakId });

            modelBuilder.Entity<StudentVak>()
                .HasOne(sv => sv.Student)
                .WithMany(s => s.StudentVakken)
                .HasForeignKey(sv => sv.StudentId);

            modelBuilder.Entity<StudentVak>()
                .HasOne(sv => sv.Vak)
                .WithMany(v => v.StudentVakken)
                .HasForeignKey(sv => sv.VakId);
        }
    }
}

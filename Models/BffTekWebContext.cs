using Microsoft.EntityFrameworkCore;

namespace Final_Project.Models
{
    public class BffTekWebContext : DbContext
    {
         public BffTekWebContext (DbContextOptions<BffTekWebContext> options)
            : base(options)
        {
        }
        
        public DbSet<Member> Members { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjInfo> ProjInfo { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            

            modelBuilder.Entity<Member>().ToTable("Member");
            modelBuilder.Entity<Client>().ToTable("Client");
            modelBuilder.Entity<Project>().ToTable("Project");
        
        //joins
           modelBuilder.Entity<ProjInfo>()
            .HasKey(pr => new { pr.ProjID, pr.ParticipantID});

            modelBuilder.Entity<ProjInfo>()
            .HasOne(pr => pr.Project)
            .WithMany(p => p.Partcipants)
            .HasForeignKey(pr => pr.ProjID);

            modelBuilder.Entity<ProjInfo>()
            .HasOne(pr => pr.Participant)
            .WithMany(pp => pp.Projects)
            .HasForeignKey(pr => pr.ParticipantID);
            }
        }
    }
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    using Microsoft.EntityFrameworkCore;

    public class InderDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Rate> Rates { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<Convo> Convos { get; set; }
        public DbSet<Message> Messages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // User-Rate Relationship
            modelBuilder.Entity<Rate>()
                .HasOne(r => r.FromUser)
                .WithMany(u => u.RatesFromUser)
                .HasForeignKey(r => r.FromUserId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Rate>()
                .HasOne(r => r.ToUser)
                .WithMany(u => u.RatesToUser)
                .HasForeignKey(r => r.ToUserId)
                .OnDelete(DeleteBehavior.Restrict);

            // User-Match Relationship
            modelBuilder.Entity<Match>()
                .HasOne(m => m.FirstUser)
                .WithMany(u => u.MatchesAsFirstUser)
                .HasForeignKey(m => m.FirstUserId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Match>()
                .HasOne(m => m.SecondUser)
                .WithMany(u => u.MatchesAsSecondUser)
                .HasForeignKey(m => m.SecondUserId)
                .OnDelete(DeleteBehavior.Restrict);

            // Match-Convo Relationship
            modelBuilder.Entity<Convo>()
                .HasOne(c => c.Match)
                .WithOne(m => m.Convo)
                .HasForeignKey<Convo>(c => c.MatchID)
                .OnDelete(DeleteBehavior.Cascade);

            // Convo-Message Relationship
            modelBuilder.Entity<Message>()
                .HasOne(m => m.Convo)
                .WithMany(c => c.Messages)
                .HasForeignKey(m => m.ConvoID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Message>()
                .HasOne(m => m.FromUser)
                .WithMany()
                .HasForeignKey(m => m.FromUserId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }

}

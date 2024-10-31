using System;
using System.Text.RegularExpressions;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.DependencyInjection;

[assembly: FunctionsStartup(typeof(DataBase.Startup))]

namespace DataBase
{


    public class InderDbContext : DbContext
    {
        public InderDbContext(DbContextOptions<InderDbContext> options) : base(options)
        {

        }

        public DbSet<UserModel> Users { get; set; }
        public DbSet<RateModel> Rates { get; set; }
        public DbSet<MatchModel> Matches { get; set; }
        public DbSet<ConvoModel> Convos { get; set; }
        public DbSet<Message> Messages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // User-Rate Relationship
            modelBuilder.Entity<RateModel>()
                .HasOne(r => r.FromUser)
                .WithMany(u => u.RatesFromUser)
                .HasForeignKey(r => r.FromUserId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<RateModel>()
                .HasOne(r => r.ToUser)
                .WithMany(u => u.RatesToUser)
                .HasForeignKey(r => r.ToUserId)
                .OnDelete(DeleteBehavior.Restrict);

            // User-Match Relationship
            modelBuilder.Entity<MatchModel>()
                .HasOne(m => m.FirstUser)
                .WithMany(u => u.MatchesAsFirstUser)
                .HasForeignKey(m => m.FirstUserId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<MatchModel>()
                .HasOne(m => m.SecondUser)
                .WithMany(u => u.MatchesAsSecondUser)
                .HasForeignKey(m => m.SecondUserId)
                .OnDelete(DeleteBehavior.Restrict);

            // Match-Convo Relationship
            modelBuilder.Entity<ConvoModel>()
                .HasOne(c => c.Match)
                .WithOne(m => m.Convo)
                .HasForeignKey<ConvoModel>(c => c.MatchID)
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
    public class InderContextFactory : IDesignTimeDbContextFactory<InderDbContext>
    {
        public InderDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<InderDbContext>();
            optionsBuilder.UseSqlServer(Environment.GetEnvironmentVariable("connectionString"));

            return new InderDbContext(optionsBuilder.Options);
        }
    }

    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            string SqlConnection = Environment.GetEnvironmentVariable("connectionString");
            builder.Services.AddDbContext<InderDbContext>(
                options => options.UseSqlServer(SqlConnection));
        }
    }
}
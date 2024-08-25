using System.Configuration;
using Microsoft.EntityFrameworkCore;
using MossadAgentsApi.Models;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace MossadAgentsApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        //constractor
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<MossadAgentsApi.Models.Agent> Agents { get; set; } = default!;
        public DbSet<MossadAgentsApi.Models.Target> Targets { get; set; } = default!;
        public DbSet<MossadAgentsApi.Models.Mission> Missions { get; set; } = default!;
        
    }
}
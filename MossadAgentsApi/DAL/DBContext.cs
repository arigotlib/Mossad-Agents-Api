using Microsoft.EntityFrameworkCore;
using MossadAgentsApi.Models;
using static System.Net.Mime.MediaTypeNames;

namespace MossadAgentsApi.DAL
{
    public class DBContext : DbContext
    {
        //public DBContext(string connectionString) : base(GetOptions(connectionString))
        //{
        //    Database.EnsureCreated();
        //    if (Agents.Count() == 0)
        //    {
        //        Seed();
        //    }
        //}
        //private void Seed()
        //{
        //    Agent agent = new Agent();
        //    {
        //        photo_url = "jhjkcs";
        //        nickname = agent.Nickname;

        //    };
        //    Agents.Add(agent);
        //    SaveChanges();
        //}
        //private static DbContextOptions GetOptions(string connectionString)
        //{
        //    return SqlServerDbContextOptionsExtensions.UseSqlServer(new DbContextOptionsBuilder(), connectionString).Options;
        //}
        //public DbSet<Agent> Agents { get; set; }

    }
}

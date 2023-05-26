using Microsoft.EntityFrameworkCore;
using System;

namespace Demo1.DAL
{
    public class DemoContext:DbContext
    {
        public DemoContext(DbContextOptions<DemoContext> options):base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Ads> Ads { get; set; }
        public DbSet<News> News { get; set; }
    }
}

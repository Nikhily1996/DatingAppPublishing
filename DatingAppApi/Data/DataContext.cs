using DatingAppApi.Models;
using Microsoft.EntityFrameworkCore;
namespace DatingAppApi.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {
        }
        public DbSet<Value> Values { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Photo> Photos { get; set; }
        //public DbSet<Like> Likes { get; set; }
        public DbSet<Message> Messages { get; set; }
    }
}
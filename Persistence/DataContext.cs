using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DbSet<User> users { get; set; }
        public DbSet<Thread> threads { get; set; }
        public DbSet<Reply> posts { get; set; }

        public DataContext(DbContextOptions options) : base(options) {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<User>().HasData(
                new User { username = "Name -1", userId = -1 },
                new User { username = "Name -2", userId = -2 },
                new User { username = "Name -3", userId = -3 }

            );

            modelBuilder.Entity<Thread>().HasData(
                new Thread { posterId = -1, threadId = -1, threadTitle = "Thread -1", threadContent = "Thread Content -1" },
                new Thread { posterId = -2, threadId = -2, threadTitle = "Thread -2", threadContent = "Thread Content -2" },
                new Thread { posterId = -3, threadId = -3, threadTitle = "Thread -3", threadContent = "Thread Content -3" }

            );

            modelBuilder.Entity<Reply>().HasData(
                new Reply { posterId = -1, replyId = -1, replyContent = "Reply -1" },
                new Reply { posterId = -2, replyId = -2, replyContent = "Reply -2" },
                new Reply { posterId = -3, replyId = -3, replyContent = "Reply -3" }

            );

        }

    }

}
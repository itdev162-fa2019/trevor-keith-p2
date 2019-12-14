using System.Collections.Generic;
using System.Linq;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static void SeedData(DataContext context) {
            if(!context.Threads.Any()) {
                var Users = new List<User> {
                    new User { username = "Name -1", userId = -1 },
                    new User { username = "Name -2", userId = -2 },
                    new User { username = "Name -3", userId = -3 }

                };

                var Threads = new List<Thread> {
                    new Thread { posterId = -1, threadId = -1, threadTitle = "Thread -1", threadContent = "Thread Content -1" },
                    new Thread { posterId = -2, threadId = -2, threadTitle = "Thread -2", threadContent = "Thread Content -2" },
                    new Thread { posterId = -3, threadId = -3, threadTitle = "Thread -3", threadContent = "Thread Content -3" }

                };

                var Replies = new List<Reply> {
                    new Reply { posterId = -1, replyId = -1, replyContent = "Reply -1" },
                    new Reply { posterId = -2, replyId = -2, replyContent = "Reply -2" },
                    new Reply { posterId = -3, replyId = -3, replyContent = "Reply -3" }

                };

            }

            context.Users.AddRange(Users);
            context.Threads.AddRange(Threads);
            context.Replies.AddRange(Replies);
            context.SaveChanges();

        }

    }

}
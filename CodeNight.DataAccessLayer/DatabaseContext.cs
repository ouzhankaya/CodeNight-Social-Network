using CodeNight.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeNight.DataAccessLayer
{
   public class DatabaseContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Followers> Followers { get; set; }
        public DbSet<FollowRequest> FollowRequests { get; set; }
       
        public DbSet<Comments> Comments { get; set; }
        public DbSet<Liked> Likes { get; set; }
        public DbSet<Share> Shares { get; set; }
        public DbSet<Notifications> Notifications { get; set; }

        public DatabaseContext()
        {
            Database.SetInitializer(new MyInitializer());
        }
    }
}

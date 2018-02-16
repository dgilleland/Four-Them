using FourThem.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourThem.DAL
{
    internal class ForumDbContext : DbContext
    {
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Discussion> Discussions { get; set; }
        public DbSet<Reply> Replies { get; set; }
    }
}

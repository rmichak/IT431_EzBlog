using Blog.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Blog.DAL
{
    public class BlogDataContext:DbContext
    {
        public BlogDataContext() : base("BlogDataContext")
        {
            Database.SetInitializer(new BlogDBInitializer());
        }

        public DbSet<Post> Posts { get; set; }

    }
}
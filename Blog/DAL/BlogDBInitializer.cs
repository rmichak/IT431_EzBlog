using Blog.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Blog.DAL
{
    public class BlogDBInitializer: DropCreateDatabaseIfModelChanges<BlogDataContext>
    {
        protected override void Seed(BlogDataContext context)
        {
            IList<Post> defaultPosts = new List<Post>();

            defaultPosts.Add(new Post() { Title= "Going mobile with the new Visual Studio Mobile Center", Author="John Smith", Content= "A few months ago when the Visual Studio Mobile Center was released, I decided to configure it in parallel with the DevOps process I was already creating in Visual Studio Team Services. My goal was to try and evaluate this new platform. The minimalist design, simple configuration, and the fact that it has several tools in just one place made it seem like a terrific platform for our mobile projects at UruIT. In this post, I’ll share with you more information about Visual Studio Mobile Center and my take on its many advantages.", Date=new DateTime(2017, 04, 07) });
            defaultPosts.Add(new Post() { Title = "Zipkin with docker startup script Monday, April 10, 2017", Author = "John Smith", Content = "In a project we use http://zipkin.io/ for distributed tracing. During development is is very handy to trace to Zipkin running in a Docker image. The following PowerShell script will help with (re)starting the Docker image on WIndows and open Zipkin in Chrome when it is running.", Date = new DateTime(2017, 04, 10) });
            defaultPosts.Add(new Post() { Title = "LLBLGen Pro v5.2 Beta has been released!", Author = "John Smith", Content = "Earlier this week we''ve released LLBLGen Pro v5.2 beta! See below for the new features and changes in this release. It''s feature complete and comes with full documentation. We plan to release the RTM within 2 weeks or so.  Initially we had planned for this release to port our LLBLGen Pro runtime framework to Netstandard1.6 (.net core) however we postponed that port to Netstandard2.0 and will release that port in v5.3. We did spend considerable time on the port to Netstandard 1.6 hence v5.2 took longer than expected. ", Date = new DateTime(2017, 04, 07) });

            context.Posts.AddRange(defaultPosts);

            base.Seed(context);
        }
    }
}
using Blog.DAL;
using Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.Controllers
{
    public class HomeController : Controller
    {
        private BlogDataContext db = new BlogDataContext();

        public ActionResult Index()
        {
            return View(db.Posts.ToList());
        }

        // POST: Posts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddPost([Bind(Include = "Id,Title,Author,Content,Date")] Post post)
        {
            if (ModelState.IsValid)
            {
                post.Date = DateTime.Now;
                post.Author = "John Smith";
                db.Posts.Add(post);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }


    }
}
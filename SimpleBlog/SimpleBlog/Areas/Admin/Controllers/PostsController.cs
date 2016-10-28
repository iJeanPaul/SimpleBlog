using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleBlog.Areas.Admin.Controllers
{
    public class PostsController : Controller
    {
        // GET: Admin/Posts - this will get all the posts
        public ActionResult Index()
        {
            return Content("ADMIN POSTS");
        }
    }
}
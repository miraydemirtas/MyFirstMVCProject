using BlogProje.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogProje.Controllers
{
    public class HomeController : Controller
    {
        BlogDB db = new BlogDB();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult KategoriPartial()
        {
            db.Kategoris.ToList();
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
    }
}
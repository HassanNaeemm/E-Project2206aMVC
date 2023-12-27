using ASP2206a.Context;
using ASP2206a.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP2206a.Controllers
{
    public class AdminController : Controller
    {
        sqlcontext sc;
		public AdminController(sqlcontext sc1)
		{
			this.sc = sc1;
			
		}
		public IActionResult Index()
        {
            return View();
        }
        public IActionResult ProductShow()
        {
            return View(sc.tblusers.ToList());
        }
        public IActionResult deleteuser(int id)
        {
            ImageModel im = sc.tblusers.Find(id);
            sc.tblusers.Remove(im);
            sc.SaveChanges();
            return RedirectToAction("ProductShow");


        }
        public IActionResult userdetails(int id)
        {
            return View(sc.tblusers.Find(id));
        }
		public IActionResult logout()
		{
			if (HttpContext.Session.GetString("usersession") != null)
			{
				HttpContext.Session.Remove("usersession");
			}
			return View("login");
		}
	}
}

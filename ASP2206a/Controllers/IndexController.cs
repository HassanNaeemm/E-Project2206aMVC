using ASP2206a.Database;
using ASP2206a.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ASP2206a.Controllers
{
    public class IndexController : Controller
    {
		sqlcontext sc;
        public IndexController(sqlcontext sc1)
        {
            this.sc = sc1;
        }
        public IActionResult Index()
        {
            return View();
        }
       
        public IActionResult Shop()
		{
			return View();
		}
		public IActionResult Blog()
		{
			return View();
		}
		public IActionResult Services()
		{
			return View();
		}
		public IActionResult About()
		{
			return View();
		}
        public IActionResult Contact()
        {
            return View();
        }
       
        [HttpPost]
        public IActionResult Contact(contactmodel ins)
        {
            
                sc.tblcontact.Add(ins);
                sc.SaveChanges();
                ModelState.Clear();
              
            return View();
 
        }
        public IActionResult showcontact()
        {
            return View(sc.tblcontact.ToList());
        }
        public IActionResult deletecontact(int id)
        {
            contactmodel cm = sc.tblcontact.Find(id);
            sc.tblcontact.Remove(cm);
            sc.SaveChanges();
            return RedirectToAction("showcontact");
        }
        public IActionResult showrec(int id)
        {
            var a = sc.tblcontact.Find(id);
            return View(a);
        }
        [HttpPost]
        public IActionResult showrec(contactmodel cm)
        {
            var a = sc.tblcontact.Find(cm.contactid);
            if(a != null)
            {
                a.username = cm.username;
                a.email = cm.email;
                a.message = cm.message;
                a.lastname = cm.lastname;
                sc.SaveChanges();
  
            }
            return RedirectToAction("showcontact");
        }
        public IActionResult detailsuser(int id)
        {
            var a = sc.tblcontact.Find(id);
            return View(a);
        }
        public IActionResult Cart()
		{
			return View();
		}
		public IActionResult Checkout()
		{
			return View();
		}
		public IActionResult Thankyou()
		{
			return View();
		}
	}
}

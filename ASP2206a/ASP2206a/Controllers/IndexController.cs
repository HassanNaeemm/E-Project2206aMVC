using ASP2206a.Context;
using ASP2206a.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP2206a.Controllers
{
    public class IndexController : Controller
    {
		sqlcontext sc;
		IWebHostEnvironment env;
		public IndexController(sqlcontext sc1, IWebHostEnvironment env)
		{
			this.sc = sc1;
			this.env = env;
		}
		public IActionResult insertuser()
		{
			return View();
		}
		[HttpPost]
		public IActionResult insertuser(_ImageModel im)
		{
			String filename = "";
			if (im.Photo != null)
			{
				String uploadFolder = Path.Combine(env.WebRootPath, "Gallery");
				filename = Guid.NewGuid().ToString() + "_" + im.Photo.FileName;
				String mergevalue = Path.Combine(uploadFolder, filename);
				im.Photo.CopyTo(new FileStream(mergevalue, FileMode.Create));


				ImageModel data = new ImageModel()
				{
					image = filename,
					name = im.name,
					email = im.email,
					password = im.password
				};
				sc.tblusers.Add(data);
				sc.SaveChanges();

				ModelState.Clear();
				//return RedirectToAction("Index");
				ViewBag.result = "Message Sent Successfully !";
				return View();
			}

			return View();
		}
		public IActionResult Index()
        {
			var credentials = HttpContext.Session.GetString("usersession");

			if(credentials == null)
			{
				return View("login");
			}
			else
			{
				return View();
			}
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
		public IActionResult login()
		{
			return View();
		}
		[HttpPost]
		public IActionResult login(ImageModel usermodel)
		{
			var credentials = sc.tblusers.Where(userinput => userinput.email == usermodel.email && userinput.password == usermodel.password).FirstOrDefault();
			if (credentials != null)
			{
				HttpContext.Session.SetString("usersession", credentials.name);
				ViewBag.username = HttpContext.Session.GetString("usersession");
				return View("../Admin/Index");
			}
			ViewBag.error = "Credentials did not matched";
			return View();
		}
		public IActionResult logout()
		{
			if(HttpContext.Session.GetString("usersession") != null)
			{
				HttpContext.Session.Remove("usersession");
			}
			return View("login");
		}
	}
}

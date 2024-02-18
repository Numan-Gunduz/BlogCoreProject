using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{

	public class AboutController : Controller
	{
		AboutManager abmn= new AboutManager(new EfAboutRepository());
		public IActionResult Index()
		{
			var values = abmn.Getlist();

			return View(values);
		}
		public PartialViewResult SocialMediaAbout() 
		{ 
		return PartialView();
		}
	}
}

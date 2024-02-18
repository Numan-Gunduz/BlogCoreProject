using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{

	public class NewsLetterController : Controller
	{
		NewsLetterManager nm = new NewsLetterManager(new EFNewsLetterRepository());
		[HttpGet]
		public PartialViewResult Index()
		{
			return PartialView();
		}
		[HttpPost]
		public IActionResult Index(NewsLetter p)
		{
			p.MailStatus = true;
			nm.AddNewsLetter(p);
			return RedirectToAction("Index","Blog");
		}

	}
}

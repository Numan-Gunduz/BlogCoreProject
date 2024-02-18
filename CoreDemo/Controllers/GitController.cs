using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
	public class GitController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}

using BusinessLayer.Concrete;
using BusinessLayer.ValditationRules;
using CoreDemo.Models;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
namespace CoreDemo.Controllers
{
	[AllowAnonymous]

	public class RegisterController : Controller
	{
		WriterManager wm = new WriterManager(new EfWriterRepository());
		[HttpGet]
		public IActionResult Index()
		{
			
			
			return View();
		}

	[HttpPost]
		public IActionResult Index(Writer p)
		{
			WriterValidator wv = new WriterValidator();

			ValidationResult result =wv.Validate(p);
			if(result.IsValid)
			{
				p.WriterAbout = "Deneme Test";
				p.WriterStatus = true;
				wm.WriterAdd(p);
				return RedirectToAction("Index", "Blog");
			}
			else
			{
				foreach (var item in result.Errors)
				{
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				}
			}
		return View();
		}
	}
}

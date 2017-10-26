using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
	public class ComicBooksController : Controller
	{
		// GET: ComicBooks
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult Detail()
		{
			if (DateTime.Today.DayOfWeek == DayOfWeek.Wednesday)
			{
				return Redirect("/");
			}

			return Content("this is comic books controller saying hi");

		}
	}
}
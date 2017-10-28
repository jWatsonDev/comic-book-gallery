using ComicBookGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
	public class TestTestController : Controller
	{
		public ActionResult AnotherPage()
		{
			var comicBook = new ComicBook()
			{
				SeriesTitle = "fred",
				IssueNumber = 39843,
				DescriptionHtml = "blah blah blah",
				Artists = new Artist[]
				{
					new Artist() { Name = "jay", Role = "husband" },
					new Artist() { Name = "Cass", Role = "Wife" }
				}
			};

			return View(comicBook);
		}
		
		
		// GET: TestTest
		public ActionResult Index()
		{
			return View();
		}

		public string BeTest()
		{
			return "this is a test";
		}


	}
}
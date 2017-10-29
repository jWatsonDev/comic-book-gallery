using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ComicBookGallery.Models;
using ComicBookGallery.Data;

namespace ComicBookGallery.Controllers
{
	public class ComicBooksController : Controller
	{
		private ComicBookRepository _comicBookRepository = null;

		public ComicBooksController()
		{
			_comicBookRepository = new ComicBookRepository();
		}

		public ActionResult Test()
		{
			ViewBag.FirstName = "Jay";
			ViewBag.FavFood = "steak";
			return View();
		}

		public ActionResult Detail(int? id)
		{
			if (id == null)
			{
				return HttpNotFound();
			}
			var comicBook = _comicBookRepository.GetComicBook((int)id);


			return View(comicBook);

		}

		public ActionResult Index()
		{
			var comicBooks = _comicBookRepository.GetComicBooks();
			return View(comicBooks);
		}
	}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class TestTestController : Controller
    {
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
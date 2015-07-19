using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCMultiCheckBox.Models;

namespace MVCMultiCheckBox.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
		public ActionResult Index()
		{
			var myHomeViewModel = new HomeViewModel();

			myHomeViewModel.Persons = new List<PersonModel>();
			myHomeViewModel.Persons.Add(new PersonModel { Name = "Frank", Checked = false });
			myHomeViewModel.Persons.Add(new PersonModel { Name = "Joe", Checked = false });
			myHomeViewModel.Persons.Add(new PersonModel { Name = "Sue", Checked = false });
			myHomeViewModel.Persons.Add(new PersonModel { Name = "Mike", Checked = false });

			return View(myHomeViewModel);
		}

		[HttpPost]
		public ActionResult Submit(HomeViewModel result)
		{
			return View("Index", result);
		}
    }
}
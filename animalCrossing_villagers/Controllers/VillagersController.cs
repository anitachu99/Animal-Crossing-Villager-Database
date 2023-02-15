using System;
using MySql.Data.MySqlClient;
using Microsoft.AspNetCore.Mvc;
using animalCrossing_villagers.Models;

namespace animalCrossing_villagers.Controllers
{
	public class VillagersController : Controller
	{
		public ActionResult About()
		{
			VillagersContext context = HttpContext.RequestServices.GetService(typeof(animalCrossing_villagers.Models.VillagersContext)) as VillagersContext;

			return View(context.GetVillagers());
		}
	}
}


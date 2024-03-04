using KendoUI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text.Json.Nodes;

namespace KendoUI.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult TestIndex()
		{
			return View();
		}

		public IActionResult Form()
		{
			return View();
		}

		public IActionResult Haideep()
		{
			return View();
		}


		public IActionResult KendoDropDown()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}

		public JsonResult KarlayaCode()
		{
			Dictionary<string, string> officeList = new Dictionary<string, string>();
			officeList.Add("name", "Haideep");
            return Json(officeList);

        }
        [HttpPost]
		public IActionResult Post()
		{
			return Ok();
		}
		[HttpPost]
		public IActionResult Update()
		{
			return Ok();
		}
	}
}
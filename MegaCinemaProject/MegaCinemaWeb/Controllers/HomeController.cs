using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MegaCinemaService;

namespace MegaCinemaWeb.Controllers
{
    public class HomeController : Controller
    {
        IStatusService _statusService;

        public HomeController(IStatusService statusService)
        {
            _statusService = statusService;
        }

        // GET: Home
        public ActionResult Index()
        {
            var result = _statusService.GetAll();
            return View(result);
        }
    }
}
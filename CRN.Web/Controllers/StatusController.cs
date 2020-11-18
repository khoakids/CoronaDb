using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRN.Domain.Request.Status;
using CRN.Web.Models.Ultilities;
using Microsoft.AspNetCore.Mvc;

namespace CRN.Web.Controllers
{
    public class StatusController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        [Route("/status/gets")]
        public JsonResult Gets()
        {
            var result = ApiHelper<List<StatusView>>.HttpGetAsync($"status/gets");
            return Json(new { data = result });
        }
    }
}

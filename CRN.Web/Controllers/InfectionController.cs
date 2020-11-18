using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRN.Domain.Request.Infection;
using CRN.Web.Models.Ultilities;
using Microsoft.AspNetCore.Mvc;

namespace CRN.Web.Controllers
{
    public class InfectionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        [Route("/infection/gets")]
        public JsonResult Gets()
        {
            var result = ApiHelper<List<InfectionView>>.HttpGetAsync($"infection/gets");
            return Json(new { data = result });
        }
    }
}

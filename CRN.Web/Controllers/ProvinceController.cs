using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRN.Domain.Request.Province;
using CRN.Web.Models.Ultilities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRN.Web.Controllers
{
    [ApiController]
    public class ProvinceController : Controller
    {
        [HttpGet]
        [Route("/province/gets")]
        public JsonResult Gets()
        {
            var result = ApiHelper<List<ProvinceView>>.HttpGetAsync($"province/gets");
            return Json(new { data = result });
        }
    }
}

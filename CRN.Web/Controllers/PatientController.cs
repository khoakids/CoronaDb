using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRN.Domain.Request;
using CRN.Web.Models.Patient;
using CRN.Web.Models.Ultilities;
using Microsoft.AspNetCore.Mvc;

namespace CRN.Web.Controllers
{
    public class PatientController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var data = ApiHelper<List<PatientView>>.HttpGetAsync($"patient/gets");
            return View(data);
        }
        [HttpPost]
        public IActionResult Index([FromBody] PatientView req)
        {
            var data = ApiHelper<List<PatientView>>.HttpPostAsync($"patient/getss", "POST", req);
            return View(data);
        }
    }
}

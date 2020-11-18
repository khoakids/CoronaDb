using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRN.Domain.Request;
using CRN.Domain.Request.Infection;
using CRN.Domain.Request.Province;
using CRN.Domain.Request.Status;
using CRN.Domain.Response;
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
            var data = ApiHelper<List<Domain.Response.PatientView>>.HttpGetAsync($"patient/gets");
            return View(data);
        }
        [HttpPost]
        public IActionResult Index([FromBody] Domain.Response.PatientView req)
        {
            var data = ApiHelper<List<Domain.Response.PatientView>>.HttpPostAsync($"patient/getss", "POST", req);
            return View(data);
        }
        [HttpGet]
        public IActionResult Create()
        {
            TempData["success"] = null;
            TempData["error"] = null;
            SavePatientReqWeb result = new SavePatientReqWeb()
            {
                Provinces = ApiHelper<List<ProvinceView>>.HttpGetAsync("province/gets"),
                Statuses = ApiHelper<List<StatusView>>.HttpGetAsync("status/gets"),
                Infections = ApiHelper<List<InfectionView>>.HttpGetAsync("infection/gets")
            };
            return View(result);
        }
        [HttpPost]
        public IActionResult Create(SavePatientReqWeb req)
        {
            var result = new SavePatientRes();
            if(ModelState.IsValid)
            {
                result = ApiHelper<SavePatientRes>.HttpPostAsync("patient/save", "POST", req);
                if (result.PatientId != 0)
                {
                    TempData["success"] = result.Message;
                }
                else
                {
                    TempData["error"] = result.Message;
                }
            }
            req.Statuses = ApiHelper<List<StatusView>>.HttpGetAsync($"status/gets");
            req.Provinces = ApiHelper<List<ProvinceView>>.HttpGetAsync($"province/gets");
            req.Infections = ApiHelper<List<InfectionView>>.HttpGetAsync($"infection/gets");
            return View(req);
        }
        [HttpGet]
        public IActionResult Edit(int patientid)
        {
            TempData["success"] = null;
            TempData["error"] = null;
            var data = ApiHelper<SavePatientReqWeb>.HttpGetAsync($"patient/get/{patientid}");
            data.Statuses = ApiHelper<List<StatusView>>.HttpGetAsync($"status/gets");
            data.Provinces = ApiHelper<List<ProvinceView>>.HttpGetAsync($"province/gets");
            data.Infections = ApiHelper<List<InfectionView>>.HttpGetAsync($"infection/gets");
            return View(data);
        }
        [HttpPost]
        public IActionResult Edit(SavePatientReqWeb req)
        {
            var result = new SavePatientRes();
            if (ModelState.IsValid)
            {
                result = ApiHelper<SavePatientRes>.HttpPostAsync("patient/save", "POST", req);
                if (result.PatientId != 0)
                {
                    TempData["success"] = result.Message;
                }
                else
                {
                    TempData["error"] = result.Message;
                }
            }
            req.Statuses = ApiHelper<List<StatusView>>.HttpGetAsync($"status/gets");
            req.Provinces = ApiHelper<List<ProvinceView>>.HttpGetAsync($"province/gets");
            req.Infections = ApiHelper<List<InfectionView>>.HttpGetAsync($"infection/gets");
            return View(req);
        }
    }
}

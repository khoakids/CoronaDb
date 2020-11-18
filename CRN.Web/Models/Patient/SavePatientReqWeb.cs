using CRN.Domain.Request.Infection;
using CRN.Domain.Request.Province;
using CRN.Domain.Request.Status;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRN.Web.Models.Patient
{
    public class SavePatientReqWeb
    {
        public int PatientId { get; set; }
        public string Fullname { get; set; }
        public DateTime Birthday { get; set; }
        public bool Gender { get; set; }
        public string Hometown { get; set; }
        public string Residence { get; set; }
        public List<ProvinceView> Provinces { get; set; }
        public string Job { get; set; }
        public DateTime DetectionDate { get; set; }
        public List<InfectionView> Infections { get; set; }
        public List<StatusView> Statuses { get; set; }
        public bool BackgroundPathology { get; set; }
        public string PathologicalName { get; set; }
        public string IdentityCard { get; set; }
        public int InfectedPlaceId { get; set; }
        public int InfectionId { get; set; }
        public int StatusId { get; set; }
    }
}

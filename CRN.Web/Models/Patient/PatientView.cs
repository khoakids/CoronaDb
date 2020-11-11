using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRN.Web.Models.Patient
{
    public class PatientView
    {
        public int PatientId { get; set; }
        public string Fullname { get; set; }
        public DateTime Birthday { get; set; }
        public int Gender { get; set; }
        public string GenderName { get; set; }
        public string Hometown { get; set; }
        public string Residence { get; set; }
        public int InfectedPlaceId { get; set; }
        public string Job { get; set; }
        public DateTime DetectionDate { get; set; }
        public string DetectionDateFormat { get; set; }
        public int InfectionId { get; set; }
        public int StatusId { get; set; }
        public bool BackgroundPathology { get; set; }
        public string PathologicalName { get; set; }
        public string IdentityCard { get; set; }
    }
}

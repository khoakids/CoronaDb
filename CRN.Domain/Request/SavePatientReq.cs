using System;
using System.Collections.Generic;
using System.Text;

namespace CRN.Domain.Request
{
    public class SavePatientReq
    {
        public int PatientId { get; set; }
        public string Fullname { get; set; }
        public DateTime Birthday { get; set; }
        public bool Gender { get; set; }
        public string Hometown { get; set; }
        public string Residence { get; set; }
        public int InfectedPlaceId { get; set; }
        public string Job { get; set; }
        public DateTime DetectionDate { get; set; }
        public int InfectionId { get; set; }
        public int StatusId { get; set; }
        public bool BackgroundPathology { get; set; }
        public string PathologicalName { get; set; }
        public string IdentityCard { get; set; }
    }
}

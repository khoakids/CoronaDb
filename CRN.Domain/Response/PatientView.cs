using System;
using System.Collections.Generic;
using System.Text;

namespace CRN.Domain.Response
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
        public int BackgroundPathology { get; set; }
        public string PathologicalName { get; set; }
        public string IdentityCard { get; set; }
        public string ProvinceName { get; set; }
        public string BackgroundPathologyName { get; set; }
        public string StatusName { get; set; }
    }
}

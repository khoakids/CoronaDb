using System;
using System.Collections.Generic;
using System.Text;

namespace CRN.Domain.Request
{
    public class LinkGetsPatient
    {
        
        public int? Gender { get; set; }
        public int? InfectedPlaceId { get; set; }
        public int? StatusId { get; set; }
        public int? InfectionId { get; set; }
        public int? BackgroundPathology { get; set; }
    }
}

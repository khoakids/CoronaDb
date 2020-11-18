using System;
using System.Collections.Generic;
using System.Text;

namespace CRN.Domain.Request.Infection
{
    public class InfectionView
    {
        public int InfectionId { get; set; }
        public string InfectionLevel { get; set; }
        public bool IsDeleted { get; set; }
        public string Information { get; set; }
        public bool Warning { get; set; }
    }
}

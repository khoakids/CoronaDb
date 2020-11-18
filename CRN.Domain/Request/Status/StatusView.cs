using System;
using System.Collections.Generic;
using System.Text;

namespace CRN.Domain.Request.Status
{
    public class StatusView
    {
        public int StatusId { get; set; }
        public string StatusName { get; set; }
        public bool IsDeleted { get; set; }
    }
}

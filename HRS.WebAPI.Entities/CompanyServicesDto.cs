using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRS.WebAPI.Entities
{
    public class CompanyServicesDto
    {
        public int Id { get; set; }
        public string ServiceName { get; set; }
        public string ServiceDescription { get; set; }
        public string ConfgImage { get; set; }
        public string ConfgColor { get; set; }
        public string ConfgRedirectsTo { get; set; }
    }
}

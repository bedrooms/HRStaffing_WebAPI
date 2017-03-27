using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace HRS_Services.DataContract
{
    [DataContract(Namespace = "")]
    public class CompanyServiceDC
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string ServiceName { get; set; }
        [DataMember]
        public string ServiceDescription { get; set; }
        [DataMember]
        public string ConfgImage { get; set; }
        [DataMember]
        public string ConfgColor { get; set; }
        [DataMember]
        public string ConfgRedirectsTo { get; set; }
    }
}
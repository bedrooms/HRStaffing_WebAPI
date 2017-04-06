using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace HRS_Services.DataContract.Administration
{
    [DataContract(Namespace = "")]
    public class AdminModulesDC
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public int IdParent { get; set; }
        [DataMember]
        public string ConfgIconClass { get; set; }
        [DataMember]
        public string ConfgRedirectsTo { get; set; }
    }
}
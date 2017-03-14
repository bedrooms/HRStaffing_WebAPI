using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace HRS_Services.DataContract
{
    [DataContract(Namespace = "")]
    public class JobTitlesDC
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string JobTitle { get; set; }

        [DataMember]
        public string JobDescription { get; set; }

        [DataMember]
        public Nullable<int> JobIndustryId { get; set; }

        #region Non Entity

        [DataMember]
        public string JobTitleIndustryName { get; set; }

        #endregion
    }
}
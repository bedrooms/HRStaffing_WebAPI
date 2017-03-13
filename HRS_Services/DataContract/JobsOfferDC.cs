using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace HRS_Services.DataContract
{
    [DataContract(Namespace = "")]
    public class JobsOfferDC
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public Nullable<int> JobTitle { get; set; }

        [DataMember]
        public string Responsabilies { get; set; }

        [DataMember]
        public string Experience { get; set; }

        [DataMember]
        public Nullable<int> EmploymentTypeId { get; set; }

        [DataMember]
        public string Industry { get; set; }

        [DataMember]
        public Nullable<int> LevelStudyId { get; set; }

        [DataMember]
        public Nullable<int> ExperienceYears { get; set; }

        [DataMember]
        public Nullable<int> ResponsibleId { get; set; }

        #region Non Entity

        [DataMember]
        public string JobTitleName { get; set; }

        [DataMember]
        public string EmploymentTypeName { get; set; }

        [DataMember]
        public string LevelStudyName { get; set; }

        [DataMember]
        public string Responsible { get; set; }

        [DataMember]
        public string ResponsibleMail { get; set; }

        #endregion
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace HRS_Services.DataContract
{
    [DataContract(Namespace = "")]
    public class EmployeesDC
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string MiddleName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public Nullable<int> JobTitleId { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string Phone { get; set; }
        [DataMember]
        public string Mobile { get; set; }
        [DataMember]
        public bool Visible { get; set; }

        #region Non Entity
        [DataMember]
        public string JobTitleName { get; set; }
        [DataMember]
        public Nullable<System.DateTime> LastSession { get; set; }
        [DataMember]
        public bool LoggedSuccess { get; set; }

        #endregion
    }
}
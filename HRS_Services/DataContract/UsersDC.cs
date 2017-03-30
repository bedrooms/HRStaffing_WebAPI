using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRS_Services.DataContract
{
    public class UsersDC
    {
        public int Id { get; set; }
        public int IdEmployee { get; set; }
        public string Password { get; set; }
        public Nullable<System.DateTime> LastSession { get; set; }
        public Nullable<int> RoleId { get; set; } 
    }
}
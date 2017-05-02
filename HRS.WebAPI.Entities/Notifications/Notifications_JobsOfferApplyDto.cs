using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRS.WebAPI.Entities.Notifications
{
    public class Notifications_JobsOfferApplyDto
    {
        public int Id { get; set; }
        public int IdJobOfferApplication { get; set; }
        public bool NotificationSended { get; set; }
        public Nullable<System.DateTime> DateSend { get; set; }
        public Nullable<System.DateTime> DateCreted { get; set; }
        public string JobTitleName { get; set; }

        public virtual EmployeesDto ResponsibleToSend { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRS.WebAPI.Entities
{
    public class JobsOfferDto
    {
        public int Id { get; set; }
        public Nullable<int> JobTitle { get; set; }
        public string Responsabilies { get; set; }
        public string Experience { get; set; }
        public Nullable<int> EmploymentTypeId { get; set; }
        public string Industry { get; set; }
        public Nullable<int> LevelStudyId { get; set; }
        public Nullable<int> ExperienceYears { get; set; }
        public Nullable<int> ResponsibleId { get; set; }

        #region Non Entity

        public string JobTitleName { get; set; }
        public string EmploymentTypeName { get; set; }
        public string LevelStudyName { get; set; }
        public string Responsible { get; set; }
        public string ResponsibleMail { get; set; }

        public virtual EmployeesDto employeesDto { get; set; }

        #endregion
    }
}

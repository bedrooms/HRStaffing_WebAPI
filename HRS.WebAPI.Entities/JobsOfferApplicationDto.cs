using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRS.WebAPI.Entities
{
    public class JobsOfferApplicationDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string ResumeCV { get; set; }
        public int IdJobOffer { get; set; }

        #region Non Entity

        public virtual JobsOfferDto jobsOfferDto { get; set; }

        #endregion
    }
}

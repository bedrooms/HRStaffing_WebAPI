using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using HRS.WebAPI.Entities;
using HRS.WebAPI.Bussiness;
using HRS_Services.DataContract;
using HRS_Services.DataTransform;

namespace HRS_Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class HRAPISevice : IHRAPISevice
    {
        public List<JobsOfferDC> getAllJobs()
        {
            JobsOfferDT jobsOfferDT = new JobsOfferDT();
            return jobsOfferDT.getAllJobs();
        }

        public List<JobTitlesDC> getAllPositionsOffer()
        {
            JobsOfferDT jobsOfferDT = new JobsOfferDT();
            return jobsOfferDT.getAllPositionsOffer();

        }       
    }
}

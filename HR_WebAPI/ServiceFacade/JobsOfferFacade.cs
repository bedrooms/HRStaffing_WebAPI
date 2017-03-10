using HR_WebAPI.ServiceInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HRS.WebAPI.Entities;
using HRS.WebAPI.Bussiness;

namespace HR_WebAPI.ServiceFacade
{
    public class JobsOfferFacade : IJobsOffer
    {        
        public ResponseDto<List<JobsOfferDto>> getAllJobs()
        {
            JobsOfferBL jobsOfferBL = new JobsOfferBL();
            return jobsOfferBL.getAllJobs();
        }
    }
}
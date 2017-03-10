using HRS.WebAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_WebAPI.ServiceInterface
{
    public interface IJobsOffer
    {       
        ResponseDto<List<JobsOfferDto>> getAllJobs();
    }
}

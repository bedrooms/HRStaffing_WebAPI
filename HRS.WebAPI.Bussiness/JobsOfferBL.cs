using HRS.WebAPI.DataAccess;
using HRS.WebAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRS.WebAPI.Bussiness
{
    public class JobsOfferBL
    {
        public ResponseDto<List<JobsOfferDto>> getAllJobs()
        {
            JobsRepository jobsRepository = new JobsRepository();
            return jobsRepository.getAllJobs();
        }
    }
}

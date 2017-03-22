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
            MySql.DataAccess.MySql_JobsRepository jr = new MySql.DataAccess.MySql_JobsRepository();
            return jr.getAllJobs();

            JobsRepository jobsRepository = new JobsRepository();
            return jobsRepository.getAllJobs();
        }

        public ResponseDto<List<JobTitlesDto>> getAllJobsgetAllPositionsOffer()
        {
            JobsRepository jobsRepository = new JobsRepository();
            return jobsRepository.getAllJobsgetAllPositionsOffer();
        }
    }
}

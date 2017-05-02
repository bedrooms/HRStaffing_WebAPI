using HRS.WebAPI.DataAccess;
using HRS.WebAPI.Entities;
using HRS.WebAPI.Entities.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRS.WebAPI.Bussiness
{
    public class JobsOfferBL
    {
        #region GET    
        public ResponseDto<List<JobsOfferDto>> getAllJobs()
        {          
            JobsRepository jobsRepository = new JobsRepository();
            return jobsRepository.getAllJobs();
        }

        public ResponseDto<List<JobTitlesDto>> getAllJobsgetAllPositionsOffer()
        {
            JobsRepository jobsRepository = new JobsRepository();
            return jobsRepository.getAllJobsgetAllPositionsOffer();
        }

        public ResponseDto<List<Notifications_JobsOfferApplyDto>> getAllJobsApplyNotifications()
        {
            JobsRepository jobsRepository = new JobsRepository();
            return jobsRepository.getAllJobsApplyNotifications();
        }

        #endregion

            #region PUT
        public ResponseDto<bool> saveJobOfferApplication(JobsOfferApplicationDto application)
        {
            JobsRepository jobsRepository = new JobsRepository();
            return jobsRepository.saveJobOfferApplication(application);
        }
        #endregion
    }
}

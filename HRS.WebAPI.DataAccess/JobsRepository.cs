using HRS.WebAPI.DataAccess.Model;
using HRS.WebAPI.Entities;
using HRS.WebAPI.Entities.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRS.WebAPI.DataAccess
{
    public class JobsRepository
    {
        #region GET    

        public ResponseDto<List<JobsOfferDto>> getAllJobs()
        {
            ResponseDto<List<JobsOfferDto>> response = new ResponseDto<List<JobsOfferDto>>();

            using (HRStaffingModelConn objEntities = new HRStaffingModelConn())
            {
                IQueryable<JobsOfferDto> query = (from jo in objEntities.JobsOffer
                                                  select new JobsOfferDto()
                                                  {
                                                      Id = jo.Id,
                                                      JobTitle = jo.JobTitle,
                                                      EmploymentTypeId = jo.EmploymentTypeId,
                                                      Experience = jo.Experience,
                                                      ExperienceYears = jo.ExperienceYears,
                                                      Industry = jo.Industry,
                                                      LevelStudyId = jo.LevelStudyId,
                                                      Responsabilies = jo.Responsabilies,
                                                      ResponsibleId = jo.ResponsibleId,
                                                      //
                                                      JobTitleName = jo.JobTitles.JobTitle,
                                                      EmploymentTypeName = jo.EmploymentsType.Name,
                                                      LevelStudyName = jo.LevelsStudy.Name,
                                                      //
                                                      employeesDto = new EmployeesDto()
                                                      {
                                                          Email = jo.Employees.Email
                                                      }

                                               });

                response.Data = query.ToList();

                return response;
            }
          
        }

        public ResponseDto<List<JobTitlesDto>> getAllJobsgetAllPositionsOffer()
        {
            ResponseDto<List<JobTitlesDto>> response = new ResponseDto<List<JobTitlesDto>>();

            using (HRStaffingModelConn objEntities = new HRStaffingModelConn())
            {
                IQueryable<JobTitlesDto> query = (from jt in objEntities.JobTitles
                                                  where jt.JobIndustryId != 7
                                                  select new JobTitlesDto()
                                                  {
                                                      Id = jt.Id,
                                                      JobTitle = jt.JobTitle,
                                                      JobDescription = jt.JobDescription,
                                                      JobIndustryId = jt.JobIndustryId,                                                     
                                                      JobTitleIndustryName = jt.JobIndustry.Name
                                                  });

                response.Data = query.ToList();
                response.Data.OrderBy(x => x.JobTitleIndustryName);

                return response;
            }

        }

        public ResponseDto<List<Notifications_JobsOfferApplyDto>> getAllJobsApplyNotifications()
        {
            ResponseDto<List<Notifications_JobsOfferApplyDto>> response = new ResponseDto<List<Notifications_JobsOfferApplyDto>>();

            using (HRStaffingModelConn objEntities = new HRStaffingModelConn())
            {
                IQueryable<Notifications_JobsOfferApplyDto> query = (from njoa in objEntities.Notifications_JobsOfferApply
                                                  select new Notifications_JobsOfferApplyDto()
                                                  {
                                                      Id = njoa.Id,
                                                      DateCreted = njoa.DateCreted,
                                                      DateSend = njoa.DateSend,
                                                      IdJobOfferApplication = njoa.IdJobOfferApplication,
                                                      NotificationSended = njoa.NotificationSended,
                                                      JobTitleName = njoa.JobsOfferApplication.JobsOffer.JobTitles.JobTitle,
                                                      ResponsibleToSend = new EmployeesDto()
                                                      {
                                                          Email = njoa.JobsOfferApplication.JobsOffer.Employees.Email,
                                                          FirstName = njoa.JobsOfferApplication.JobsOffer.Employees.FirstName,
                                                          LastName = njoa.JobsOfferApplication.JobsOffer.Employees.LastName
                                                      }
                                                  });

                response.Data = query.ToList();

                return response;
            }

        }



        #endregion

        #region PUT

        public ResponseDto<bool> saveJobOfferApplication(JobsOfferApplicationDto application)
        {
            ResponseDto<bool> response = new ResponseDto<bool>();

            response.Data = true;

            int responseId = 0;

            JobsOfferApplication joa = new JobsOfferApplication()
            {
                City = application.City,
                Email = application.Email,
                IdJobOffer = application.IdJobOffer,
                Name = application.Name,
                Phone = application.Phone,
                ResumeCV = application.ResumeCV,
                State = application.State
            };

            using (HRStaffingModelConn objEntities = new HRStaffingModelConn())
            {
                objEntities.JobsOfferApplication.Add(joa);
                objEntities.SaveChanges();
                responseId = joa.Id;
            }

            if (responseId == 0)
                response.Data = false;

            return response;

        }

        #endregion
    }
}

using HRS.WebAPI.DataAccess.Model;
using HRS.WebAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRS.WebAPI.DataAccess
{
    public class JobsRepository
    {
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
                                                   LevelStudyName = jo.LevelsStudy.Name                                                   
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
                                                  select new JobTitlesDto()
                                                  {
                                                      Id = jt.Id,
                                                      JobTitle = jt.JobTitle,
                                                      JobDescription = jt.JobDescription,
                                                      JobIndustryId = jt.JobIndustryId,                                                     
                                                      JobTitleIndustryName = jt.JobIndustry.Name
                                                  });

                response.Data = query.ToList();

                return response;
            }

        }
    }
}

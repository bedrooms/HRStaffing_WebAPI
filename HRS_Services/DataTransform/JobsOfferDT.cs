using HRS.WebAPI.Bussiness;
using HRS.WebAPI.Entities;
using HRS_Services.DataContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRS_Services.DataTransform
{
    public class JobsOfferDT
    {
        public List<JobsOfferDC> getAllJobs()
        {
            List<JobsOfferDC> result = new List<JobsOfferDC>();

            JobsOfferBL jobsOfferBL = new JobsOfferBL();

            List<JobsOfferDto> jobsOfferDto = jobsOfferBL.getAllJobs().Data;

            foreach (var item in jobsOfferDto)
            {
                JobsOfferDC JODC = new JobsOfferDC();

                JODC.Id = item.Id;
                JODC.EmploymentTypeId = item.EmploymentTypeId;
                JODC.Experience = item.Experience;
                JODC.ExperienceYears = item.ExperienceYears;
                JODC.Industry = item.Industry;
                JODC.JobTitle = item.JobTitle;
                JODC.LevelStudyId = item.LevelStudyId;
                JODC.Responsabilies = item.Responsabilies;
                JODC.ResponsibleId = item.ResponsibleId;

                JODC.JobTitleName = item.JobTitleName;
                JODC.EmploymentTypeName = item.EmploymentTypeName;
                JODC.LevelStudyName = item.LevelStudyName;

                result.Add(JODC);

            }

            return result;
        }

        public List<JobTitlesDC> getAllPositionsOffer()
        {
            List<JobTitlesDC> result = new List<JobTitlesDC>();

            JobsOfferBL jobsOfferBL = new JobsOfferBL();

            List<JobTitlesDto> jobTitlesDto = jobsOfferBL.getAllJobsgetAllPositionsOffer().Data;

            foreach (var item in jobTitlesDto)
            {
                JobTitlesDC JODC = new JobTitlesDC();

                JODC.Id = item.Id;
                JODC.JobTitle = item.JobTitle;
                JODC.JobDescription = item.JobDescription;
                JODC.JobIndustryId = item.JobIndustryId;
                JODC.JobTitleIndustryName = item.JobTitleIndustryName;              

                result.Add(JODC);
            }

            return result;
        }
    }
}
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

        public Dictionary<string, List<JobTitlesDC>> getAllPositionsOffer()
        {
            Dictionary<string, List<JobTitlesDC>> result = new Dictionary<string, List<JobTitlesDC>>();

            JobsOfferBL jobsOfferBL = new JobsOfferBL();

            List<JobTitlesDto> jobTitlesDto = jobsOfferBL.getAllJobsgetAllPositionsOffer().Data;

            string jobTitleIndustryName = string.Empty;
            List<JobTitlesDC> resultI = new List<JobTitlesDC>();

            foreach (var item in jobTitlesDto)
            {
                JobTitlesDC JODC = new JobTitlesDC();

                if (jobTitleIndustryName != item.JobTitleIndustryName)
                {
                    if (resultI.Count > 0)
                    {                       
                        result.Add(jobTitleIndustryName, resultI);
                        resultI = new List<JobTitlesDC>();
                    }
                        
                    jobTitleIndustryName = item.JobTitleIndustryName;

                    JODC.Id = item.Id;
                    JODC.JobTitle = item.JobTitle;
                    JODC.JobDescription = item.JobDescription;
                    JODC.JobIndustryId = item.JobIndustryId;
                    JODC.JobTitleIndustryName = item.JobTitleIndustryName;

                    resultI.Add(JODC);
                }
                else
                {
                    JODC.Id = item.Id;
                    JODC.JobTitle = item.JobTitle;
                    JODC.JobDescription = item.JobDescription;
                    JODC.JobIndustryId = item.JobIndustryId;
                    JODC.JobTitleIndustryName = item.JobTitleIndustryName;

                    resultI.Add(JODC);
                }        

               
            }
            result.Add(jobTitleIndustryName, resultI);
            return result;
        }
    }
}
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
using HRS_Services.DataContract.Administration;
using HRS_Services.DataTransform.Administration;

namespace HRS_Services
{    
    public class HRAPISevice : IHRAPISevice
    {
       
        #region Company Services

        public List<CompanyServiceDC> GetAllCoServices()
        {
            CompanyServicesDT companyServicesDT = new DataTransform.CompanyServicesDT();
            return companyServicesDT.getAllEmployees();
        }

        #endregion

        #region Employees        

        public List<EmployeesDC> getAllEmployees()
        {
            EmployeesDT employeesDT = new EmployeesDT();
            return employeesDT.getAllEmployees();
        }

        #endregion

        #region Jobs

        public List<JobsOfferDC> getAllJobs()
        {
            JobsOfferDT jobsOfferDT = new JobsOfferDT();
            return jobsOfferDT.getAllJobs();
        }

        public Dictionary<string, List<JobTitlesDC>> getAllPositionsOffer()
        {
            JobsOfferDT jobsOfferDT = new JobsOfferDT();
            return jobsOfferDT.getAllPositionsOffer();
        }

        #endregion

        #region Authentication
            
        public EmployeesDC GetLoginUserAuth(string userName, string password)
        {
            AutenticationDT autenticationDT = new AutenticationDT();
            return autenticationDT.GetLoginUserAuth(userName, password);
        }

        #endregion

        #region Administration

        public Dictionary<string, List<AdminModulesDC>> GetAllAdminModules()
        {
            AdminModuleDT adminModuleDT = new AdminModuleDT();
            return adminModuleDT.getAllModules();
        }

        #endregion
    }
}

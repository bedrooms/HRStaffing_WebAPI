using HRS.WebAPI.Bussiness;
using HRS.WebAPI.Entities;
using HRS_Services.DataContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRS_Services.DataTransform
{
    public class AutenticationDT
    {
        public EmployeesDC GetLoginUserAuth(string userName, string password)
        {
            AuthenticationBL authenticationBL = new AuthenticationBL();

            EmployeesDto employeesDto = authenticationBL.GetLoginUserAuth(userName, password).Data;

            if (employeesDto != null)
            {
                return  new EmployeesDC()
                {
                    Id = employeesDto.Id,
                    FirstName = employeesDto.FirstName,
                    LastName = employeesDto.LastName,
                    Email = employeesDto.Email,
                    JobTitleName = employeesDto.JobTitleName,
                    LastSession = employeesDto.LastSession,
                    LoggedSuccess = true
                };
            }
            else
                return new EmployeesDC() { LoggedSuccess = false };           
        }
    }
}
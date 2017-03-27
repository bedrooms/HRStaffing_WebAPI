using HRS.WebAPI.Bussiness;
using HRS.WebAPI.Entities;
using HRS_Services.DataContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRS_Services.DataTransform
{
    public class EmployeesDT
    {
        public List<EmployeesDC> getAllEmployees()
        {
            List<EmployeesDC> result = new List<EmployeesDC>();

            EmployeesBL employeesBL = new EmployeesBL();

            List<EmployeesDto> employeesDto = employeesBL.getAllEmployees().Data;

            foreach (var item in employeesDto)
            {
                EmployeesDC EDC = new EmployeesDC();

                EDC.Email = item.Email;
                EDC.FirstName = item.FirstName;
                EDC.Id = item.Id;
                EDC.JobTitleId = item.JobTitleId;             
                EDC.LastName = item.LastName;
                EDC.Mobile = item.Mobile;
                EDC.Phone = item.Phone;
                EDC.Visible = item.Visible;

                EDC.JobTitleName = item.JobTitleName;

                result.Add(EDC);

            }

            return result;
        }
    }
}
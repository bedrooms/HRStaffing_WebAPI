using HRS.WebAPI.DataAccess.Model;
using HRS.WebAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRS.WebAPI.DataAccess
{
    public class EmployeesRepository
    {
        public ResponseDto<List<EmployeesDto>> getAllEmployees()
        {
            ResponseDto<List<EmployeesDto>> response = new ResponseDto<List<EmployeesDto>>();

            using (HRStaffingModelConn objEntities = new HRStaffingModelConn())
            {
                IQueryable<EmployeesDto> query = (from e in objEntities.Employees
                                                  select new EmployeesDto()
                                                  {
                                                      Id = e.Id,
                                                      FirstName = e.FirstName,
                                                      MiddleName = e.MiddleName,
                                                      LastName = e.LastName,
                                                      Email = e.Email,
                                                      Phone = e.Phone,
                                                      Mobile = e.Mobile,   
                                                      Visible = e.Visible,                                                   
                                                      // No entity
                                                      JobTitleName = e.JobTitles.JobTitle                                                    
                                                  });

                response.Data = query.ToList();

                return response;
            }

        }
    }
}

using HRS.WebAPI.DataAccess.Model;
using HRS.WebAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRS.WebAPI.DataAccess
{
    public class AuthenticationRepository
    {
        public ResponseDto<EmployeesDto> GetLoginUserAuth(string userName, string password)
        {
            ResponseDto<EmployeesDto> response = new ResponseDto<EmployeesDto>();

            using (HRStaffingModelConn objEntities = new HRStaffingModelConn())
            {
                IQueryable<EmployeesDto> query = (from u in objEntities.Users
                                                  where u.Employees.Email == userName &&
                                                  u.Password == password
                                                  select new EmployeesDto()
                                                  {
                                                      Id = u.Employees.Id,
                                                      FirstName = u.Employees.FirstName,
                                                      MiddleName = u.Employees.MiddleName,
                                                      LastName = u.Employees.LastName,
                                                      Email = u.Employees.Email,
                                                      // No entity
                                                      JobTitleName = u.Employees.JobTitles.JobTitle,
                                                      LastSession = u.LastSession
                                                  });

                response.Data = query.SingleOrDefault();

                return response;
            }

        }
    }
}

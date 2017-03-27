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
        public ResponseDto<List<EmployeesDto>> getAllJobs()
        {
            ResponseDto<List<EmployeesDto>> response = new ResponseDto<List<EmployeesDto>>();

            using (HRStaffingModelConn objEntities = new HRStaffingModelConn())
            {
                IQueryable<EmployeesDto> query = (from jo in objEntities.JobsOffer
                                                  select new EmployeesDto()
                                                  {
                                                      Id = jo.Id
                                                    
                                                  });

                response.Data = query.ToList();

                return response;
            }

        }
    }
}

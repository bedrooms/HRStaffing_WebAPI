using HRS.WebAPI.DataAccess;
using HRS.WebAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRS.WebAPI.Bussiness
{
    public class EmployeesBL
    {
        public ResponseDto<List<EmployeesDto>> getAllEmployees()
        {
            EmployeesRepository jobsRepository = new EmployeesRepository();
            return jobsRepository.getAllEmployees();
        }
    }
}

using HRS.WebAPI.DataAccess;
using HRS.WebAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRS.WebAPI.Bussiness
{
    public class AuthenticationBL
    {
        public ResponseDto<EmployeesDto> GetLoginUserAuth(string userName, string password)
        {
            AuthenticationRepository authenticationRepository = new AuthenticationRepository();
            return authenticationRepository.GetLoginUserAuth(userName, password);
        }
    }
}

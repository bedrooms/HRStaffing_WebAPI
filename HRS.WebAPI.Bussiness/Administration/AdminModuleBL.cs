using HRS.WebAPI.DataAccess.Administration;
using HRS.WebAPI.Entities;
using HRS.WebAPI.Entities.Administration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRS.WebAPI.Bussiness.Administration
{
    public class AdminModuleBL
    {
        public ResponseDto<List<AdminModulesDto>> getAllModules()
        {
            AdminModulesRepository adminModulesRepository = new AdminModulesRepository();
            return adminModulesRepository.getAllModules();
        }
    }
}

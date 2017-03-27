using HRS.WebAPI.DataAccess;
using HRS.WebAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRS.WebAPI.Bussiness
{
    public class CompanyServicesBL
    {
        public ResponseDto<List<CompanyServicesDto>> getAllCoServices()
        {
            CompanyServicesRepository companyServicesRepository = new CompanyServicesRepository();
            return companyServicesRepository.getAllCoServices();
        }
    }
}

using HRS.WebAPI.DataAccess.Model;
using HRS.WebAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRS.WebAPI.DataAccess
{
    public class CompanyServicesRepository
    {
        public ResponseDto<List<CompanyServicesDto>> getAllCoServices()
        {
            ResponseDto<List<CompanyServicesDto>> response = new ResponseDto<List<CompanyServicesDto>>();

            using (HRStaffingModelConn objEntities = new HRStaffingModelConn())
            {
                IQueryable<CompanyServicesDto> query = (from cs in objEntities.CompanyServices
                                                  select new CompanyServicesDto()
                                                  {
                                                      Id = cs.Id,
                                                      ServiceName = cs.ServiceName,
                                                      ServiceDescription = cs.ServiceDescription,
                                                      ConfgColor = cs.ConfgColor,
                                                      ConfgImage = cs.ConfgImage,
                                                      ConfgRedirectsTo = cs.ConfgRedirectsTo                                         
                                                  });

                response.Data = query.ToList();

                return response;
            }

        }
    }
}

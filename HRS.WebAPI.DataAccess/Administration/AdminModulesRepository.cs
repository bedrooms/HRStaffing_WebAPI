using HRS.WebAPI.DataAccess.Model;
using HRS.WebAPI.Entities;
using HRS.WebAPI.Entities.Administration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRS.WebAPI.DataAccess.Administration
{
    public class AdminModulesRepository
    {
        public ResponseDto<List<AdminModulesDto>> getAllModules()
        {
            ResponseDto<List<AdminModulesDto>> response = new ResponseDto<List<AdminModulesDto>>();

            using (HRStaffingModelConn objEntities = new HRStaffingModelConn())
            {
                IQueryable<AdminModulesDto> query = (from am in objEntities.AdminModules
                                                  select new AdminModulesDto()
                                                  {
                                                      Id = am.Id,
                                                      Name = am.Name,
                                                      Description = am.Description,
                                                      IdParent = am.IdParent,
                                                      ConfgIconClass = am.ConfgIconClass,
                                                      ConfgRedirectsTo = am.ConfgRedirectsTo
                                                  });

                response.Data = query.ToList();

                return response;
            }

        }
    }
}

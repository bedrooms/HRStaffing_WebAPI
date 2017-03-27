using HRS.WebAPI.Bussiness;
using HRS.WebAPI.Entities;
using HRS_Services.DataContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRS_Services.DataTransform
{
    public class CompanyServicesDT
    {
        public List<CompanyServiceDC> getAllEmployees()
        {
            List<CompanyServiceDC> result = new List<CompanyServiceDC>();

            CompanyServicesBL companyServicesBL = new CompanyServicesBL();

            List<CompanyServicesDto> companyServicesDto = companyServicesBL.getAllCoServices().Data;

            foreach (var item in companyServicesDto)
            {
                CompanyServiceDC CS = new CompanyServiceDC();

                CS.Id = item.Id;
                CS.ServiceName = item.ServiceName;
                CS.ServiceDescription = item.ServiceDescription;
                CS.ConfgImage = item.ConfgImage;
                CS.ConfgColor = item.ConfgColor;
                CS.ConfgRedirectsTo = item.ConfgRedirectsTo;

                result.Add(CS);

            }

            return result;
        }
    }
}
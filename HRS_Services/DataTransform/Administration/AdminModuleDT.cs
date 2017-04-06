using HRS.WebAPI.Bussiness.Administration;
using HRS.WebAPI.Entities.Administration;
using HRS_Services.DataContract.Administration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRS_Services.DataTransform.Administration
{
    public class AdminModuleDT
    {
        public Dictionary<string, List<AdminModulesDC>> getAllModules()
        {
            Dictionary<string, List<AdminModulesDC>> result = new Dictionary<string, List<AdminModulesDC>>();

            AdminModuleBL adminModuleBL = new AdminModuleBL();

            List<AdminModulesDto> adminModulesDto = adminModuleBL.getAllModules().Data;

            string parentName = string.Empty;
            List<AdminModulesDC> resultI = new List<AdminModulesDC>();

            foreach (var item in adminModulesDto)
            {
                AdminModulesDC AMDC = new AdminModulesDC();

                if (parentName != item.Name && item.IdParent == 0)
                {
                    if (resultI.Count > 0)
                    {
                        result.Add(parentName, resultI);
                        resultI = new List<AdminModulesDC>();
                    }

                    parentName = item.Name;

                    //AMDC.Id = item.Id;
                    //AMDC.Name = item.Name;
                    //AMDC.ConfgIconClass = item.ConfgIconClass;
                    //AMDC.ConfgRedirectsTo = item.ConfgRedirectsTo;

                    //resultI.Add(AMDC);
                }
                else
                {
                    AMDC.Id = item.Id;
                    AMDC.Name = item.Name;
                    AMDC.ConfgIconClass = item.ConfgIconClass;
                    AMDC.ConfgRedirectsTo = item.ConfgRedirectsTo;

                    resultI.Add(AMDC);
                }


            }
            result.Add(parentName, resultI);
            return result;
        }
    }
}
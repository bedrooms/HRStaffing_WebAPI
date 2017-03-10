using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using HRS.WebAPI.Entities;
using HRS.WebAPI.Bussiness;
using HRS_Services.DataContract;

namespace HRS_Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public List<JobsOfferDC> getAllJobs()
        {
            List<JobsOfferDC> result = new List<JobsOfferDC>();

            JobsOfferBL jobsOfferBL = new JobsOfferBL();

            List<JobsOfferDto> jobsOfferDto = jobsOfferBL.getAllJobs().Data;

            foreach (var item in jobsOfferDto)
            {
                JobsOfferDC JODC = new JobsOfferDC();

                JODC.Id = item.Id;

                result.Add(JODC);

            }

            return result;
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}

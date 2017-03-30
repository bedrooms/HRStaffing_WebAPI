using HRS.WebAPI.Entities;
using HRS_Services.DataContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace HRS_Services
{
    [ServiceContract]
    public interface IHRAPISevice
    {
        #region Jobs Interface
       
        [OperationContract]
        [WebInvoke(Method = "GET",
        ResponseFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Wrapped,         
        UriTemplate = "GetJobsOffer")]
        List<JobsOfferDC> getAllJobs();

        [OperationContract]
        [WebInvoke(Method = "GET",
        ResponseFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Wrapped,
        UriTemplate = "GetPositionsOffer")]
        Dictionary<string, List<JobTitlesDC>> getAllPositionsOffer();

        #endregion

        #region Employees Interface

        [OperationContract]
        [WebInvoke(Method = "GET",
        ResponseFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Wrapped,
        UriTemplate = "GetAllEmployees")]
        List<EmployeesDC> getAllEmployees();

        #endregion

        #region Company Services

        [OperationContract]
        [WebInvoke(Method = "GET",
        ResponseFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Wrapped,
        UriTemplate = "GetAllCoServices")]
        List<CompanyServiceDC> GetAllCoServices();

        #endregion

        #region Authentication

        [OperationContract]
        [WebInvoke(Method = "GET",
        ResponseFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Wrapped,
        UriTemplate = "GetLoginUser/?password={password}&userName={userName}")]
        EmployeesDC GetLoginUserAuth(string userName, string password);

        #endregion

    }
}

using System;
using System.Collections.Generic;
using HRS.WebAPI.Entities;
using System.Data;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRS.WebAPI.MySql.DataAccess
{
    public class MySql_JobsRepository
    {
        public ResponseDto<List<JobsOfferDto>> getAllJobs()
        {
            List<JobsOfferDto> res = new List<JobsOfferDto>();

            MySqlCommand cmd = new MySqlCommand("getAllJobs", new MySqlConnection(Connection.MySql_Connection.getConnection()));
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection.Open();
            MySqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            while (dr.Read())
            {
                JobsOfferDto jobOfferItem = new JobsOfferDto();

                jobOfferItem.EmploymentTypeName = dr["EmploymentTypeName"].ToString();

                res.Add(jobOfferItem);
            }
            dr.Close();



            return new ResponseDto<List<JobsOfferDto>> { Data = res};
        }
    }
}

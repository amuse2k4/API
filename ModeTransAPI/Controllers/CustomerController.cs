using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ModeTransAPI.Controllers
{
    public class CustomerController : ApiController
    {
        public string CS = ConfigurationManager.ConnectionStrings["DBCon2"].ConnectionString;
        public string companyName;



        // GET: api/Customer
        public IEnumerable<string> Get()
        {

                return new string[] { "value1", "value2" };
        }

        // GET: api/Customer/5
        public string Get(int id)
        {
            //string query = "select * from salesLt.Customer";
            string query = "select * from dbo.aj_users";

            using (SqlConnection conn = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();

                SqlDataReader dr = cmd.ExecuteReader();
                
                    if (dr != null)
                    {
                        while (dr.Read())
                        {
                            string companyName = dr["CompanyNames"].ToString();
                        }
                    }
                
            }

                return companyName;
        }

        // POST: api/Customer
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Customer/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Customer/5
        public void Delete(int id)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HelloWorldApi.Models;
using System.Data.SqlClient;
using System.Configuration;

namespace HelloWorldApi.Controllers
{
    public class HelloWorldAPIController : ApiController
    {
            [Route("api/ReturnTextAPI/GetReturnText")]
            [HttpGet]
            public string GetReturnText()
            {
                ReturnTextModel text = new ReturnTextModel();
                text.returnText = "Hello World";
                return text.returnText;
            }

            [Route("api/ReturnTextAPI/InsertStuff")]
            [HttpPost]
            public void InsertStuff(InsertStuffModel insertStuff)
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["TestDatabase"].ConnectionString))
                {
                    connection.Open();
                    string sql = "INSERT INTO Test(stuff, moreStuff, baseStuff, moreBaseStuff) VALUES (@stuff, @moreStuff, @baseStuff, @moreBaseStuff)";
                    using (SqlCommand cmd = new SqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@stuff", insertStuff.stuff);
                        cmd.Parameters.AddWithValue("@moreStuff", insertStuff.moreStuff);
                        cmd.Parameters.AddWithValue("@baseStuff", insertStuff.baseStuff);
                        cmd.Parameters.AddWithValue("moreBaseStuff", insertStuff.moreBaseStuff);

                        cmd.ExecuteNonQuery();
                    }
                }

            }
    }
}

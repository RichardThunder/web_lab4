using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace LAB4
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        private SqlCommand cmd = null;
        private SqlConnection conn = null;
        private String sql = null;
        ///创建数据库连接方法封装
        public void openDatabase()
        {
            string con;
            con = "Data Source=.;Initial Catalog=students;Integrated Security=True";

            conn = new SqlConnection(con);

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                //Response.Write("<script>alert('Connected!');</script>");
            }
        }
        [WebMethod]
        public DataSet SelStudent(String xuehao)
        {
            openDatabase();
            String sql = "select * from Data where ID='" + xuehao + "'";
            SqlDataAdapter sqlad = new SqlDataAdapter(sql, conn);//创建SqlDataAdapter对象并执行sql查询
            DataSet ds = new DataSet();
            sqlad.Fill(ds);
            if (conn.State != ConnectionState.Closed)
            {
                conn.Close();
            }
            return ds;
        }

       
    }
}

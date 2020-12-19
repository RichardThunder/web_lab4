using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LAB4
{
    public partial class Lab4 : System.Web.UI.Page
    {
        public object MessageBox { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public String DataSetToString(DataSet ds)//类型转换
        {
            string s = "";
            string[] w = { "学号：", "姓名：", "课程名：", "分数:","考试时间：", "地点：", "教师：" };
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                for (int j = 0; j < ds.Tables[0].Columns.Count; j++)
                {
                    s += w[j] + ds.Tables[0].Rows[i][j].ToString() + "\n";//DataTable转化成String类型
                }
            }
            return s;
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            weather.WeatherWS weather = new weather.WeatherWS();
            string[] str = new string[32];
            str = weather.getWeather(TextBox1.Text, "");
            TextBox2.Text = str[1] + str[3] + str[4] + str[5] + str[6];
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            localhost.WebService1 stu = new localhost.WebService1();
            string ds;
            ds = DataSetToString(stu.SelStudent(TextBox3.Text));

            TextBox4.Text = ds;
        }
    }
}
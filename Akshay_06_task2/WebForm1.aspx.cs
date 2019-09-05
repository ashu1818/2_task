using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Akshay_06_task2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection connStr = new SqlConnection(ConfigurationManager.ConnectionStrings["strConn"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(Server.MapPath("Images")))
            {
                Directory.CreateDirectory(Server.MapPath("Images"));
            }

            string img = (Server.MapPath("Images")+"\\" + fupload.FileName);
            string dbimg = "~/Images/" + fupload.FileName;
            fupload.SaveAs(img);

            SqlCommand cmd = new SqlCommand("Insert into task_2(ImageName,Imagep) values(@iname,@iurl)", connStr);
            cmd.Parameters.AddWithValue("@iname", IName.Text);
            cmd.Parameters.AddWithValue("@iurl", dbimg);

            connStr.Open();
            cmd.ExecuteNonQuery();
            connStr.Close();
        }
    }
}
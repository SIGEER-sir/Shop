using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Data.Linq;
using System.Linq.Expressions;
using System.Data.Linq.Mapping;
using System.Configuration;
using BLL;
using static System.Web.HttpResponse;
namespace Shop
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        [Table]
        public class Product
        {
            public string P_name;
            public string P_number;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            UsersAction users = new UsersAction();
            DataTable table1 = users.Search("1");
            if (table1 != null)
            {
                HttpCookie cookie = new HttpCookie("nowday", DateTime.Now.ToString());
                string name = cookie.Name;
                Response.Write(name);
                
            }
            else
            {
                Response.Write(users.result);
                Response.Write("查无此表");
            }
            //DataContext db = new DataContext(@"D:\SHOP_.mdf");

            //if (db.DatabaseExists())
            //{

            //    Table<Product> products = db.GetTable<Product>();

            //    var qu = from c in products
            //             where c.P_name == "大米1"
            //             select c;
            //    foreach (var s in qu)
            //    {
            //        Response.Write(s.P_number);
            //    }
            //}
            //else
            //{
            //    Response.Write(db.DatabaseExists());
            //}

            //string connString = ConfigurationManager.ConnectionStrings["SHOP"].ConnectionString;//获取连接字符串
            //SqlConnection conn = new SqlConnection(connString);
            //conn.Open();
            //if (conn.State == ConnectionState.Open) Response.Write("lianshang");

            //string s1 = "select * from Product where P_id=1";
            //SqlConnection sql = new SqlConnection("Data Source=.;Initial Catalog=SHOP;User ID=sa;Password=12345");
            //sql.Open();
            //if (sql.State == ConnectionState.Open)
            //    Response.Write("数据库打开了\n");
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            //SqlCommand cmd = new SqlCommand(s1, sql);


            //int a = cmd.ExecuteNonQuery();
            //Response.Write("执行了" + a + "条语句");
            //sqlDataAdapter.SelectCommand = cmd;
            ////存放数据
            //SqlDataAdapter sda = new SqlDataAdapter(s1, sql);

            //DataTable table = new DataTable();
            //sda.Fill(table);
            //if (table != null)
            //{
            //    Response.Write(table.PrimaryKey);
            //    foreach (DataRow i in table.Rows)
            //        foreach(DataColumn x in table.Columns)
            //        Response.Write(i[x]);
            //}
            //else
            //{
            //    Response.Write("数据表为空");
            //}

            //DataSet ds = new DataSet();
            //sqlDataAdapter.Fill(ds, "Product");

            ////var q = from c in table 
            //sql.Close();
        }
    }
}
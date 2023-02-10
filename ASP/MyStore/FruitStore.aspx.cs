using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyStore
{
    public partial class FruitStore : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GetFruitPrice(string fruit)
        {
            string connectionString = "Data Source = DESKTOP-OJG6C99\\SQLEXPRESS; initial catalog = store; integrated security = true;";
            SqlConnection connect = new SqlConnection(connectionString);
            SqlDataAdapter sda = new SqlDataAdapter("getfruit", connect);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            SqlParameter parameter = new SqlParameter();
            parameter.ParameterName = "@fname";
            parameter.Value = fruit;
            sda.SelectCommand.Parameters.Add(parameter);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            FruitPrice.Text = this.GridView1.Rows[0].Cells[0].Text;
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.FruitImage.ImageUrl = "~/Fruit Images/" + DropDownList1.SelectedValue + ".png";
            GetFruitPrice(DropDownList1.SelectedValue);
        }
    }
}
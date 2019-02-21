using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebSP
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                GetData();
        }
        protected void btnSerach_Click(object sender, EventArgs e)
        {
            GetData();
        }
        private void AttachParameter(SqlCommand command, string parameterName, Control control)
        {
            if (control is TextBox && ((TextBox)control).Text != string.Empty)
            {
                var parameter = new SqlParameter(parameterName, ((TextBox)control).Text);
                command.Parameters.Add(parameter);
            }
            else if (control is DropDownList && ((DropDownList)control).SelectedValue != "-1")
            {
                var parameter = new SqlParameter(parameterName, ((DropDownList)control).SelectedValue);
                command.Parameters.Add(parameter);
            }
        }
        private void GetData()
        {
            //string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            string cs = ConfigurationManager.ConnectionStrings["SampleConnectionString"].ConnectionString;
            using (var con = new SqlConnection(cs))
            {
                var cmd = new SqlCommand("spSearchPerson3", con);
                cmd.CommandType = CommandType.StoredProcedure;
                AttachParameter(cmd, "@NameLike", txtNameLike);
                AttachParameter(cmd, "@SalaryGreaterThan", txtSalaryGreaterThan);
                con.Open();
                gvEmployees.DataSource = cmd.ExecuteReader();
                gvEmployees.DataBind();
            }
        }
    }
}
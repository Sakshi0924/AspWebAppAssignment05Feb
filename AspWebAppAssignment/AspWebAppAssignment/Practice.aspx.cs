using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspWebAppAssignment
{
    public partial class Practice : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = null;
            if (!Page.IsPostBack)
            {
                using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings[1].ToString()))
                {
                    using (SqlCommand cmd = new SqlCommand("Select * from CountryTable", cn))
                    {
                        cn.Open();
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            dt = new DataTable();
                            da.Fill(dt);
                            DropDownList1.DataSource = dt;
                            DropDownList1.DataValueField = "CId";
                            DropDownList1.DataTextField = "CName";
                            DropDownList1.DataBind();
                        }
                        
                    }
                }
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList2.Items.Clear();
            DropDownList3.Items.Clear();
            DataTable dt = null;
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings[1].ToString()))
            {
                 using (SqlCommand cmd = new SqlCommand("Select * from StateTable  where CId="+DropDownList1.SelectedItem.Value, cn))
                 {
                        cn.Open();
                         using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                             dt = new DataTable();
                             da.Fill(dt);
                             DropDownList2.DataSource = dt;
                             DropDownList2.DataValueField = "SId";
                             DropDownList2.DataTextField = "SName";
                             DropDownList2.DataBind();

                         }
                    
                    }
            }
            
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList3.Items.Clear();
           
            DataTable dt = null;
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings[1].ToString()))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from CityTable where SId="+DropDownList2.SelectedItem.Value, cn))
                {
                    cn.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                          dt = new DataTable();
                          da.Fill(dt);
                          DropDownList3.DataSource = dt;
                          DropDownList3.DataValueField = "CityId";
                          DropDownList3.DataTextField = "CityName";
                          DropDownList3.DataBind();
                                               
                    }
                }
            }
        }
    }
}
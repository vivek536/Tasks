using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RegistrationForm
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //String cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
                DropDownList2.Items.Clear();
                DropDownList3.Items.Clear();
                DropDownList1.Items.Insert(0, new ListItem("Select country", "-1"));
                DropDownList1.DataBind();
                DropDownList2.Items.Insert(0, new ListItem("Select state", "-1"));
                DropDownList2.DataBind();
                DropDownList3.Items.Insert(0, new ListItem("Select city", "-1"));

                DropDownList3.DataBind();
              
                DropDownList2.Enabled = false;
                DropDownList3.Enabled = false;
                
                using (SqlConnection sqlConnection = new SqlConnection("Data Source=EPINHYDW00FA\\MSSQLSERVER1;Initial Catalog=Registration;Integrated Security=True"))
                {

                    DropDownList1.SelectedItem.Text = "Select Country";

                    sqlConnection.Open();
                    SqlCommand cmd = new SqlCommand("select countryID,countryName from country", sqlConnection);
                    DropDownList1.DataSource = cmd.ExecuteReader();
                    //DropDownList1.Items.Insert(0, new ListItem("Select country", "-1"));
                    DropDownList1.DataTextField = "countryName";
                    DropDownList1.DataValueField = "countryID";
                  
                    DropDownList1.DataBind();
                   


                }
            }


        }
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int CountryId = Convert.ToInt32(DropDownList1.SelectedValue);
            //DropDownList2.Items.Clear();
            DropDownList3.Items.Clear();
            DropDownList2.Items.Insert(0, new ListItem("Select state", "-1"));
            DropDownList2.DataBind();
            DropDownList3.Items.Insert(0, new ListItem("Select city", "-1"));
            //DropDownList2.DataBind();

            DropDownList3.DataBind();
            if (CountryId ==0)
            {
                DropDownList2.Enabled = false;
                DropDownList3.Enabled = false;
            }
            //String cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            else
            {
                using (SqlConnection sqlConnection = new SqlConnection("Data Source=EPINHYDW00FA\\MSSQLSERVER1;Initial Catalog=Registration;Integrated Security=True"))
                {

                    sqlConnection.Open();

                    SqlCommand cmd = new SqlCommand("select stateID,stateName from state where countryID='" + CountryId + "' or countryID='" +0+ "' order by  stateID ", sqlConnection);
                    DropDownList2.Enabled = true;
                    DropDownList2.DataSource = cmd.ExecuteReader();
                    //DropDownList2.Items.Insert(0, new ListItem("Select state", "-1"));
                    DropDownList2.DataTextField = "stateName";
                    DropDownList2.DataValueField = "stateID";
                    
                    DropDownList2.DataBind();
                }
            }
                
            

        }
        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int CountryId = Convert.ToInt32(DropDownList1.SelectedValue);
            int stateId = Convert.ToInt32(DropDownList2.SelectedValue);
            DropDownList3.Items.Insert(0, new ListItem("Select city", "-1"));
            if (CountryId == 0 || stateId == 0)
            {
                
                DropDownList3.Enabled = false;
            }

            else
            {
                //String cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
                using (SqlConnection sqlConnection = new SqlConnection("Data Source=EPINHYDW00FA\\MSSQLSERVER1;Initial Catalog=Registration;Integrated Security=True"))
                {

                    sqlConnection.Open();
                    //int CountryId = Convert.ToInt32(DropDownList1.SelectedValue);
                    SqlCommand cmd = new SqlCommand("select cityID,cityName from city where countryID='" + 0 + "' or ( countryID='" + CountryId + "' and stateID='" + stateId + "') order by cityID", sqlConnection);
                    DropDownList3.Enabled = true;
                    DropDownList3.DataSource = cmd.ExecuteReader();
                    DropDownList3.DataTextField = "cityName";
                    DropDownList3.DataValueField = "cityID";
                    //DropDownList3.Items.Add(new ListItem("Select city", "-1"));
                    DropDownList3.DataBind();
                }
            }


        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            //Label1.Text = "You Clicked the Button.";
            using (SqlConnection sqlConnection = new SqlConnection("Data Source=EPINHYDW00FA\\MSSQLSERVER1;Initial Catalog=Registration;Integrated Security=True"))
            {

                //sqlConnection.Open();
                //int CountryId = Convert.ToInt32(DropDownList1.SelectedValue);
                var name = Name.Text;
                var email = Email.Text;
                var contact = Contact.Text;
                var country = DropDownList1.SelectedItem.Value;
                var state = DropDownList2.SelectedItem.Value;
                var city = DropDownList3.SelectedItem.Value;
                var date = Calendar1.SelectedDate.ToShortDateString();
                String gen = " ";
                if (RadioButton1.Checked)
                {
                    gen = RadioButton1.Text;
                }
                else
                {
                    gen = RadioButton2.Text;
                }
                String stream = " ";
                bool c = false;
                if (Java.Checked)
                {
                    stream = Java.Text;
                    c = true;
                }
                if (Dotnet.Checked)
                {
                    if (c == true)
                        stream = stream + " " + Dotnet.Text;
                    else
                    {
                        stream = Dotnet.Text;
                        c = true;
                    }

                }
                if (SDET.Checked)
                {
                    if (c == true)
                        stream = stream + " " + SDET.Text;
                    else
                    {
                        stream = SDET.Text;
                        c = true;
                    }
                }
                if (name == " " || email == " " || contact == " " || country == " " || state == " " || city == " " || date == " "||stream==" "||gen==" ")
                {
                    Response.Write("<html><body><p>Please enter the fields</p></body></html>");
                }
                else
                {
                    sqlConnection.Open();
                    SqlCommand command;
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    String sqlquery = "insert into RegisterUser(Name,Email,Contact,Gender,Stream,Country,State,City,DOB) values('" + Name.Text + "','" + Email.Text + "','" + Contact.Text + "','" + gen + "','" + stream + "','" + DropDownList1.SelectedItem + "','" + DropDownList2.SelectedItem + "','" + DropDownList3.SelectedItem + "','" + Calendar1.SelectedDate.ToShortDateString() + "') ";
                    command = new SqlCommand(sqlquery, sqlConnection);
                    adapter.InsertCommand = new SqlCommand(sqlquery, sqlConnection);
                    adapter.InsertCommand.ExecuteNonQuery();
                    command.Dispose();
                    //if (result < 0)
                    //{
                    //    Response.Write("Error");
                    //}
                    Session["Name"] = Name.Text;
                    Session["Email"]=Email.Text;
                    Name.Text = "";
                    Email.Text = "";
                    RadioButton1.Checked = false;
                    RadioButton2.Checked = false;
                    Java.Checked = false;
                    Dotnet.Checked = false;
                    SDET.Checked = false;
                    DropDownList1.ClearSelection();
                    DropDownList2.ClearSelection();
                    DropDownList3.ClearSelection();
                    Response.Redirect("~/WebForm2.aspx");
                   
                }
            }

        }
    }
}
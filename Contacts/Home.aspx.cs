using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ContactClass;
using ContactClass.data;
namespace Contacts
{
    public partial class Home : System.Web.UI.Page
    {


        static SqlDataReader dr;
        SqlCommand cmd,cmdDelete;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SqlConnection con = new SqlConnection("data source=(local);initial catalog=imenik;integrated security=True");
                con.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Adresar", con);
                SqlDataReader rd = cmd.ExecuteReader();
                table.Append("")

            }

            Adresar a = new Adresar();
            a.ID = 2;
            AdresarDK.Delete(a);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                listOfContacts1.Items.Add(dr["Name"].ToString()+" "+ dr["LastName"].ToString()+" "+ dr["PhoneNumber"].ToString()+" "+ dr["ID"].ToString());
              listOfContacts2.Items.Add(dr["LastName"].ToString());
               
                listOfContacts3.Items.Add(dr["PhoneNumber"].ToString());
                listOfContacts4.Items.Add(dr["ID"].ToString());

            }
            dr.Close();



        }

        protected void submit_Click(object sender, EventArgs e)
        {
            Adresar a = new Adresar();
            a.Name = nameInput.Text;
            a.LastName = lastNameInput.Text;
            a.PhoneNumber = phoneInput.Text;

            AdresarDK.Insert(a);
        }

        

       
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySQL
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            //get user and pass and remove extra spaces
            string user = txtuser.Text.Trim();
            string pass = txtpass.Text.Trim();
            //check if user and pass is empty
            if (user == "" || pass == "")
            {
                MessageBox.Show("Please Enter Username and Password ");
                return; //stop the login process
            }
            //call db connection string
            DBConnect db = new DBConnect();
            try
            {
                //main function/s
                db.Open();
                //sql query to count matching user and pass
                string query = "SELECT COUNT(*) FROM users WHERE " + "username=@username AND password=@password";
                //create sql command
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query,db.Connection);
                //add parameters to prevent sql injection
                //@ used to get the record on localhost db
                cmd.Parameters.AddWithValue("@username", user);
                cmd.Parameters.AddWithValue("@password", pass);
                //execute query and get results
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count ==1)
                {
                    //if one record found
                    MessageBox.Show("Login Successful!");
                    //open dashboard
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                    this.Hide();



                }
                else
                {
                    //no accc found
                    MessageBox.Show("Invalid User or Password");
                }

            }
            catch (Exception ex) {        
                //show error message
                MessageBox.Show(ex.Message);


            }
            finally {
                // close db
                db.Close();
            }

            



        }
    }
}

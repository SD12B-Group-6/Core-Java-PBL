using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace gender_equality_app
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            // remove the focus from the textboxes
            this.ActiveControl = label1;
        }

        private void firstname_Enter(object sender, EventArgs e)
        {
            String fname = firstname.Text;
            if(fname.ToLower().Trim().Equals("first name"))
            {
                firstname.Text = "";
                firstname.ForeColor = Color.Black;
            }
        }

        private void firstname_Leave(object sender, EventArgs e)
        {
            String fname = firstname.Text;
            if (fname.ToLower().Trim().Equals("first name") || fname.Trim().Equals(""))
            {
                firstname.Text = "first name";
                firstname.ForeColor = Color.Gray;
            }
        }

        private void lastname_Enter(object sender, EventArgs e)
        {
            String lname = lastname.Text;
            if (lname.ToLower().Trim().Equals("last name"))
            {
                lastname.Text = "";
                lastname.ForeColor = Color.Black;
            }
        }

        private void lastname_Leave(object sender, EventArgs e)
        {
            String lname = lastname.Text;
            if (lname.ToLower().Trim().Equals("last name") || lname.Trim().Equals(""))
            {
                lastname.Text = "last name";
                lastname.ForeColor = Color.Gray;
            }
        }

        private void emailaddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailaddress_Enter(object sender, EventArgs e)
        {
            String emailad = emailaddress.Text;
            if (emailad.ToLower().Trim().Equals("email address")) ;
            {
                emailaddress.Text = "";
                emailaddress.ForeColor = Color.Black;
            }

        }
        private void emailaddress_Leave(object sender, EventArgs e)
        {
            String emailad = emailaddress.Text;
            if (emailad.ToLower().Trim().Equals("email address") || emailad.Trim().Equals(""))
            {
                emailaddress.Text = "email address";
                emailaddress.ForeColor = Color.Gray;
            }

        }

        private void username_Enter(object sender, EventArgs e)
        {
            String uname = username.Text;
            if (uname.ToLower().Trim().Equals("username")) 
            {
                username.Text = "";
                username.ForeColor = Color.Black; 
            }
        }

        private void username_Leave(object sender, EventArgs e)
        {
            String uname = username.Text;
            if (uname.ToLower().Trim().Equals("username") || uname.Trim().Equals(""))
            {
                username.Text = "email address";
                username.ForeColor = Color.Gray;
            }
        }

        private void createbutton_Click(object sender, EventArgs e)
        {
            // add a user
          
        }
    }
}

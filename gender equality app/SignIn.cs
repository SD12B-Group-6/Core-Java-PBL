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
    public partial class SignIn : Form
    {
       

        public SignIn()
        {
            InitializeComponent();

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        private void signinbutton_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            String username = Username.Text;
            String password = Password.Text; 

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `signin` WHERE 'username' = @usn and 'password' = @pass", db.getConnection());

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            //checks if the user exists or not
            if (table.Rows.Count > 0 )

            {
                MessageBox.Show("YES");
                this.Hide();
                Dashboard form = new Dashboard();
                form.Show();
            }
            else
            {
                MessageBox.Show("NO, SIGN UP NOW");
                this.Hide();
                RegisterForm form = new RegisterForm();
                form.Show(); 

            }
                
        }


        private void Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

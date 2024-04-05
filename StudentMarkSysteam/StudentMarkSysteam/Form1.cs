using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentMarkSysteam
{
    public partial class Login : Form
    {
        string connectionString;
        SqlConnection con;
        public Login()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            connectionString = "Server = DESKTOP-DI6RLQU\\SQLEXPRESS; Database = StudentGrading; Integrated Security = True";
            con = new SqlConnection(connectionString);
        }

        private void Usertxt_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = Usertxt.Text;
            string password = Passtxt.Text;
            string query = "select * from Account where username = '"+username+"' and u_password = '"+password+"'";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rs = cmd.ExecuteReader();
            if (rs.Read())
            {
                string role = rs["u_role"].ToString();
                if (role.Equals("admin"))
                {
                    AdminPage f = new AdminPage();
                    this.Hide();
                    f.ShowDialog();
                    this.Dispose();
                }
                else if (role.Equals("user"))
                {
                    UserPage p = new UserPage();
                    this.Hide();
                    p.ShowDialog();
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("You have not been assigned to any role");
                }
            }
            else
            {
                MessageBox.Show("Wrong usename or password");
            }
            con.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {}
    }
}

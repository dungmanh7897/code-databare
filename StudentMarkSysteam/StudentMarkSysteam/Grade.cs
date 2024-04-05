using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace StudentMarkSysteam
{
    public partial class Grade : Form
    {
        string connectionString;
        SqlConnection con;
        public Grade()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            connectionString = "Server = DESKTOP-DI6RLQU\\SQLEXPRESS; Database = StudentGrading; Integrated Security = True";
            con = new SqlConnection(connectionString);
        }

        private void Grade_Load(object sender, EventArgs e)
        {
            FillGrid();
        }
        public void FillGrid()
        {
            string query = "SELECT Mark.S_ID, Students.S_Name, Mark.C_ID, Course.C_Name, Mark.attendace, Mark.assm1, Mark.assm2\r\nFROM Mark\r\nLEFT JOIN Students ON Mark.S_ID = Students.S_ID\r\nLEFT JOIN Course ON Mark.C_ID = Course.C_ID;";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    con.Open();
                    DataTable table = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(table);
                    dgvGraded.DataSource = table;
                }
            }
        }

        private void dgvGraded_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvGraded.Rows[e.RowIndex];
                txtSID.Text = row.Cells["S_ID"].Value.ToString();
                txtCID.Text = row.Cells["C_ID"].Value.ToString();
                txtAtten.Text = row.Cells["attendace"].Value.ToString();
                txtAssm1.Text = row.Cells["assm1"].Value.ToString();
                txtAssm2.Text = row.Cells["assm2"].Value.ToString();
                txtSID.Enabled = false;
                txtCID.Enabled = false;
                btnAdd.Visible = false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            AdminPage exit = new AdminPage();
            this.Hide();
            exit.ShowDialog();
            this.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtSID.Text = "";
            txtCID.Text = "";
            txtAtten.Text = "";
            txtAssm1.Text = "";
            txtAssm2.Text = "";
            btnAdd.Visible = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string sid = txtSID.Text;
            string cid = txtCID.Text;
            string atten = txtAtten.Text;
            string assm1 = txtAssm1.Text;
            string assm2 = txtAssm2.Text;
            string insert = "insert into Mark values(" + sid + ",'" + cid + "', '" + atten + "' , '" + assm1 + "' , '" + assm2 + "')";
            con.Open();
            SqlCommand cmd = new SqlCommand(insert, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Add succesfull");
            con.Close();
            FillGrid();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string sid = txtSID.Text;
            string cid = txtCID.Text;
            string atten = txtAtten.Text;
            string assm1 = txtAssm1.Text;
            string assm2 = txtAssm2.Text;
            string insert = "update Mark set attendace = '" + atten + "', assm1 = '" + assm1 + "', assm2 = '" + assm2 + "' where C_ID = '" + cid + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(insert, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Update succesfull");
            con.Close();
            FillGrid();
        }

    }
}

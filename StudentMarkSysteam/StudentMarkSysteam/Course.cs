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
using System.Xml.Linq;

namespace StudentMarkSysteam
{
    public partial class Course : Form
    {
        string connectionString;
        SqlConnection con;
        public Course()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            connectionString = "Server = DESKTOP-DI6RLQU\\SQLEXPRESS; Database = StudentGrading; Integrated Security = True";
            con = new SqlConnection(connectionString);
        }

        private void Course_Load(object sender, EventArgs e)
        {
            FillGrid();
        }
        public void FillGrid()
        {
            string query = "select * from Course";
            con.Open();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            adapter.Fill(table);
            dgvCourse.DataSource = table;
            con.Close();
        }
        private void dgvCourse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvCourse.Rows[e.RowIndex];
                txtID.Text = row.Cells["C_ID"].Value.ToString();
                txtName.Text = row.Cells["C_Name"].Value.ToString();
                txtDes.Text = row.Cells["Course_description"].Value.ToString();
                txtStime.Text = row.Cells["C_Sarttime"].Value.ToString();
                txtEtime.Text = row.Cells["C_Endtime"].Value.ToString();
                txtTeacher.Text = row.Cells["C_Teacher"].Value.ToString();
                txtID.Enabled = false;
                btnAdd.Visible = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtName.Text = "";
            txtDes.Text = "";
            txtStime.Text = "";
            txtEtime.Text = "";
            txtTeacher.Text = "";
            btnAdd.Visible = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            string name = txtName.Text;
            string des = txtDes.Text;
            string s_time = txtStime.Text;
            string e_time = txtEtime.Text;
            string teacher = txtTeacher.Text;
            string insert = "insert into Course values("+id+", '"+name+"', '"+des+"', '"+s_time+"', '"+e_time+"', '"+teacher+"')";
            con.Open();
            SqlCommand cmd = new SqlCommand(insert, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Add succesfull");
            con.Close();
            FillGrid();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            string name = txtName.Text;
            string des = txtDes.Text;
            string s_time = txtStime.Text;
            string e_time = txtEtime.Text;
            string teacher = txtTeacher.Text;
            string update = "update Course set C_name = '" + name + "', Course_description = '" + des + "', C_Sarttime = '" + s_time + "', C_Endtime = '" + e_time + "', C_Teacher = '"+ teacher + "' where C_ID = '"+id+"'";
            con.Open();
            SqlCommand cmd = new SqlCommand(update, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Update succesfull");
            con.Close();
            FillGrid();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var answer = MessageBox.Show("Are you sure to delete? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                string id = txtID.Text;
                string delete = "delete from Course where C_ID =" + id;
                con.Open();
                SqlCommand cmd = new SqlCommand(delete, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("delete succesfully");
                con.Close();
                FillGrid();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            AdminPage exit = new AdminPage();
            this.Hide();
            exit.ShowDialog();
            this.Dispose();
        }
    }
}

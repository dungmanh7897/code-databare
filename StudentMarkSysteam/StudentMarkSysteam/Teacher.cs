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

namespace StudentMarkSysteam
{
    public partial class Teacher : Form
    {
        string connectionString;
        SqlConnection con;
        public Teacher()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            connectionString = "Server = DESKTOP-DI6RLQU\\SQLEXPRESS; Database = StudentGrading; Integrated Security = True";
            con = new SqlConnection(connectionString);
        }

        private void Teacher_Load(object sender, EventArgs e)
        {
            FillGrid();
        }
        public void FillGrid()
        {
            string query = "select * from Teachers";
            con.Open();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            adapter.Fill(table);
            dgvTeacher.DataSource = table;
            con.Close();
        }

        private void dgvTeacher_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvTeacher.Rows[e.RowIndex];
                txtID.Text = row.Cells["T_ID"].Value.ToString();
                txtName.Text = row.Cells["T_Name"].Value.ToString();
                txtGender.Text = row.Cells["T_Gender"].Value.ToString();
                txtdoB.Text = row.Cells["T_Dateofbirth"].Value.ToString();
                txtAddress.Text = row.Cells["T_Address"].Value.ToString();
                txtRec.Text = row.Cells["Recruitment"].Value.ToString();
                txtID.Enabled = false;
                btnAdd.Visible = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtName.Text = "";
            txtGender.Text = "";
            txtdoB.Text = "";
            txtAddress.Text = "";
            txtRec.Text = "";
            btnAdd.Visible = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            string name = txtName.Text;
            string gender = txtGender.Text;
            string doB = txtdoB.Text;
            string address = txtAddress.Text;
            string rec = txtRec.Text;
            string insert = "insert into Teachers values(" + id + ",'" + name + "', '" + gender + "' , '" + doB + "', '" + address +"' , '" + rec + "')";
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
            string gender = txtGender.Text;
            string doB = txtdoB.Text;
            string address = txtAddress.Text;
            string rec = txtRec.Text;
            string update = "update Teachers set T_Name = '" + name + "', T_Gender = '" + gender + "', T_Dateofbirth = '" + doB + "', T_Address = '" + address + "', Recruitment = '"+rec+"' where T_ID = '" + id + "'";
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
                string delete = "delete from Teachers where T_ID =" + id;
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

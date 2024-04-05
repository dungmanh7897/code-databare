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
    public partial class Student : Form
    {
        string connectionString;
        SqlConnection con;
        public Student()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            connectionString = "Server = DESKTOP-DI6RLQU\\SQLEXPRESS; Database = StudentGrading; Integrated Security = True";
            con = new SqlConnection(connectionString);
            btnAdd.Visible = true;
            btnUpdate.Visible = true;
            btnDelete.Visible = true;  
            txtID.Enabled = true;
        }

        private void Student_Load(object sender, EventArgs e)
        {
            FillGrid();
        }
        public void FillGrid()
        {
            string query = "select * from Students";
            con.Open();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            adapter.Fill(table);
            dgvStudent.DataSource = table;
            con.Close();
        }

        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvStudent.Rows[e.RowIndex];
                txtID.Text = row.Cells["S_ID"].Value.ToString();
                txtName.Text = row.Cells["S_Name"].Value.ToString();
                txtGender.Text = row.Cells["S_Gender"].Value.ToString();
                txtDoB.Text = row.Cells["S_Dateofbirth"].Value.ToString();
                txtAddress.Text = row.Cells["S_Address"].Value.ToString();
                txtClass.Text = row.Cells["S_Class"].Value.ToString();
                txtCitizenid.Text = row.Cells["Citizen_idenfitication"].Value.ToString();
                txtID.Enabled = false;
                btnAdd.Visible = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            string name = txtName.Text; 
            string gender = txtGender.Text; 
            string doB = txtDoB.Text;
            string address = txtAddress.Text;
            string Class = txtClass.Text;
            string cid = txtCitizenid.Text;
            string insert = "insert into Students values("+id+",'" + name + "', '"+address+ "' , '"+Class+"','" + gender+"', '"+doB+"', '"+cid+"')";
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
            string doB = txtDoB.Text;
            string address = txtAddress.Text;
            string Class = txtClass.Text;
            string cid = txtCitizenid.Text;
            string update = "update Students set S_Name = '" + name + "', S_Address = '" + address + "' , S_Class = '" + Class + "', S_Gender = '" + gender + "', S_Dateofbirth = '" + doB + "', Citizen_idenfitication = '" + cid + "' where S_ID = '"+id+"'";
            con.Open();
            SqlCommand cmd = new SqlCommand(update, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Update succesfully");
            con.Close();
            FillGrid();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var answer = MessageBox.Show("Are you sure to delete? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                string id = txtID.Text;
                string delete = "delete from Students where S_ID =" + id;
                con.Open();
                SqlCommand cmd = new SqlCommand(delete, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("delete succesfully");
                con.Close();
                FillGrid();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnAdd.Visible = true;
            txtName.Text = "";
            txtAddress.Text = "";
            txtClass.Text = "";
            txtCitizenid.Text = "";
            txtDoB.Text = "";
            txtGender.Text = "";
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

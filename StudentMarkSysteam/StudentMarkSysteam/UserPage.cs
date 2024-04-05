﻿using System;
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
    public partial class UserPage : Form
    {
        string connectionString;
        SqlConnection con;
        public UserPage()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            connectionString = "Server = DESKTOP-DI6RLQU\\SQLEXPRESS; Database = StudentGrading; Integrated Security = True";
            con = new SqlConnection(connectionString);
            btnUpdate.Visible = true;
            txtID.Enabled = true;
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
            string update = "update Students set S_Name = '" + name + "', S_Address = '" + address + "' , S_Class = '" + Class + "', S_Gender = '" + gender + "', S_Dateofbirth = '" + doB + "', Citizen_idenfitication = '" + cid + "' where S_ID = '" + id + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(update, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Update succesfully");
            con.Close();
            FillGrid();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtAddress.Text = "";
            txtClass.Text = "";
            txtCitizenid.Text = "";
            txtDoB.Text = "";
            txtGender.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Login exit = new Login();
            this.Hide();
            exit.ShowDialog();
            this.Dispose();
        }

        private void dgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                txtID.Enabled = false;            }
        }

        private void UserPage_Load(object sender, EventArgs e)
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
    }
}

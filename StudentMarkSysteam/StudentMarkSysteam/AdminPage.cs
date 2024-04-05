using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentMarkSysteam
{
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {}

        private void button1_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            this.Hide();
            student.ShowDialog();
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();
            this.Hide();
            teacher.ShowDialog();
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Course course = new Course();
            this.Hide();
            course.ShowDialog();
            this.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Grade grade = new Grade();
            this.Hide();
            grade.ShowDialog();
            this.Dispose();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login logout = new Login();
            this.Hide();
            logout.ShowDialog();
            this.Dispose();
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {
        }
    }
}

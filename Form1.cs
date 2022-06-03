using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PatientForm frm = new PatientForm();
            frm.MdiParent = this;
            frm.TopLevel = false;
            frm.ControlBox = false;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Show();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            PatientForm frm = new PatientForm();
            frm.MdiParent = this;
            frm.TopLevel = false;
            frm.ControlBox = false;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if(WindowState.ToString()== "Normal")
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
                this.WindowState = FormWindowState.Normal;
            
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DoctorForm frm = new DoctorForm();
            frm.MdiParent = this;
            frm.TopLevel = false;
            frm.ControlBox = false;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            TestForm frm = new TestForm();
            frm.MdiParent = this;
            frm.TopLevel = false;
            frm.ControlBox = false;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}

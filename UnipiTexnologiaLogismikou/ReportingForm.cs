using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnipiTexnologiaLogismikou
{
    public partial class ReportingForm : Form
    {
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        Admin admin = new Admin();
        public ReportingForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = admin.ShowGradesRange(textBox1.Text,textBox2.Text);
            dataGridView1.DataSource = dt;
        }

        

        private void frameworkbutton_Click(object sender, EventArgs e)
        {
            var result = admin.CountFrameworks(textBox3.Text.Trim());
            label4.Text = result.ToString();
        }


        private void ReportingForm_Load(object sender, EventArgs e)
        {

        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            AdminMenu forumform = new AdminMenu();
            forumform.Show(this);
            this.Hide();
        }

        private void ReportingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }   
}

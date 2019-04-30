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
    public partial class ProgressForm : Form
    {
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        ProgressInfo grd = new ProgressInfo();
        ProgressInfoTools grddal = new ProgressInfoTools();
        Admin admin = new Admin();

        public ProgressForm()
        {
            InitializeComponent();
            progressBar1.Value = 0;
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            AdminMenu adminMenu = new AdminMenu();
            adminMenu.Show(this);
            this.Hide();
        }

        private void Viewbutton_Click(object sender, EventArgs e)
        {
            DataTable dt = ProgressInfoTools.Select();
            dataGridView1.DataSource = dt;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value =admin.SelectProgress(textBox1.Text);

        }

       

        private void ProgressForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ProgressForm_Load(object sender, EventArgs e)
        {

        }
    }
}

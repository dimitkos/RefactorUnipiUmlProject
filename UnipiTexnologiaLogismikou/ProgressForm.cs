using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnipiTexnologiaLogismikou
{
    public partial class ProgressForm : Form
    {

        ProgressInfo grd = new ProgressInfo();
        ProgressInfoTools grddal = new ProgressInfoTools();

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
            progressBar1.Value = 0;
            int i = Convert.ToInt32(textBox1.Text); // User id to check
            int y = 0;
            progressBar1.Step = 1; 

            if (i == 1)
            {
                y = 70;
            }
            else if (i == 2)
            {
                y = 30;
            }
            else if (i == 3)
            {
                y = 90;
            }
            else if (i > 3 && i < 100)
            {
                y = 0;
            }

            for (int x = 0; x <= y; x++)
            {
                progressBar1.PerformStep();
            }
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

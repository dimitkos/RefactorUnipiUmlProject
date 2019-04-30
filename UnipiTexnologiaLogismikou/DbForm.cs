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
    public partial class DbForm : Form
    {
        public DbForm()
        {
            InitializeComponent();
        }

        StudentInfo std = new StudentInfo();
        StudentTools stddal = new StudentTools();

        private void button1_Click(object sender, EventArgs e)
        {
            std.id = amtxt.Text;
            std.namesurname = nametxt.Text;
            std.thesis = thesistxt.Text;
            std.startdate = DateTime.Now;
            std.languages = languagestxt.Text;
            std.framework = frameworktxt.Text;

            bool success = stddal.Insert(std);
            if (success == true)
            {
                //Data successfully Inserted
                MessageBox.Show("Data added successfully");
                clear();
            }
            else
            {
                //Failed to insert data
                MessageBox.Show("Failed to add data");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            std.id = amtxt.Text;
            std.namesurname = nametxt.Text;
            std.thesis = thesistxt.Text;
            std.startdate = DateTime.Now;
            std.languages = languagestxt.Text;
            std.framework = frameworktxt.Text;

            bool success = stddal.Update(std);
            if(success==true)
            {
                MessageBox.Show("Successfully update");
                
            }
            else
            {
                MessageBox.Show("Failed to update");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            std.id = amtxt.Text;
            bool success = stddal.Delete(std);
            if (success == true)
            {
                MessageBox.Show("User deleted successfully");
                clear();
            }
            else
            {
                MessageBox.Show("Failed to delete user");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataTable dt = stddal.Select();
            dataGridView1.DataSource = dt;
        }

        private void DbForm_Load(object sender, EventArgs e)
        {

        }

        public void clear()
        {
            amtxt.Text = "";
            thesistxt.Text = "";
            nametxt.Text = "";
            datetxt.Text = "";
            languagestxt.Text = "";
            frameworktxt.Text = "";
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            AdminMenu Form1 = new AdminMenu();
            Form1.Show(this);
            this.Hide();
        }

        private void DbForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

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
    public partial class FinalGradeForm : Form
    {
        GradesInfo grd = new GradesInfo();
        GradeTools grddal = new GradeTools();

        public FinalGradeForm()
        {
            InitializeComponent();
        }

        private void viewbutton_Click(object sender, EventArgs e)
        {
            DataTable dt = grddal.Select();
            dataGridView1.DataSource = dt;
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            grd.id = idtextBox.Text;
            grd.grades = gradetextBox.Text;


            bool success = grddal.Insert(grd);
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

        private void updatebutton_Click(object sender, EventArgs e)
        {
            grd.id = idtextBox.Text;
            grd.grades = gradetextBox.Text;


            bool success = grddal.Update(grd);
            if (success == true)
            {
                MessageBox.Show("Successfully update");
                clear();
            }
            else
            {
                MessageBox.Show("Failed to update");
            }
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            grd.id = idtextBox.Text;
            bool success = grddal.Delete(grd);
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

        private void clear()
        {
            idtextBox.Text = "";
            gradetextBox.Text = "";
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            AdminMenu adminMenu = new AdminMenu();
            adminMenu.Show(this);
            this.Hide();
        }

        private void idtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FinalGradeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void FinalGradeForm_Load(object sender, EventArgs e)
        {

        }
    }
}

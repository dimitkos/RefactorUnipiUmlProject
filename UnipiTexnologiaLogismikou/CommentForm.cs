using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnipiTexnologiaLogismikou
{
    public partial class CommentForm : Form
    {
        Admin admin = new Admin();
        public CommentForm()
        {
            InitializeComponent();
            panel1.Hide();
            textBox3.ReadOnly = true;

        }

        private void CommentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            admin.WriteComment(textBox1, textBox2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //με το πατημα του κουμπιου εμφανιζεται το panel1  οπου περιεχει το textbox3 οπου θα  εμφανισιε το περιεχομενο 
            //του txt αρχειου οπου καταχωρουνται τα σχολια
            panel1.Show();
            admin.ReadComment(textBox3);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminMenu Form1 = new AdminMenu();
            Form1.Show(this);
            this.Hide();
        }
    }
}

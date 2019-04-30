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
    public partial class ForumForm : Form
    {
        public ForumForm()
        {
            InitializeComponent();
            panel1.Hide();
            textBox3.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserMenu Form1 = new UserMenu();
            Form1.Show(this);
            this.Hide();
        }

        private void ForumForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ForumForm_Load(object sender, EventArgs e)
        {

        }

        private void enterbutton_Click(object sender, EventArgs e)
        {
            Student st = new Student();
            st.WriteCommentStudent(textBox1, textBox2);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //με το πατημα του κουμπιου εμφανιζεται το panel1  οπου περιεχει το textbox3 οπου θα  εμφανισιε το περιεχομενο 
            //του txt αρχειου οπου καταχωρουνται τα σχολια
            panel1.Show();
            Student st = new Student();
            st.ReadCommentStudent(textBox3);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

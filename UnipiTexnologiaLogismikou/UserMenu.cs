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
    public partial class UserMenu : Form
    {
        public UserMenu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Teo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        OpenFileDialog ofd = new OpenFileDialog();


        private void emailbutton_Click(object sender, EventArgs e)
        {
            EmailForm emailform = new EmailForm();
            //h deyterh forma emfanizetai,tis exv syndesh mesw tou this.h deyterh forma exei owner thn prwth
            emailform.Show(this);
            //twra h prwth form kryvetai
            this.Hide();
        }

        private void forumbutton_Click(object sender, EventArgs e)
        {
            ForumForm forumform = new ForumForm();
            //h deyterh forma emfanizetai,tis exv syndesh mesw tou this.h deyterh forma exei owner thn prwth
            forumform.Show(this);
            //twra h prwth form kryvetai
            this.Hide();
        }

        private void UserMenu_Load(object sender, EventArgs e)
        {

        }

        private void uploadbutton_Click(object sender, EventArgs e)
        {
            Student st = new Student();
            st.UploadThesis(uploadbutton);
        }

        private void UserMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

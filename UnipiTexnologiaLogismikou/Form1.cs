using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Diagnostics;

namespace UnipiTexnologiaLogismikou
{
    public partial class Form1 : Form
    {
        Dictionary<String, String> accounts = new Dictionary<string, string>();
        Dictionary<String, String> admins = new Dictionary<string, string>();

        public Form1()
        {
            InitializeComponent();
            

            //φτιαχνς δυο account  user
            accounts.Add("jim", "123");
            accounts.Add("aris", "123");

            //και ενα με δικαιωματα admin 
            admins.Add("teo", "123");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void adminbutton_Click(object sender, EventArgs e)
        {          
           // αφπυ παταω το admin button κοβω το αλλο κουμπι να μην μπορει αν το πατησει ο χρηστης
            userbutton.Enabled = false;

            String password = "";

            if (admins.TryGetValue(usernametextBox.Text, out password))
            {
                //elegxei an to pass pou edwse o xrhsths einai idio me to pass pou einia mesa sto dictionary
                if (password == passtextBox.Text)
                {
                    //tha vgalei mhnyma epityxias tou login
                    MessageBox.Show("Login successfull");

                    AdminMenu adminmenu = new AdminMenu();
                    //h deyterh forma emfanizetai,tis exv syndesh mesw tou this.h deyterh forma exei owner thn prwth
                    adminmenu.Show(this);
                    //twra h prwth form kryvetai
                    this.Hide();

                }
                else
                {
                    //παγωνουμε το threaad διοτι στο μουσικο αρχειο δεν ξεκιναιε η μουσικη απο το 0 δευετρολεπτο αργει λιγακι
                    //ενω ανοιγει αλλο thread  και εκτελουνται ταυτχορνα επειδη υπαρχει αυτη η καθυστερηση στον ηχο 
                    //παγωνουμε το βασικο thread  για  μισο δευτερολεπτο ωστε να δινει στον χρηστη την εντυοωση οτι γινονται ραυτοχορνα
                    System.Threading.Thread.Sleep(500);
                    MessageBox.Show("Wrong password");
                }

            }
            else
            {
                
                //παγωνουμε το threaad διοτι στο μουσικο αρχειο δεν ξεκιναιε η μουσικη απο το 0 δευετρολεπτο αργει λιγακι
                //ενω ανοιγει αλλο thread  και εκτελουνται ταυτχορνα επειδη υπαρχει αυτη η καθυστερηση στον ηχο 
                //παγωνουμε το βασικο thread  για  μισο δευτερολεπτο ωστε να δινει στον χρηστη την εντυοωση οτι γινονται ραυτοχορνα
                System.Threading.Thread.Sleep(500);
                //Ean den iparxi to account sto dictionary mesa na kani print afto sto msqbox
                MessageBox.Show("Account does not exist");
            }
        }

        private void userbutton_Click(object sender, EventArgs e)
        {
            // αφπυ παταω το admin button κοβω το αλλο κουμπι να μην μπορει αν το πατησει ο χρηστης
            adminbutton.Enabled = false;

            String password = "";

            if (accounts.TryGetValue(usernametextBox.Text, out password))
            {
                //elegxei an to pass pou edwse o xrhsths einai idio me to pass pou einia mesa sto dictionary
                if (password == passtextBox.Text)
                {
                    //tha vgalei mhnyma epityxias tou login
                    MessageBox.Show("Login successfull");

                    UserMenu usermenu = new UserMenu();
                    //h deyterh forma emfanizetai,tis exv syndesh mesw tou this.h deyterh forma exei owner thn prwth
                    usermenu.Show(this);
                    //twra h prwth form kryvetai
                    this.Hide();

                }
                else
                {
                    //παγωνουμε το threaad διοτι στο μουσικο αρχειο δεν ξεκιναιε η μουσικη απο το 0 δευετρολεπτο αργει λιγακι
                    //ενω ανοιγει αλλο thread  και εκτελουνται ταυτχορνα επειδη υπαρχει αυτη η καθυστερηση στον ηχο 
                    //παγωνουμε το βασικο thread  για  μισο δευτερολεπτο ωστε να δινει στον χρηστη την εντυοωση οτι γινονται ραυτοχορνα
                    System.Threading.Thread.Sleep(500);
                    MessageBox.Show("Wrong password");
                }

            }
            else
            {

                //παγωνουμε το threaad διοτι στο μουσικο αρχειο δεν ξεκιναιε η μουσικη απο το 0 δευετρολεπτο αργει λιγακι
                //ενω ανοιγει αλλο thread  και εκτελουνται ταυτχορνα επειδη υπαρχει αυτη η καθυστερηση στον ηχο 
                //παγωνουμε το βασικο thread  για  μισο δευτερολεπτο ωστε να δινει στον χρηστη την εντυοωση οτι γινονται ραυτοχορνα
                System.Threading.Thread.Sleep(500);
                //Ean den iparxi to account sto dictionary mesa na kani print afto sto msqbox
                MessageBox.Show("Account does not exist");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            //////////////////////////////////////////////////////////////////////////////////////
            //Teo : To minima afto pernaei se oles tis ales formes , to vazo se sxolio prosorina//
            //////////////////////////////////////////////////////////////////////////////////////
            /*
            // otan pame na klisoume thn efarmogh patwntas x,tha vgei ena mnm pou tha mas rwtaei ti theloume na kanoume
            //an pathsoume nai tote tha klisei alliws oxi tha meinei opws einai
            DialogResult dialogResult1 = MessageBox.Show("Are you sure ?", "Question", MessageBoxButtons.YesNo);
            if (dialogResult1 == DialogResult.Yes)
            {
                e.Cancel = false;

            }
            else if (dialogResult1 == DialogResult.No)
            {

                e.Cancel = true;
            }*/
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //με το πατημα το label ανοιγει η ιστοσελιδα
            ProcessStartInfo sInfo = new ProcessStartInfo("http://www.cs.unipi.gr/index.php?lang=el");
            Process.Start(sInfo);
        }
    }
}

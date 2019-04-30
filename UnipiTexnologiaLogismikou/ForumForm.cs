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
            DateTime date = DateTime.Now;
            string formattedDate = date.ToString("dddd, dd MMMM yyyy HH:mm");
            //στην συνεχεια θα κανουμε append  σε ενα αρχειο . αν αυτο το αρχειο δεν υπαρχιε θα το δημιουργησει

                using (StreamWriter sw1 = File.AppendText("comments.txt"))
                {
                    //ελεγχει αν το ονομα του χρηστη ειναι κενο,και του δινει το text  ανωνυμος
                    if (textBox1.Text == "")
                    {
                        textBox1.Text = "Anonymous";
                    }
                    //στην περιπτωση ομως που το text  του σχολειου ειναι κενο του λεει οτι πρεπει να γραψει μηνυμα
                    //αν ολα ειναι οκ τοτε φραφει το μηνυμα
                    if (textBox2.Text == "")
                    {
                        MessageBox.Show("you must type a comment");
                    }
                    else
                    {
                        //στην συνεχεια του λεμε να γράψει τα καταλληλα μηνυμα,σε περιπτωση που παραχθει καποιο
                        //exception  βγαινουν τα αντιστοιχα μηνυματα
                        try
                        {
                            sw1.WriteLine("---------------------------------------------------------------");
                            sw1.WriteLine("Ο χρήστης " + textBox1.Text + " την ημερομηνία " + formattedDate + " σχολίασε: ");
                            sw1.WriteLine(textBox2.Text);
                            MessageBox.Show("Το σχόλιο σας υποβλήθηκε επιτυχώς");
                        }
                        catch (IOException e1)
                        {
                            MessageBox.Show(e1.GetType().Name);
                        }
                        catch (ObjectDisposedException e2)
                        {
                            MessageBox.Show("Object Disposed Exception");
                        }
                    }

                }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //με το πατημα του κουμπιου εμφανιζεται το panel1  οπου περιεχει το textbox3 οπου θα  εμφανισιε το περιεχομενο 
            //του txt αρχειου οπου καταχωρουνται τα σχολια
            panel1.Show();
            try
            {
                StringBuilder sb = new StringBuilder();
                using (StreamReader sr = new StreamReader("comments.txt"))
                {
                    while (sr.Peek() >= 0)
                    {
                        sb.AppendLine(sr.ReadLine());
                    }
                    textBox3.Text = sb.ToString();
                }
            }
            catch (IOException e3)
            {
                MessageBox.Show(e3.GetType().Name);
            }
            catch (ArgumentException e4)
            {
                MessageBox.Show(e4.GetType().Name);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

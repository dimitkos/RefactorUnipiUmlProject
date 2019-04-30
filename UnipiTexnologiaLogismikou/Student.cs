using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnipiTexnologiaLogismikou
{
    public class Student : User
    {
        public GradesInfo gradesInfo;

        public StudentInfo studentInfo;

        public ProgressInfo progressinfo;

        public void Sendmail(TextBox textBox1, TextBox textBox2,MailMessage msg)
        {
            //για τις αναγκες της παρουσας εργασιας φτιαξαμε ενα mail projectsunipi@gmail.com.
            //για λογους ασφαλειας επιλεξαμε μην βαζει ακποιος το κανονικο μεηλ του και τους κωδικους του
            //ετσι λοιπον οτι μεηλ και να γραψει στο textbox θα φυγει και θα παραληφθει απο το παραπανω μεηλ

            try
            {
                //φτιαχνω ενα αντικειμενο τυπου MailMessage οπου σαν ορισματα θα εχει το μεηλ αυτουνου που στελνει,που θα παει,το θεμα του μεηλ καθως και το κειμενο
                msg = new MailMessage(textBox1.Text, "projectsunipi@gmail.com", "Uml Project ", textBox2.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.GetType().Name);
            }
            catch (ArgumentException ex1)
            {
                MessageBox.Show(ex1.GetType().Name);
            }



            //φτιαχνουμε ενα αντικειμενο τυπου SmtpClient οπου μας βοηθαει να στελνουμε μεηλ με το smtp 
            SmtpClient mail = new SmtpClient();
            //κθοριζουμε το ονομα του host
            mail.Host = "smtp.gmail.com";
            //kauorizoym me poia porta ua ginei h epikoinvnia
            mail.Port = 587;
            //για να γινει το authedication  βαζουμε τα credentials
            mail.Credentials = new NetworkCredential("projectsunipi@gmail.com", "projectcsharp");
            //για να κρυπτογραφησει την επικοινωνια κανουμε ενεργοποιηση του  ssl
            mail.EnableSsl = true;


            //στελνει το μηνυμα στον  smtp server 
            try
            {
                mail.Send(msg);
                MessageBox.Show("Message has been sent");
            }
            catch (SmtpException exc)
            {
                MessageBox.Show(exc.GetType().Name);
            }
            catch (ArgumentException e1)
            {
                MessageBox.Show("Argument Exception");
            }
            catch (InvalidOperationException e2)
            {
                MessageBox.Show("Invalid Operation Exception");
            }
        }

        public void UploadThesis(Button uploadbutton)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                uploadbutton.Enabled = false;
                uploadbutton.Text = "Thesis Uploded";
                MessageBox.Show("Thesis Uploded Successfully");
            };
        }

        public void WriteCommentStudent(TextBox textBox1, TextBox textBox2)
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

        public void ReadCommentStudent(TextBox textBox3)
        {
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
    }
}

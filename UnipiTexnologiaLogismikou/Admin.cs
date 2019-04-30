using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnipiTexnologiaLogismikou
{
    public class Admin : User
    {
        public StudentTools studentTools;
        public GradeTools gradeTools;
        public ProgressInfoTools progressInfoTools;

        public void  WriteComment(TextBox textBox1, TextBox textBox2)
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

        public void ReadComment(TextBox textBox3)
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

        public int SelectProgress(string id)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString);

            int result = 0;
            try
            {
                String sql = "SELECT progress  FROM dbo.progress  " +
                    " where id=@id";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", id);


                con.Open();
                result = Convert.ToInt32(cmd.ExecuteScalar());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

            return result;
        }

        public DataTable ShowGradesRange(string t1, string t2)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString);

            DataTable dt = new DataTable();
            try
            {
                String sql = "SELECT st.id ,st.namesurname,gr.grades FROM studentinfo as st, grade as gr " +
                    " where st.id=gr.id and gr.grades>=@t1 and gr.grades<=@t2";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@t1", t1);
                cmd.Parameters.AddWithValue("@t2", t2);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                con.Open();
                adapter.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return dt;
        }

        public int CountFrameworks(string framework)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString);

            int result = 0;
            try
            {
                String sql = "SELECT Count(*) FROM studentinfo as st " +
                    " where st.framework=@framework";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@framework", framework);


                con.Open();
                result = Convert.ToInt32(cmd.ExecuteScalar());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnipiTexnologiaLogismikou
{
    public partial class ReportingForm : Form
    {
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        public ReportingForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = Select(textBox1.Text,textBox2.Text);
            dataGridView1.DataSource = dt;
        }

        private  DataTable Select(string t1 ,string t2)
        {
            SqlConnection con = new SqlConnection(myconnstring);

            DataTable dt = new DataTable();
            try
            {
                String sql = "SELECT st.id ,st.namesurname,gr.grades FROM studentinfo as st, grade as gr " +
                    " where st.id=gr.id and gr.grades>=@t1 and gr.grades<=@t2";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@t1",t1 );
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

        private void frameworkbutton_Click(object sender, EventArgs e)
        {
            var result = SelectFramework(textBox3.Text.Trim());
            label4.Text = result.ToString();
        }

        private int SelectFramework(string framework)
        {
            SqlConnection con = new SqlConnection(myconnstring);

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

        private void ReportingForm_Load(object sender, EventArgs e)
        {

        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            AdminMenu forumform = new AdminMenu();
            forumform.Show(this);
            this.Hide();
        }

        private void ReportingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }   
}

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnipiTexnologiaLogismikou
{
    public class GradeTools
    {
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        public DataTable Select()
        {
            SqlConnection con = new SqlConnection(myconnstring);

            DataTable dt = new DataTable();
            try
            {
                String sql = "SELECT st.id ,st.namesurname,gr.grades FROM studentinfo as st, grade as gr " +
                    " where st.id=gr.id";
                SqlCommand cmd = new SqlCommand(sql, con);
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


        public bool Insert(GradesInfo grdinfo)
        {
            bool isSuccess = false;
            //insert data to the database
            //1st craete a connection between database and our application
            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                String sql = "INSERT INTO grade (id, grades) VALUES (@id, @grades)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", grdinfo.id);
                cmd.Parameters.AddWithValue("@grades", grdinfo.grades);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }


        public bool Update(GradesInfo grdinfo)
        {
            bool isSuccess = false;
            SqlConnection conn1 = new SqlConnection(myconnstring);

            try
            {

                string sql = " UPDATE grade SET grades=@grades WHERE id=@id ";
                SqlCommand cmd = new SqlCommand(sql, conn1);

                cmd.Parameters.AddWithValue("@id", grdinfo.id);
                cmd.Parameters.AddWithValue("@grades", grdinfo.grades);


                conn1.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    //Successfull
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn1.Close();
            }

            return isSuccess;
        }

        public bool Delete(GradesInfo grdinfo)
        {
            //alose declare a boole variable
            bool isSuccess = false;

            //sql connection
            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                //writing query to delete data
                String sql = "DELETE FROM grade WHERE id=@id";

                //sql command
                SqlCommand cmd = new SqlCommand(sql, conn);

                //parameters
                cmd.Parameters.AddWithValue("@id", grdinfo.id);

                //open connection
                conn.Open();

                //integer variable which holds the code to execute the query
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    //query successful
                    isSuccess = true;
                }
                else
                {
                    //query failed
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //close connection
                conn.Close();
            }
            //and return this value
            return isSuccess;
        }
    }
}

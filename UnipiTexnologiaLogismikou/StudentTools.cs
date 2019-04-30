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
    public class StudentTools
    {
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
    

        #region Insert Data to Database

        public bool Insert(StudentInfo stdinfo)
        {
            bool isSuccess = false;
            //insert data to the database
            //1st craete a connection between database and our application
            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                String sql = "INSERT INTO studentinfo (id, namesurname, thesis, startdate, languages, framework) VALUES (@id, @namesurname, @thesis, @startdate, @languages, @framework)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", stdinfo.id);
                cmd.Parameters.AddWithValue("@namesurname", stdinfo.namesurname);
                cmd.Parameters.AddWithValue("@thesis", stdinfo.thesis);
                cmd.Parameters.AddWithValue("@startdate", stdinfo.startdate);
                cmd.Parameters.AddWithValue("@languages", stdinfo.languages);
                cmd.Parameters.AddWithValue("@framework", stdinfo.framework);

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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
    
        #endregion

        #region Update Data in Database
        public bool Update(StudentInfo stdinfo)
        {
            bool isSuccess = false;
            SqlConnection conn1 = new SqlConnection(myconnstring);

            try
            {

                string sql = " UPDATE studentinfo SET namesurname=@namesurname, thesis=@thesis, startdate=@startdate, languages=@languages, framework=@framework WHERE id=@id ";
                SqlCommand cmd = new SqlCommand(sql, conn1);

                cmd.Parameters.AddWithValue("@id", stdinfo.id);
                cmd.Parameters.AddWithValue("@namesurname", stdinfo.namesurname);
                cmd.Parameters.AddWithValue("@thesis", stdinfo.thesis);
                cmd.Parameters.AddWithValue("@startdate", stdinfo.startdate);
                cmd.Parameters.AddWithValue("@languages", stdinfo.languages);
                cmd.Parameters.AddWithValue("@framework", stdinfo.framework);

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
        #endregion

        #region Delete from Database
        public bool Delete(StudentInfo stdinfo)
        {
            //alose declare a boole variable
            bool isSuccess = false;

            //sql connection
            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                //writing query to delete data
                String sql = "DELETE FROM studentinfo WHERE id=@id";

                //sql command
                SqlCommand cmd = new SqlCommand(sql, conn);

                //parameters
                cmd.Parameters.AddWithValue("@id", stdinfo.id);

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
        #endregion

        #region Select data from database
        public DataTable Select()
        {
            SqlConnection con = new SqlConnection(myconnstring);

            DataTable dt = new DataTable();
            try
            {
                String sql = "SELECT * FROM studentinfo";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                con.Open();
                adapter.Fill(dt);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return dt;
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTable.Config
{
    public class SQLConfig
    {
        private SqlConnection con = new SqlConnection("Server=EC2AMAZ-DDVBGQP;Database=TimeTable;Trusted_Connection = true;");
        private SqlCommand cmd;
        private SqlDataAdapter da;
        public DataTable dt;
        int result;
        public bool Execute_CUD(string sql)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = sql;
                result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }
        public void Execute_Query(string sql)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = sql;
                result = cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public void Load_DTG(string sql, DataGridView dtg)
        {
            try
            {
                //con.Open();
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                cmd = new SqlCommand();
                da = new SqlDataAdapter();
                dt = new DataTable();


                cmd.Connection = con;
                cmd.CommandText = sql;
                da.SelectCommand = cmd;
                da.Fill(dt);
                dtg.DataSource = dt;


                dtg.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dtg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dtg.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                da.Dispose();
                con.Close();
            }

        }

        public DataTable GetSetOfData(string sql)
        {
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                cmd = new SqlCommand();
                da = new SqlDataAdapter();
                dt = new DataTable();


                cmd.Connection = con;
                cmd.CommandText = sql;
                da.SelectCommand = cmd;
                da.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            da.Dispose();
            con.Close();
            return dt;
        }

        public void Fiil_CBO(string sql, ComboBox cbo)
        {
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                cmd = new SqlCommand();
                da = new SqlDataAdapter();
                dt = new DataTable();


                cmd.Connection = con;
                cmd.CommandText = sql;
                da.SelectCommand = cmd;
                da.Fill(dt);

                cbo.DataSource = dt;
                cbo.ValueMember = dt.Columns[0].ColumnName;
                cbo.DisplayMember = dt.Columns[0].ColumnName;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                da.Dispose();
            }

        }
        public void SingleResult(string sql)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand();
                da = new SqlDataAdapter();
                dt = new DataTable();


                cmd.Connection = con;
                cmd.CommandText = sql;
                da.SelectCommand = cmd;
                da.Fill(dt);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                da.Dispose();
                con.Close();
            }
        }

        public object GetSingleValue(string sql)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand();


                cmd.Connection = con;
                cmd.CommandText = sql;
                return cmd.ExecuteScalar();
            }
            catch (Exception ex)
            { 
                return null;
            }
            finally
            {
                con.Close();
            }
        }
    }
}

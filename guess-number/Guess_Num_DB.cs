using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GuessNum
{
    class Guess_Num_DB:dataConnection
    {
        internal void insertTimes(string pTime)
        {
            try
            {
                int strTime = int.Parse(pTime.ToString().Replace(":", ""));
                strTime = int.Parse(strTime.ToString().Replace("0", ""));
                strTime = int.Parse(strTime.ToString().Substring(0, 1));

                if (strTime < 7)
                {
                    dAdapter = new SqlDataAdapter($"insert into record_times values ('{pTime}')", cnn);
                    dAdapter.SelectCommand.CommandType = CommandType.Text;

                    cnn.Open();
                    int i = dAdapter.SelectCommand.ExecuteNonQuery();
                }

                //if (i > 0)
                //    MessageBox.Show("Data inserted successfully", "Changes made", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                if (cnn.State == ConnectionState.Open)
                    MessageBox.Show($"Upps! Data couldn't be stored {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cnn.Close();
            }

        }

        internal DataSet showData()
        {
            try
            {
                cnn.Open();
                SqlDataAdapter da = new SqlDataAdapter("select top 25 * from record_times order by times", cnn);
                da.SelectCommand.CommandType = CommandType.Text;
                DataSet dato = new DataSet();
                da.Fill(dato, "record_times");
                return dato;
            }
            catch (Exception ex)
            {
                if (cnn.State == ConnectionState.Open)
                    MessageBox.Show($"Ha ocurrido un error: {ex.Message}");
            }
            finally
            {
                cnn.Close();
            }
            return null;
        }

        internal string loadFirstRecordTime()
        {
            string time = "0";
            int i = 0;
            try
            {
                dAdapter = new SqlDataAdapter("select top 1 (times) from record_times order by times", cnn);
                dAdapter.SelectCommand.CommandType = CommandType.Text;

                cmd = new SqlCommand("select count(times) from record_times", cnn);
                cnn.Open();
                //time = dap.SelectCommand.ExecuteScalar().ToString();
                i = (int)cmd.ExecuteScalar();
                cnn.Close();
                if (i > 0)
                {
                    cnn.Open();
                    time = dAdapter.SelectCommand.ExecuteScalar().ToString();
                }
                //MessageBox.Show(time);


                return time;
            }
            catch (Exception ex)
            {
                if (cnn.State == ConnectionState.Open)
                    MessageBox.Show($"Upps! Data couldn't be stored {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cnn.Close();
            }

            return time;
        }

        internal void countRecordTimesLessThan7mins()
        {
            int count = 0;
            int time = 0;
            try
            {
                dAdapter = new SqlDataAdapter("select top 25 (times) from record_times order by times", cnn);
                dAdapter.SelectCommand.CommandType = CommandType.Text;

                cnn.Open();
                dt = new DataTable();
                dAdapter.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    time = int.Parse(dt.Rows[i][0].ToString().Replace(":", string.Empty));
                    if (time <= 700) count++;
                }
                if (count == 25) MessageBox.Show("Time to increase the difficulty! Add two more digits.");

            }
            catch (Exception ex)
            {
                if (cnn.State == ConnectionState.Open)
                    MessageBox.Show($"Upps! Data couldn't be stored {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cnn.Close();
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------
        internal void insertTimes2(string pTime)
        {
            try
            {
                int strTime = int.Parse(pTime.ToString().Replace(":", ""));
                strTime = int.Parse(strTime.ToString().Replace("0", ""));
                strTime = int.Parse(strTime.ToString().Substring(0, 1));

                if (strTime <= 4)
                {
                    dAdapter = new SqlDataAdapter($"insert into record_times2 values ('{pTime}')", cnn);
                    dAdapter.SelectCommand.CommandType = CommandType.Text;

                    cnn.Open();
                    int i = dAdapter.SelectCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                if (cnn.State == ConnectionState.Open)
                    MessageBox.Show($"Upps! Data couldn't be stored {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cnn.Close();
            }
        }

        internal DataSet showData2()
        {
            try
            {
                cnn.Open();
                SqlDataAdapter da = new SqlDataAdapter("select top 25 * from record_times2 order by times", cnn);
                da.SelectCommand.CommandType = CommandType.Text;
                DataSet dato = new DataSet();
                da.Fill(dato, "record_times2");
                cnn.Close();
                return dato;
            }
            catch (Exception ex)
            {
                if (cnn.State == ConnectionState.Open)
                    MessageBox.Show($"Ha ocurrido un error: {ex.Message}");
            }
            finally
            {
                cnn.Close();
            }

            return null;
        }

        internal string loadFirstRecordTime2()
        {
            string time = "0";
            int i = 0;
            try
            {
                dAdapter = new SqlDataAdapter("select top 1 (times) from record_times2 order by times", cnn);
                dAdapter.SelectCommand.CommandType = CommandType.Text;

                cmd = new SqlCommand("select count(times) from record_times2", cnn);
                //time = dap.SelectCommand.ExecuteScalar().ToString();
                i = (int)cmd.ExecuteScalar();
                cnn.Close();
                if (i > 0)
                {
                    cnn.Open();
                    time = dAdapter.SelectCommand.ExecuteScalar().ToString();

                }
                //MessageBox.Show(time);
                return time;
            }
            catch (Exception ex)
            {
                if (cnn.State == ConnectionState.Open)
                    MessageBox.Show($"Upps! Data couldn't be stored {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cnn.Close();
            }
            finally
            {
                cnn.Close();
            }

            return time;
        }

        internal void countRecordTimesLessThan4mins()
        {
            int count = 0;
            int time = 0;
            try
            {
                dAdapter = new SqlDataAdapter("select top 25 (times) from record_times2 order by times", cnn);
                dAdapter.SelectCommand.CommandType = CommandType.Text;

                cnn.Open();
                dt = new DataTable();
                dAdapter.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    time = int.Parse(dt.Rows[i][0].ToString().Replace(":", string.Empty));
                    if (time <= 300) count++;
                }
                if (count == 25) MessageBox.Show("Time to increase the difficulty! Add two more digits.");
            }
            catch (Exception ex)
            {
                if (cnn.State == ConnectionState.Open)
                    MessageBox.Show($"Upps! Data couldn't be stored {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cnn.Close();
            }
        }
    }
}

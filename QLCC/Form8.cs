using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace QLCC
{
    public partial class Form8 : Form
    {

        public Form8()
        {
            InitializeComponent();
        }
        public delegate void sendvalue(DataGridView dgv);
        MySqlConnection con = new MySqlConnection(@"Data Source=localhost;port=3306;Initial Catalog=qlcc;User Id= root;password='';charset=utf8;sslmode=none;");

        private void display()
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from time_sheet";

            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            MySqlCommand cmdd = con.CreateCommand();
            cmdd.CommandType = CommandType.Text;
            cmdd.CommandText = "select * from chamcong";
            cmdd.ExecuteNonQuery();
            DataTable dtt = new DataTable();
            MySqlDataAdapter daa = new MySqlDataAdapter(cmdd);
            daa.Fill(dtt);
            dataGridView2.DataSource = dtt;
            con.Close();
        }



        private void btnvaold_Click(object sender, EventArgs e)
        {
            try
            {
                
                MySqlParameter[] pms = new MySqlParameter[3];
                pms[0] = new MySqlParameter("tsid", MySqlDbType.Int32);
                pms[1] = new MySqlParameter("eid", MySqlDbType.Int32);
                pms[1].Value = txtid.Text;
                pms[2] = new MySqlParameter("din", MySqlDbType.DateTime);
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                con.Open();
               
                for (int i = 0; i < dataGridView1.RowCount ; i++)
                {
                    if ((dataGridView1.DataSource == null) || ((dataGridView1.Rows[i].Cells[1].Value) != txtid.Text))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "first_time_in";
                        cmd.Parameters.AddRange(pms);

                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            
                            MessageBox.Show("Thành công");
                        }
                        else
                        {
                            MessageBox.Show("Failed!!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("thành công");
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            finally
            {
                con.Close();
            }
        }



        private void btnvao_Click(object sender, EventArgs e)
        {
            //    try
            //    {

            //        MySqlParameter[] pms = new MySqlParameter[2];
            //        pms[0] = new MySqlParameter("eid", MySqlDbType.Text);
            //        pms[0].Value = txtid.Text;
            //        pms[1] = new MySqlParameter("din", MySqlDbType.DateTime);
            //        MySqlCommand cmd = new MySqlCommand();
            //        cmd.Connection = con;
            //        cmd.CommandType = CommandType.StoredProcedure;
            //        cmd.CommandText = "time_in";
            //        cmd.Parameters.AddRange(pms);
            //        con.Open();
            //        if (cmd.ExecuteNonQuery() ==1)
            //        {
            MessageBox.Show("Success");
            //        }
            //        else
            //        {
            //            MessageBox.Show("Failed!!!");
            //        }
            //        con.Close();
            //    }


            //    catch (Exception exx)
            //    {
            //        MessageBox.Show(exx.Message);
            //        Application.ExitThread();
            //    }

        }

        private void btnra_Click(object sender, EventArgs e)
        {
            try
            {

                MySqlParameter[] pms = new MySqlParameter[2];
                pms[0] = new MySqlParameter("eid", MySqlDbType.Text);
                pms[0].Value = txtid.Text;
                pms[1] = new MySqlParameter("dout", MySqlDbType.DateTime);
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "time_out";
                cmd.Parameters.AddRange(pms);
                con.Open();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Success");
                }
                else
                {
                    MessageBox.Show("Failed!!!");
                }
                con.Close();
            }


            catch (Exception exx)
            {
                MessageBox.Show(exx.Message);
                Application.ExitThread();
            }

        }

        private void btntangca_Click(object sender, EventArgs e)
        {
            try
            {


                MySqlParameter[] pms = new MySqlParameter[2];
                pms[0] = new MySqlParameter("eid", MySqlDbType.Text);
                pms[0].Value = txtid.Text;
                pms[1] = new MySqlParameter("dout", MySqlDbType.DateTime);
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "overtime";
                cmd.Parameters.AddRange(pms);
                con.Open();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Success");
                }
                else
                {
                    MessageBox.Show("Failed!!!");
                }
                con.Close();
            }


            catch (Exception exx)
            {
                MessageBox.Show(exx.Message);
                Application.ExitThread();
            }
        }
        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 fm2 = new Form2();
            fm2.Show();
        }
        private void btnload_Click(object sender, EventArgs e)
        {
            display();
        }

        private void btnbc_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            this.Hide();
            f9.Show();
        }

        private void btnrs_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from time_sheet";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cmd.CommandText = "ALTER TABLE time_sheet AUTO_INCREMENT = 1";
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void btncc_Click(object sender, EventArgs e)
        {
            try
            {

                MySqlParameter[] pms = new MySqlParameter[2];
                pms[0] = new MySqlParameter("id", MySqlDbType.Int32);
                pms[0].Value = txtid.Text;
                pms[1] = new MySqlParameter("sl", MySqlDbType.Int32);
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                
                cmd.CommandType = CommandType.StoredProcedure;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if ((dataGridView1.DataSource == null) || (dataGridView1.Rows[i].Cells[i].Value.ToString() != txtid.Text))
                    {
                        cmd.CommandText = "add_time";
                        cmd.Parameters.AddRange(pms);
                        con.Open();
                        if (cmd.ExecuteNonQuery() == 1)
                        {

                            MessageBox.Show("success");
                        }
                        else
                        {
                            MessageBox.Show("Failed!!");
                        }
                    }
                    else if ((dataGridView1.DataSource != null) && (dataGridView1.Rows[i].Cells[i].Value.ToString() == txtid.Text))
                    {
                        //MySqlParameter[] pms = new MySqlParameter[2];
                        //pms[0] = new MySqlParameter("id", MySqlDbType.Int32);
                        //pms[0].Value = txtid.Text;
                        //pms[1] = new MySqlParameter("sl", MySqlDbType.Int32);
                        //MySqlCommand cmd = new MySqlCommand();
                        //cmd.Connection = con;
                        //cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "update_time";
                        cmd.Parameters.AddRange(pms);
                        con.Open();
                        if (cmd.ExecuteNonQuery() == 1)
                        {

                            MessageBox.Show("success");
                        }
                        else
                        {
                            MessageBox.Show("Failed!!");
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            finally
            {
                con.Close();
            }

        }
    }
}

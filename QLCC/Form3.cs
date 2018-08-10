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
    public partial class Form3 : Form
    {
        MySqlConnection con = new MySqlConnection(@"Data Source=localhost;port=3306;Initial Catalog=qlcc;User Id= root;password='';charset=utf8;sslmode=none;");
        public Form3()
        {
            InitializeComponent();
        }
        private void display()
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from login";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlParameter[] pms = new MySqlParameter[2];
                pms[0] = new MySqlParameter("id", MySqlDbType.VarChar);
                pms[0].Value = txtid.Text;
                pms[1] = new MySqlParameter("pass", MySqlDbType.VarChar);
                pms[1].Value = txtpass.Text;
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "add_user";
                cmd.Parameters.AddRange(pms);
                con.Open();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    txtid.Text = "";
                    txtpass.Text = "";
                }

                else
                {
                    MessageBox.Show("Lỗi!!!");
                }
                con.Close();
                display();

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
                Application.ExitThread();
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlParameter[] pms = new MySqlParameter[1];
                pms[0] = new MySqlParameter("id", MySqlDbType.VarChar);
                pms[0].Value = txtid.Text;
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "del_user";
                cmd.Parameters.AddRange(pms);
                con.Open();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    txtid.Text = "";
                }

                else
                {
                    MessageBox.Show("Error!!!");
                }
                con.Close();
                display();

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
                Application.ExitThread();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 fm = new Form2();
            fm.Show();
        }
    }
}

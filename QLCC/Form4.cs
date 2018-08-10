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
    public partial class Form4 : Form
    {
        MySqlConnection con = new MySqlConnection(@"Data Source=localhost;port=3306;Initial Catalog=qlcc;User Id= root;password='';charset=utf8;sslmode=none;");
        public Form4()
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
        private void btndoi_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlParameter[] pms = new MySqlParameter[4];
                pms[0] = new MySqlParameter("pass1", MySqlDbType.VarChar);
                pms[0].Value = txtpasscu.Text;
                pms[1] = new MySqlParameter("pass2", MySqlDbType.VarChar);
                pms[1].Value = txtpassmoi.Text;
                pms[2] = new MySqlParameter("pass3", MySqlDbType.VarChar);
                pms[2].Value = txtxnpassmoi.Text;
                pms[3] = new MySqlParameter("id", MySqlDbType.VarChar);
                pms[3].Value = txtid.Text;

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "up_pass";
                cmd.Parameters.AddRange(pms);
                con.Open();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    txtid.Text = "";
                    txtpasscu.Text = "";
                    txtpassmoi.Text = "";
                    txtxnpassmoi.Text = "";
                    MessageBox.Show("thành công");

                }
                else
                {
                    MessageBox.Show("Lỗi!!!");
                }
                con.Close();
                display();
            }
            catch (Exception exx)
            {
                MessageBox.Show(exx.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.ExitThread();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 fm2 = new Form2();
            fm2.Show();
        }
    }
}

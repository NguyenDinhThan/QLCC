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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection(@"Data Source=localhost;port=3306;Initial Catalog=qlcc;User Id= root;password='';charset=utf8;sslmode=none;");
        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void display()
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from department";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {

                MySqlParameter[] pms = new MySqlParameter[2];
                pms[0] = new MySqlParameter("id", MySqlDbType.VarChar);
                pms[1] = new MySqlParameter("name", MySqlDbType.VarChar);
                pms[1].Value = txtname.Text;


                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "add_Deps";
                cmd.Parameters.AddRange(pms);
                con.Open();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    txtname.Text = "";
                    con.Close();
                    display();
                }
                else
                {
                    MessageBox.Show("Lỗi!!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.ExitThread();
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                int CurrentIndex = dataGridView1.CurrentCell.RowIndex;
                MySqlParameter[] pms = new MySqlParameter[1];
                pms[0] = new MySqlParameter("id", MySqlDbType.Int32);
                pms[0].Value = int.Parse(dataGridView1.Rows[CurrentIndex].Cells[0].Value.ToString());
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "del_Deps";
                cmd.Parameters.AddRange(pms);
                con.Open();
                if (cmd.ExecuteNonQuery() == 1)
                {

                    MessageBox.Show("Thành công");
                }
                else
                {
                    MessageBox.Show("Lỗi!!!");
                }
                con.Close();
                display();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.ExitThread();
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            try
            {

                MySqlParameter[] pms = new MySqlParameter[2];
                pms[0] = new MySqlParameter("id", MySqlDbType.Int32);
                pms[1] = new MySqlParameter("name", MySqlDbType.VarChar);
                pms[1].Value = txtname.Text;

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "up_Deps";
                cmd.Parameters.AddRange(pms);
                con.Open();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    txtid.Text = "";
                    txtname.Text = "";
                }
                else
                {
                    MessageBox.Show("Error!!!");
                }
                con.Close();
                display();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.ExitThread();
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 fm2 = new Form2();
            fm2.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            display();
        }
    }
}

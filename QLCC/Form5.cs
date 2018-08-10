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
using System.IO;

namespace QLCC
{
    public partial class Form5 : Form
    {
        MySqlConnection con = new MySqlConnection(@"Data Source=localhost;port=3306;Initial Catalog=qlcc;User Id= root;password='';charset=utf8;sslmode=none;");
        public Form5()
        {
            InitializeComponent();
        }



        private void display()
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from employee";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void btnanh_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "chọn hình (*.jpg;*.jpeg;*.png) | *.jpg;*.jpeg;*.png";
            ofd.FilterIndex = 1;
            ofd.RestoreDirectory = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pb.Image = Image.FromFile(ofd.FileName);
                txtanh.Text = ofd.FileName;
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlParameter[] pms = new MySqlParameter[10];
                pms[0] = new MySqlParameter("eid", MySqlDbType.Int32);
                pms[1] = new MySqlParameter("pid", MySqlDbType.Int32);
                pms[1].Value = int.Parse(cbbpid.SelectedValue.ToString());
                pms[2] = new MySqlParameter("did", MySqlDbType.Int32);
                pms[2].Value = int.Parse(cbbdid.SelectedValue.ToString());
                pms[3] = new MySqlParameter("fn", MySqlDbType.VarChar);
                pms[3].Value = txtho.Text;
                pms[4] = new MySqlParameter("lnn", MySqlDbType.VarChar);
                pms[4].Value = txtten.Text;
                pms[5] = new MySqlParameter("ep", MySqlDbType.Blob);
                pms[5].Value = convertImageToBytes(); ;
                pms[6] = new MySqlParameter("s", MySqlDbType.VarChar);
                pms[6].Value = txtgt.Text;
                pms[7] = new MySqlParameter("ic", MySqlDbType.VarChar);
                pms[7].Value = txtcmnd.Text;
                pms[8] = new MySqlParameter("p", MySqlDbType.VarChar);
                pms[8].Value = txtsdt.Text;
                pms[9] = new MySqlParameter("a", MySqlDbType.VarChar);
                pms[9].Value = txtdiachi.Text;

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "add_Emp";
                cmd.Parameters.AddRange(pms);
                con.Open();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    cbbpid.Text = "";
                    cbbdid.Text = "";
                    txtten.Text = "";
                    txtho.Text = "";
                    txtdiachi.Text = "";
                    txtsdt.Text = "";
                    txtcmnd.Text = "";
                    txtgt.Text = "";


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

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                int CurrentIndex = dataGridView1.CurrentCell.RowIndex;
                MySqlParameter[] pms = new MySqlParameter[1];
                pms[0] = new MySqlParameter("eid", MySqlDbType.Int32);
                pms[0].Value = int.Parse(dataGridView1.Rows[CurrentIndex].Cells[0].Value.ToString());
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "del_Emp";
                cmd.Parameters.AddRange(pms);
                con.Open();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    txteid.Text = "";
                    cbbpid.Text = "";
                    cbbdid.Text = "";
                    txtten.Text = "";
                    txtho.Text = "";
                    txtanh.Text = "";
                    pb.Refresh();
                    txtdiachi.Text = "";
                    txtsdt.Text = "";
                    txtcmnd.Text = "";
                    txtgt.Text = "";
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
                MySqlParameter[] pms = new MySqlParameter[10];
                pms[0] = new MySqlParameter("eid", MySqlDbType.Int32);
                pms[1] = new MySqlParameter("pid", MySqlDbType.Int32);
                pms[1].Value = int.Parse(cbbpid.SelectedValue.ToString());
                pms[2] = new MySqlParameter("did", MySqlDbType.Int32);
                pms[2].Value = int.Parse(cbbdid.SelectedValue.ToString());
                pms[3] = new MySqlParameter("fn", MySqlDbType.VarChar);
                pms[3].Value = txtho.Text;
                pms[4] = new MySqlParameter("lnn", MySqlDbType.VarChar);
                pms[4].Value = txtten.Text;
                pms[5] = new MySqlParameter("ep", MySqlDbType.Blob);
                pms[5].Value = convertImageToBytes();
                pms[6] = new MySqlParameter("s", MySqlDbType.VarChar);
                pms[6].Value = txtgt.Text;
                pms[7] = new MySqlParameter("ic", MySqlDbType.VarChar);
                pms[7].Value = txtcmnd.Text;
                pms[8] = new MySqlParameter("p", MySqlDbType.VarChar);
                pms[8].Value = txtsdt.Text;
                pms[9] = new MySqlParameter("a", MySqlDbType.VarChar);
                pms[9].Value = txtdiachi.Text;

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "add_Emp";
                cmd.Parameters.AddRange(pms);
                con.Open();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    txteid.Text = "";
                    cbbpid.Text = "";
                    cbbdid.Text = "";
                    txtten.Text = "";
                    txtho.Text = "";
                    txtanh.Text = "";
                    pb.Refresh();
                    txtdiachi.Text = "";
                    txtsdt.Text = "";
                    txtcmnd.Text = "";
                    txtgt.Text = "";
                    MessageBox.Show("Thành công");
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

        private void btnload_Click(object sender, EventArgs e)
        {
            display();
        }

        private void cbbpid_DropDown(object sender, EventArgs e)
        {
            try
            {


                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from position";
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cbbpid.DataSource = dt;
                cbbpid.DisplayMember = "sPositionName";
                cbbpid.ValueMember = "iPositionID";

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.ExitThread();

            }
        }
        private void cbbdid_DropDown(object sender, EventArgs e)
        {
            try
            {


                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from department";
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cbbdid.DataSource = dt;
                cbbdid.DisplayMember = "sDepartmentName";
                cbbdid.ValueMember = "iDepartmentID";

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.ExitThread();

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txteid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            cbbpid.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            cbbdid.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtho.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtten.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            ImageConverter objImageConverter = new ImageConverter();
            pb.Image = (Image)objImageConverter.ConvertFrom(txtanh.Text);
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            txtgt.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtcmnd.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtsdt.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txtdiachi.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
        }
        private byte[] convertImageToBytes()
        {
            FileStream fs;
            fs = new FileStream(txtanh.Text, FileMode.Open, FileAccess.Read);
            byte[] pic = new byte[fs.Length];
            fs.Read(pic, 0, System.Convert.ToInt32(fs.Length));
            fs.Close();
            return pic;
        }
        //private Image byteArrayToImage(byte[] byteArrayIn)
        //{
        //    using (MemoryStream mStream = new MemoryStream(byteArrayIn))
        //    {
        //        return Image.FromStream(mStream);
        //    }
        //}
        //private byte[] imgToByteArray(Image img)
        //{
        //    using (MemoryStream mStream = new MemoryStream())
        //    {
        //        img.Save(mStream, img.RawFormat);
        //        return mStream.ToArray();
        //    }
        //}
        //public static byte[] imgToByteConverter(Image inImg)
        //{
        //    ImageConverter imgCon = new ImageConverter();
        //    return (byte[])imgCon.ConvertTo(inImg, typeof(byte[]));
        //}
    }
}

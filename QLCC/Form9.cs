using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using MySql.Data.MySqlClient;
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;


namespace QLCC
{
    public partial class Form9 : Form
    {
        
        public Form9()
        {
            InitializeComponent();
            
        }
        MySqlConnection con = new MySqlConnection(@"Data Source=localhost;port=3306;Initial Catalog=qlcc;User Id= root;password='';charset=utf8;sslmode=none;");

        public void funvalue (DataGridView dd)
        {
            //dataGridViewForm9 = dd.va
        }
        private void btnupdate_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from month_report";
            cmd.ExecuteNonQuery();
            System.Data.DataTable dt = new System.Data.DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridViewForm9.DataSource = dt;
            con.Close();
        }
        private void export2Excel(DataGridView g, string duongDan, string tenTap, string m)
        {
            app obj = new app();
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 25;
            Microsoft.Office.Interop.Excel.Range rowHead = obj.get_Range("A1", "E1");
            rowHead.Font.Bold = true;
            rowHead.Font.Name = "Tahoma";
            rowHead.Font.Size = "15";
            for (int i = 1; i < g.Columns.Count + 1; i++) { obj.Cells[1, i] = g.Columns[i - 1].HeaderText; }
            for (int i = 0; i < g.Rows.Count; i++)
            {
                for (int j = 0; j < g.Columns.Count; j++)
                {
                    if (g.Rows[i].Cells[j].Value != null) { obj.Cells[i + 2, j + 1] = g.Rows[i].Cells[j].Value.ToString(); }
                }
            }
            obj.ActiveWorkbook.SaveCopyAs(duongDan + tenTap + m + ".xlsx");
            obj.ActiveWorkbook.Saved = true;
            MessageBox.Show("done!");
        }
        private void btnexport_Click(object sender, EventArgs e)
        {
            export2Excel(dataGridViewForm9, @"D:\", "Bảng Lương Tháng ", ((DateTime.Today.Month.ToString())+ " - " + (DateTime.Today.Year.ToString())));
        }



        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 fm2 = new Form2();
            fm2.Show();
        }


    }
}

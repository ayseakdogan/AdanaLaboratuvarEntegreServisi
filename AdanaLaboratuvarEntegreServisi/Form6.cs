using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AdanaLaboratuvarEntegreServisi
{  public partial class Form6 : Form
    { public static string hastakayitid = "";
        SqlConnection conn = new SqlConnection("Data Source=TSHBA\\SQLAYSE;Initial Catalog=ayse;User Id=sa;Password=12345;");
        public Form6()
        { InitializeComponent();
            conn.Open();
            DataTable tbl = new DataTable();
            SqlDataAdapter adptr = new SqlDataAdapter("Select * from HastaListesi", conn);
            adptr.Fill(tbl);
            dataGridView1.DataSource = tbl;
            conn.Close();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {    hastakayitid = (dataGridView1.CurrentRow.Cells[0].Value).ToString();
            Form6 frm = new Form6();
            frm.Close();
            frm.Dispose();
            this.Close();
        }
        private void rapor_Click(object sender, EventArgs e)
        {   Form7 Form7 = new Form7();
            Form7.ShowDialog();
        }
        private void button2_Click(object sender, EventArgs e)
        {   Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Visible = true; 
            Microsoft.Office.Interop.Excel.Workbook workbook = excel.Workbooks.Add(System.Reflection.Missing.Value);
            Microsoft.Office.Interop.Excel.Worksheet sheet1 = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets[1];
            int StartCol = 1;
            int StartRow = 1;
            for (int j = 0; j < dataGridView1.Columns.Count; j++)
            {   Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow, StartCol + j];
                myRange.Value2 = dataGridView1.Columns[j].HeaderText;
            }
            StartRow++;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            { for (int j = 0; j < dataGridView1.Columns.Count; j++)
                { try
                    { Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow + i, StartCol + j];
                      myRange.Value2 = dataGridView1[j, i].Value == null ? "" : dataGridView1[j, i].Value;
                    }
                    catch{}
                }  }  }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {   conn.Open();
            DataTable tbl = new DataTable();
            string vara, cumle;
            vara = textBox1.Text;
            cumle = "Select * from HastaListesi where HASTA_KIMLIK_NO like '%" + textBox1.Text + "%'";
            SqlDataAdapter adptr = new SqlDataAdapter(cumle, conn);
            adptr.Fill(tbl);
            conn.Close();
            dataGridView1.DataSource = tbl;
        }
        private void button1_Click(object sender, EventArgs e)
        { this.Close();}
    }}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Data.SqlClient;
namespace AdanaLaboratuvarEntegreServisi
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=TSHBA\\SQLAYSE;Initial Catalog=ayse;User Id=sa;Password=12345;");
        public static DataTable dtYazdir = new DataTable();
        public Form1()
        {
            InitializeComponent();
           
        }
        private void Lab_Click(object sender, EventArgs e)
        {
            try
            {   ws_AdanaLabYeniEntegre.EntegreLBYSLabService LabService = new ws_AdanaLabYeniEntegre.EntegreLBYSLabService();
                NetworkCredential sifreleme = new NetworkCredential("10405413480", "1080");
                LabService.Credentials = sifreleme;
                ws_AdanaLabYeniEntegre.AktifTest[] aktiftestler = LabService.AktifTestler("10405413480", "1080");
                if (aktiftestler.Length > 0 && aktiftestler != null)
                {
                    conn.Open();
                    SqlCommand tetkiksil = new SqlCommand("DELETE FROM TetkikListesi", conn);
                    tetkiksil.ExecuteNonQuery();
                    foreach (ws_AdanaLabYeniEntegre.AktifTest tetkikler in aktiftestler)
                    {  try 
                        {SqlCommand kmt = new SqlCommand("Insert into  TetkikListesi (ReferansNo,TetkikAdi,TetkikKodu,GrupKodu,SUTTUT_NO,FIYATI,GUNCELLENME_TARIHI,AKTIF,GUNCELLEME_INFO,ESLESME_NO) VALUES (@ReferansNo,@TetkikAdi,@TetkikKodu,@GrupKodu,@SUTTUT_NO,0,@GUNCELLENME_TARIHI,'1','yenikayit','')", conn);
                            kmt.Parameters.AddWithValue("@ReferansNo", tetkikler.TestID);
                            kmt.Parameters.AddWithValue("@TetkikAdi", tetkikler.TestAdi);
                            kmt.Parameters.AddWithValue("@TetkikKodu", tetkikler.ButceKodu);
                            kmt.Parameters.AddWithValue("@GrupKodu", tetkikler.TestGrupAdi);
                            kmt.Parameters.AddWithValue("@SUTTUT_NO", tetkikler.ButceKodu);
                            kmt.Parameters.AddWithValue("@GUNCELLENME_TARIHI",Convert.ToDateTime(DateTime.Now.ToShortDateString()));
                            kmt.ExecuteNonQuery();                   
                        } catch  { }  }
                    DataTable tbl = new DataTable();
                    SqlDataAdapter adptr = new SqlDataAdapter("Select * from TetkikListesi", conn);
                    adptr.Fill(tbl);
                    adptr.Fill(dtYazdir);
                    MessageBox.Show("Tetkik listesi güncellendi.");
                    dataGridView1.DataSource = tbl;
                    conn.Close();              
                } }catch { }  }
        private void Kapat_Click(object sender, EventArgs e)
        {this.Close();  }
        private void button1_Click(object sender, EventArgs e)
        {
            Form3 Form3 = new Form3();
            Form3.ShowDialog();
        }
        private void Form1_Load(object sender, EventArgs e)
        {   DataTable tbl = new DataTable();
            SqlDataAdapter adptr = new SqlDataAdapter("Select * from TetkikListesi", conn);
            adptr.Fill(tbl);
            adptr.Fill(dtYazdir);
            dataGridView1.DataSource = tbl;
            conn.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
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
            {  for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {try
                    { Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow + i, StartCol + j];
                        myRange.Value2 = dataGridView1[j, i].Value == null ? "" : dataGridView1[j, i].Value;
                    }
                    catch {}
                 } }}}}

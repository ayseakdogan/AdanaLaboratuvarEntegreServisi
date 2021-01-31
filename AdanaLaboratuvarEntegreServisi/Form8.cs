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

    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           this.Dispose();
        }
        public string barkod;

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            ws_AdanaLabYeniEntegre.EntegreLBYSLabService LabService = new ws_AdanaLabYeniEntegre.EntegreLBYSLabService();
            NetworkCredential sifreleme = new NetworkCredential("10405413480", "1080");
            LabService.Credentials = sifreleme;
            ws_AdanaLabYeniEntegre.HastaSonucBilgisi[] sonuc = LabService.BarkodSonucBilgisi(barkod, "10405413480", "1080");


            DataTable dt = new DataTable();
            dt.Columns.Add("OrnekTipi");
            dt.Columns.Add("Sonuc");
            dt.Columns.Add("SonucAciklama");
            dt.Columns.Add("SonucBirim");
            dt.Columns.Add("SonucDurum");
            dt.Columns.Add("SonucOnayTarihi", typeof(System.DateTime));
            dt.Columns.Add("SonucReferans");
            dt.Columns.Add("SonucYorum");
            dt.Columns.Add("TestAdi");
            dt.Columns.Add("TestGrupAdi");
            dt.Columns.Add("TestID");
            dt.Columns.Add("TestParametreAdi");

            for (int i = 0; i < sonuc[0].TestSonuclari.Length; i++)
            {

                dt.Rows.Add(sonuc[0].TestSonuclari[i].OrnekTipi, sonuc[0].TestSonuclari[i].Sonuc, sonuc[0].TestSonuclari[i].SonucAciklama, sonuc[0].TestSonuclari[i].SonucBirim, sonuc[0].TestSonuclari[i].SonucDurum, sonuc[0].TestSonuclari[i].SonucOnayTarihi, sonuc[0].TestSonuclari[i].SonucReferans, sonuc[0].TestSonuclari[i].SonucYorum, sonuc[0].TestSonuclari[i].TestAdi, sonuc[0].TestSonuclari[i].TestGrupAdi, sonuc[0].TestSonuclari[i].TestID, sonuc[0].TestSonuclari[i].TestParametreAdi);
               

            }
            dataGridView1.DataSource = dt;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();

            excel.Visible = true;

            Microsoft.Office.Interop.Excel.Workbook workbook = excel.Workbooks.Add(System.Reflection.Missing.Value);

            Microsoft.Office.Interop.Excel.Worksheet sheet1 = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets[1];

            int StartCol = 1;

            int StartRow = 1;

            for (int j = 0; j < dataGridView1.Columns.Count; j++)
            {

                Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow, StartCol + j];

                myRange.Value2 = dataGridView1.Columns[j].HeaderText;

            }

            StartRow++;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {

                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {

                    try
                    {

                        Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow + i, StartCol + j];

                        myRange.Value2 = dataGridView1[j, i].Value == null ? "" : dataGridView1[j, i].Value;

                    }

                    catch
                    {
                    }

                }

            }
        }

       
    }
}
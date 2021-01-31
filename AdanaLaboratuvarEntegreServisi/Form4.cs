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
    public partial class Form4 : Form
    {
        public static string barkod = "";
        SqlConnection conn = new SqlConnection("Data Source=TSHBA\\SQLAYSE;Initial Catalog=ayse;User Id=sa;Password=12345;");
        public Form4()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();           
        }
        protected void DatagridYenile()
        {
            conn.Open();
            DataTable tbl = new DataTable();
            SqlDataAdapter adptr = new SqlDataAdapter("SELECT  Tetkik_Bilgisi.Tetkik_Id, Tetkik_Bilgisi.Tetkik, Tetkik_Bilgisi.Tup_Barkodu, HastaListesi.HASTA_KIMLIK_NO FROM Tetkik_Bilgisi INNER JOIN HastaListesi ON Tetkik_Bilgisi.Hasta_Kayit_Id = HastaListesi.HASTA_KAYIT_ID where HastaListesi.HASTA_KIMLIK_NO ='" + textBox1.Text.ToString() + "'", conn);
            adptr.Fill(tbl);
            conn.Close();
            dataGridView1.DataSource = tbl;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            ws_AdanaLabYeniEntegre.EntegreLBYSLabService LabService = new ws_AdanaLabYeniEntegre.EntegreLBYSLabService();
            NetworkCredential sifreleme = new NetworkCredential("10405413480", "1080");
            LabService.Credentials = sifreleme;           
            if (textBox1.Text != "")
            {
                ws_AdanaLabYeniEntegre.HastaSonucToplu[] barkodsonuc = LabService.TCSonucBilgisi("10405413480", "1080", textBox1.Text);
                DataTable dt = new DataTable();
                dt.Columns.Add("Barkod");
                dt.Columns.Add("AdSoyad");
                dt.Columns.Add("DoktorAd");
                dt.Columns.Add("BolumAd");
                dt.Columns.Add("IslemTarihi", typeof(System.DateTime));
                dt.Columns.Add("TCNo");
                for (int i = 0; i < barkodsonuc.Length; i++)
                {
                    for (int a = 0; a < barkodsonuc[i].TestSonuclariGenel.Length; a++)
                    {
                        dt.Rows.Add(barkodsonuc[i].TestSonuclariGenel[a].Barkod, barkodsonuc[i].TestSonuclariGenel[a].AdiSoyadi, barkodsonuc[i].TestSonuclariGenel[a].AileHekimiAdi, barkodsonuc[i].TestSonuclariGenel[a].BirimAdi, barkodsonuc[i].TestSonuclariGenel[a].istemTarihi, barkodsonuc[i].TestSonuclariGenel[a].TCKimlikNo);
                    }
                }
                dataGridView1.DataSource = dt;
            }
            else { MessageBox.Show("Lütfen hasta TC nosunu giriniz."); }
                conn.Close();            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            conn.Open();
            barkod = (dataGridView1.CurrentRow.Cells[0].Value).ToString();       
            conn.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (barkod != "")
            {               
                Form8 Form8 = new Form8();
                Form8.barkod = barkod;
                Form8.ShowDialog();                
            }
            else
            {
                MessageBox.Show("Lütfen barkodu seçiniz");
            }
        }   
    }
}

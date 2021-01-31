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
{
    public partial class Form2 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=TSHBA\\SQLAYSE;Initial Catalog=ayse;User Id=sa;Password=12345;");
        public Form2()
        {
            InitializeComponent();            
        }
        DataTable dt = new DataTable();
        //DataTable dt2 = new DataTable();
        DataTable dtsecilen = new DataTable();
        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlDataAdapter kmt = new SqlDataAdapter("SELECT TetkikAdi,TetkikKodu FROM TetkikListesi", conn);
                kmt.Fill(dt);
                listBox1.DisplayMember = dt.Columns["TetkikAdi"].ToString() ;
                listBox1.ValueMember = dt.Columns["TetkikAdi"].ToString();
                listBox1.DataSource = dt;
                conn.Close();
                dtsecilen.Columns.Add("TetkikAdi");
                dtsecilen.Columns.Add("TetkikKodu");
            }
            catch
            {
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {  string selected = listBox1.GetItemText(listBox1.SelectedValue);
           if (!listBox2.Items.Contains(listBox1.SelectedValue))
           {  dtsecilen.Rows.Add(selected);
               textBox1.Clear();
               listBox2.Items.Add(selected);
            }
           else
           { MessageBox.Show("Bu tetkik zaten var.");
           }
        }
        private void kapat_Click(object sender, EventArgs e)
        { this.Close();}
        private void textBox1_TextChanged(object sender, EventArgs e)
        {   DataView dv = dt.DefaultView;
            dv.RowFilter = "TetkikAdi Like '" + textBox1.Text + "%'";
            listBox1.DataSource = dv;           
        }
        private void gonder_Click(object sender, EventArgs e)
        {   Form6 frm= new Form6();
            frm.ShowDialog();
            //ws_AdanaLabYeniEntegre.EntegreLBYSLabService labservis = new ws_AdanaLabYeniEntegre.EntegreLBYSLabService();
            DataTable dtnew = new DataTable();
            try
            { conn.Open();             
                int[] tetkikler = new int[dtsecilen.Rows.Count];
                for (int i = 0; i < dtsecilen.Rows.Count; i++)
                {   SqlCommand cmd = new SqlCommand("select TetkikKodu from TetkikListesi where TetkikAdi ='" + dtsecilen.Rows[i]["TetkikAdi"].ToString() + "'", conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    dtnew.Rows.Clear();
                    da.Fill(dtnew);
                    if (dtnew.Rows.Count > 0)
                    { tetkikler[i] = Convert.ToInt32(dtnew.Rows[0]["TetkikKodu"]);
                    }
                }
                //ws_AdanaLabYeniEntegre.TestEkleSonuc[] testsonuc = labservis.TestEkle("10405413480", "1080", "", "56101146802", "AYŞE", "AKDOĞAN", "2", Convert.ToDateTime("19.07.2016"), "Z00", tetkikler);
                ////        if (testsonuc[0].Sonuc == "Başarılı")
                //        {
                //SqlCommand cmdekle = new SqlCommand("select HASTA_KAYIT_ID from HastaListesi where HASTA_KIMLIK_NO ='" + textBox1.Text.ToString() + "'", conn);
                //SqlDataAdapter daekle = new SqlDataAdapter(cmdekle);
                //dt.Rows.Clear();
                //daekle.Fill(dt);
                //if (dt.Rows.Count > 0)
                //{
                    int sayi = tetkikler.Length;
                    for (int i = 0; i < sayi; i++)
                    {  SqlCommand kmt = new SqlCommand("insert into Tetkik_Bilgisi (Tetkik,Tup_Barkodu,Hasta_Kayit_Id) Values(@Tetkik,@Tup_Barkodu,@Hasta_Kayit_Id)", conn);
                        kmt.Parameters.AddWithValue("@Tetkik", tetkikler[i]);
                        kmt.Parameters.AddWithValue("@Tup_Barkodu", "5");
                        kmt.Parameters.AddWithValue("@Hasta_Kayit_Id", Convert.ToInt32(Form6.hastakayitid));
                        kmt.ExecuteNonQuery();
                    }
                    MessageBox.Show("İşlem Başarılı.");
                    //dtnew.Clear();
                    //dtsecilen.Clear();                    
                //}
                // }
                    conn.Close();
            } catch {}
            dtnew.Clear();
            dtsecilen.Clear();
            listBox2.Items.Clear();            
        }
        private void listBox2_DoubleClick(object sender, EventArgs e)
        {    string deger = listBox2.SelectedItem.ToString();
            listBox2.Items.Remove(listBox2.SelectedItem);
            string selected = listBox2.GetItemText(listBox2.SelectedItem);
            DataRow[] dtr = dtsecilen.Select("TetkikAdi='" + deger + "'");
            dtsecilen.Rows.Remove(dtr[0]);     
        }
        private void sorgula_Click(object sender, EventArgs e)
        {  Form4 Form4 = new Form4();
            Form4.ShowDialog();
        }
        private void hastaekle_Click(object sender, EventArgs e)
        {   Form5 Form5 = new Form5();
            Form5.ShowDialog();
        }
     }
}

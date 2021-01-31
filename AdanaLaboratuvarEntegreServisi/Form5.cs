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
    public partial class Form5 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=TSHBA\\SQLAYSE;Initial Catalog=ayse;User Id=sa;Password=12345;");
        public Form5()
        {
            InitializeComponent();
        }
        private void kayit_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Lütfen Cinsiyet Seçiniz..")
            {
                MessageBox.Show("Cinsiyet Alanı Boş Geçilemez.");            
            }
            else
            {  conn.Open();
                try
                {   SqlCommand kmt = new SqlCommand("insert into HastaListesi (KAYIT_TARIHI,HASTA_KIMLIK_NO,AD,SOYAD,CINSIYET_RESMI,DOGUM_TARIHI_RESMI) VALUES (@KAYIT_TARIHI,@HASTA_KIMLIK_NO,@AD,@SOYAD,@CINSIYET_RESMI,@DOGUM_TARIHI_RESMI)", conn);
                    kmt.Parameters.AddWithValue("@KAYIT_TARIHI", Convert.ToDateTime(DateTime.Now.ToString()));
                    kmt.Parameters.AddWithValue("@HASTA_KIMLIK_NO", textBox1.Text.ToString());
                    kmt.Parameters.AddWithValue("@AD", textBox2.Text.ToString());
                    kmt.Parameters.AddWithValue("@SOYAD", textBox3.Text);
                    kmt.Parameters.AddWithValue("@DOGUM_TARIHI_RESMI", Convert.ToDateTime(dateTimePicker1.Value.ToString()));
                    if (comboBox1.Text == "KADIN")
                    {
                        kmt.Parameters.AddWithValue("@CINSIYET_RESMI", Convert.ToInt32("2"));
                    }
                    else if (comboBox1.Text == "ERKEK")
                    {
                        kmt.Parameters.AddWithValue("@CINSIYET_RESMI", Convert.ToInt32("1"));
                    }
                    kmt.ExecuteNonQuery();
                }
                catch { }
                conn.Close();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                this.Close();
            }
        }
        private void Form5_Load(object sender, EventArgs e)
        {   comboBox1.Items.Add("KADIN");
            comboBox1.Items.Add("ERKEK");
        }   
    }
}

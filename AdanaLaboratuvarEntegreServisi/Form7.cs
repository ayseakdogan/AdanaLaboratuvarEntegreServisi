﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AdanaLaboratuvarEntegreServisi
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ayseDataSet2.HastaListesi' table. You can move, or remove it, as needed.
            this.HastaListesiTableAdapter.Fill(this.ayseDataSet2.HastaListesi);

            this.reportViewer1.RefreshReport();
        }
    }
}

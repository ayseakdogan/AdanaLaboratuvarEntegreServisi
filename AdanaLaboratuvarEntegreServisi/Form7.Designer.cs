namespace AdanaLaboratuvarEntegreServisi
{
    partial class Form7
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.HastaListesiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ayseDataSet2 = new AdanaLaboratuvarEntegreServisi.ayseDataSet2();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.HastaListesiTableAdapter = new AdanaLaboratuvarEntegreServisi.ayseDataSet2TableAdapters.HastaListesiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.HastaListesiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ayseDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // HastaListesiBindingSource
            // 
            this.HastaListesiBindingSource.DataMember = "HastaListesi";
            this.HastaListesiBindingSource.DataSource = this.ayseDataSet2;
            // 
            // ayseDataSet2
            // 
            this.ayseDataSet2.DataSetName = "ayseDataSet2";
            this.ayseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.HastaListesiBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AdanaLaboratuvarEntegreServisi.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-1, 1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(783, 383);
            this.reportViewer1.TabIndex = 0;
            // 
            // HastaListesiTableAdapter
            // 
            this.HastaListesiTableAdapter.ClearBeforeFill = true;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(781, 383);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HastaListesiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ayseDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource HastaListesiBindingSource;
        private ayseDataSet2 ayseDataSet2;
        private ayseDataSet2TableAdapters.HastaListesiTableAdapter HastaListesiTableAdapter;
    }
}
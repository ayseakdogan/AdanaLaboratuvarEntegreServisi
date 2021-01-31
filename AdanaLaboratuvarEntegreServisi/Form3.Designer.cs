namespace AdanaLaboratuvarEntegreServisi
{
    partial class Form3
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
            this.TetkikListesiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ayseDataSet1 = new AdanaLaboratuvarEntegreServisi.ayseDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.TetkikListesiTableAdapter = new AdanaLaboratuvarEntegreServisi.ayseDataSet1TableAdapters.TetkikListesiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TetkikListesiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ayseDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // TetkikListesiBindingSource
            // 
            this.TetkikListesiBindingSource.DataMember = "TetkikListesi";
            this.TetkikListesiBindingSource.DataSource = this.ayseDataSet1;
            // 
            // ayseDataSet1
            // 
            this.ayseDataSet1.DataSetName = "ayseDataSet1";
            this.ayseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.TetkikListesiBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AdanaLaboratuvarEntegreServisi.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(617, 412);
            this.reportViewer1.TabIndex = 0;
            // 
            // TetkikListesiTableAdapter
            // 
            this.TetkikListesiTableAdapter.ClearBeforeFill = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(616, 414);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TetkikListesiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ayseDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TetkikListesiBindingSource;
        private ayseDataSet1 ayseDataSet1;
        private ayseDataSet1TableAdapters.TetkikListesiTableAdapter TetkikListesiTableAdapter;

    }
}
namespace AdanaLaboratuvarEntegreServisi
{
    partial class FormGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGiris));
            this.hastaekle = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tetkikgonder = new System.Windows.Forms.Button();
            this.tetkikguncelle = new System.Windows.Forms.Button();
            this.sonucsorgula = new System.Windows.Forms.Button();
            this.hastalistesi = new System.Windows.Forms.Button();
            this.kapat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hastaekle
            // 
            this.hastaekle.BackColor = System.Drawing.SystemColors.Control;
            this.hastaekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hastaekle.ImageIndex = 2;
            this.hastaekle.ImageList = this.ımageList1;
            this.hastaekle.Location = new System.Drawing.Point(462, 56);
            this.hastaekle.Name = "hastaekle";
            this.hastaekle.Size = new System.Drawing.Size(169, 79);
            this.hastaekle.TabIndex = 0;
            this.hastaekle.Text = "Hasta Ekle";
            this.hastaekle.UseVisualStyleBackColor = false;
            this.hastaekle.Click += new System.EventHandler(this.hastaekle_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "index-chemical-icon.png");
            this.ımageList1.Images.SetKeyName(1, "Nurse Group Security Check.jpg");
            this.ımageList1.Images.SetKeyName(2, "Patient Group Add.jpg");
            this.ımageList1.Images.SetKeyName(3, "syncme-android-ikon-_300x300.png");
            this.ımageList1.Images.SetKeyName(4, "Zerode-Plump-Search.ico");
            this.ımageList1.Images.SetKeyName(5, "exit-button-icon-18.png");
            this.ımageList1.Images.SetKeyName(6, "send_right-512.png");
            // 
            // tetkikgonder
            // 
            this.tetkikgonder.BackColor = System.Drawing.SystemColors.Control;
            this.tetkikgonder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tetkikgonder.ImageIndex = 6;
            this.tetkikgonder.ImageList = this.ımageList1;
            this.tetkikgonder.Location = new System.Drawing.Point(228, 157);
            this.tetkikgonder.Name = "tetkikgonder";
            this.tetkikgonder.Size = new System.Drawing.Size(168, 79);
            this.tetkikgonder.TabIndex = 1;
            this.tetkikgonder.Text = "Tetkik Gönder";
            this.tetkikgonder.UseVisualStyleBackColor = false;
            this.tetkikgonder.Click += new System.EventHandler(this.tetkikgonder_Click);
            // 
            // tetkikguncelle
            // 
            this.tetkikguncelle.BackColor = System.Drawing.SystemColors.Control;
            this.tetkikguncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tetkikguncelle.ImageIndex = 3;
            this.tetkikguncelle.ImageList = this.ımageList1;
            this.tetkikguncelle.Location = new System.Drawing.Point(228, 56);
            this.tetkikguncelle.Name = "tetkikguncelle";
            this.tetkikguncelle.Size = new System.Drawing.Size(168, 79);
            this.tetkikguncelle.TabIndex = 2;
            this.tetkikguncelle.Text = "Tetkik Güncelle";
            this.tetkikguncelle.UseVisualStyleBackColor = false;
            this.tetkikguncelle.Click += new System.EventHandler(this.tetkikguncelle_Click);
            // 
            // sonucsorgula
            // 
            this.sonucsorgula.BackColor = System.Drawing.SystemColors.Control;
            this.sonucsorgula.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sonucsorgula.ImageIndex = 4;
            this.sonucsorgula.ImageList = this.ımageList1;
            this.sonucsorgula.Location = new System.Drawing.Point(347, 261);
            this.sonucsorgula.Name = "sonucsorgula";
            this.sonucsorgula.Size = new System.Drawing.Size(165, 79);
            this.sonucsorgula.TabIndex = 3;
            this.sonucsorgula.Text = "TC ile Sonuç Sorgula";
            this.sonucsorgula.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sonucsorgula.UseVisualStyleBackColor = false;
            this.sonucsorgula.Click += new System.EventHandler(this.sonucsorgula_Click);
            // 
            // hastalistesi
            // 
            this.hastalistesi.BackColor = System.Drawing.SystemColors.Control;
            this.hastalistesi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hastalistesi.ImageIndex = 1;
            this.hastalistesi.ImageList = this.ımageList1;
            this.hastalistesi.Location = new System.Drawing.Point(462, 157);
            this.hastalistesi.Name = "hastalistesi";
            this.hastalistesi.Size = new System.Drawing.Size(169, 79);
            this.hastalistesi.TabIndex = 4;
            this.hastalistesi.Text = "Hasta Listesi";
            this.hastalistesi.UseVisualStyleBackColor = false;
            this.hastalistesi.Click += new System.EventHandler(this.hastalistesi_Click);
            // 
            // kapat
            // 
            this.kapat.BackColor = System.Drawing.SystemColors.Control;
            this.kapat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kapat.ImageIndex = 5;
            this.kapat.ImageList = this.ımageList1;
            this.kapat.Location = new System.Drawing.Point(44, 261);
            this.kapat.Name = "kapat";
            this.kapat.Size = new System.Drawing.Size(167, 79);
            this.kapat.TabIndex = 5;
            this.kapat.Text = "KAPAT";
            this.kapat.UseVisualStyleBackColor = false;
            this.kapat.Click += new System.EventHandler(this.kapat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(315, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ADANA LABORATUVAR ENTEGRE SERVİSİ";
            // 
            // FormGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(643, 362);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kapat);
            this.Controls.Add(this.hastalistesi);
            this.Controls.Add(this.sonucsorgula);
            this.Controls.Add(this.tetkikguncelle);
            this.Controls.Add(this.tetkikgonder);
            this.Controls.Add(this.hastaekle);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Name = "FormGiris";
            this.Text = "FormGiris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hastaekle;
        private System.Windows.Forms.Button tetkikgonder;
        private System.Windows.Forms.Button tetkikguncelle;
        private System.Windows.Forms.Button sonucsorgula;
        private System.Windows.Forms.Button hastalistesi;
        private System.Windows.Forms.Button kapat;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label label1;
    }
}
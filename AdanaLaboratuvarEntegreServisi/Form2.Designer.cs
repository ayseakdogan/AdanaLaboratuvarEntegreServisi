namespace AdanaLaboratuvarEntegreServisi
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.kapat = new System.Windows.Forms.Button();
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.gonder = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.sorgula = new System.Windows.Forms.Button();
            this.hastaekle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(29, 46);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(214, 329);
            this.listBox1.TabIndex = 0;
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(263, 46);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(230, 329);
            this.listBox2.TabIndex = 1;
            this.listBox2.DoubleClick += new System.EventHandler(this.listBox2_DoubleClick);
            // 
            // kapat
            // 
            this.kapat.BackColor = System.Drawing.SystemColors.Control;
            this.kapat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kapat.ImageIndex = 0;
            this.kapat.ImageList = this.ımageList2;
            this.kapat.Location = new System.Drawing.Point(513, 316);
            this.kapat.Name = "kapat";
            this.kapat.Size = new System.Drawing.Size(138, 59);
            this.kapat.TabIndex = 2;
            this.kapat.Text = "KAPAT";
            this.kapat.UseVisualStyleBackColor = false;
            this.kapat.Click += new System.EventHandler(this.kapat_Click);
            // 
            // ımageList2
            // 
            this.ımageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList2.ImageStream")));
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList2.Images.SetKeyName(0, "exit-button-icon-18.png");
            // 
            // gonder
            // 
            this.gonder.BackColor = System.Drawing.SystemColors.Control;
            this.gonder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gonder.ImageIndex = 0;
            this.gonder.ImageList = this.ımageList1;
            this.gonder.Location = new System.Drawing.Point(513, 46);
            this.gonder.Name = "gonder";
            this.gonder.Size = new System.Drawing.Size(138, 59);
            this.gonder.TabIndex = 3;
            this.gonder.Text = "GÖNDER";
            this.gonder.UseVisualStyleBackColor = false;
            this.gonder.Click += new System.EventHandler(this.gonder_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "send_right-512.png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(75, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tetkik Arama :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(183, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(274, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // sorgula
            // 
            this.sorgula.BackColor = System.Drawing.SystemColors.Control;
            this.sorgula.Location = new System.Drawing.Point(513, 220);
            this.sorgula.Name = "sorgula";
            this.sorgula.Size = new System.Drawing.Size(138, 59);
            this.sorgula.TabIndex = 7;
            this.sorgula.Text = "SONUÇ SORGULA";
            this.sorgula.UseVisualStyleBackColor = false;
            this.sorgula.Click += new System.EventHandler(this.sorgula_Click);
            // 
            // hastaekle
            // 
            this.hastaekle.BackColor = System.Drawing.SystemColors.Control;
            this.hastaekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hastaekle.ImageIndex = 1;
            this.hastaekle.Location = new System.Drawing.Point(513, 136);
            this.hastaekle.Name = "hastaekle";
            this.hastaekle.Size = new System.Drawing.Size(138, 59);
            this.hastaekle.TabIndex = 8;
            this.hastaekle.Text = "HASTA EKLE";
            this.hastaekle.UseVisualStyleBackColor = false;
            this.hastaekle.Click += new System.EventHandler(this.hastaekle_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(682, 407);
            this.Controls.Add(this.hastaekle);
            this.Controls.Add(this.sorgula);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gonder);
            this.Controls.Add(this.kapat);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button kapat;
        private System.Windows.Forms.Button gonder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button sorgula;
        private System.Windows.Forms.Button hastaekle;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.ImageList ımageList2;
    }
}
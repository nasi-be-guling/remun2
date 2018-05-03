namespace remun2.ENTRY.DOSEN
{
    partial class Form_Penelitian
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
            this.lvTampil = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bLoad = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbTahun = new System.Windows.Forms.ComboBox();
            this.cbBulan = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bAdd = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtJamCapaian = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBuktiDokumen = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMasaPenugasan = new System.Windows.Forms.TextBox();
            this.txtJamTarget = new System.Windows.Forms.TextBox();
            this.txtBuktiPenugasan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtJenisKegiatan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvTampil
            // 
            this.lvTampil.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvTampil.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvTampil.FullRowSelect = true;
            this.lvTampil.GridLines = true;
            this.lvTampil.Location = new System.Drawing.Point(22, 304);
            this.lvTampil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lvTampil.Name = "lvTampil";
            this.lvTampil.Size = new System.Drawing.Size(1289, 430);
            this.lvTampil.TabIndex = 20;
            this.lvTampil.UseCompatibleStateImageBehavior = false;
            this.lvTampil.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "NO";
            this.columnHeader1.Width = 41;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "JENIS KEGIATAN";
            this.columnHeader2.Width = 361;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "BUKTI PENUGASAN";
            this.columnHeader3.Width = 169;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "JAM (TARGET)";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "MASA PENUGASAN";
            this.columnHeader5.Width = 162;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "BUKTI DOKUMEN";
            this.columnHeader6.Width = 181;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "JAM (CAPAIAN)";
            this.columnHeader7.Width = 118;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "REKOMENDASI";
            this.columnHeader8.Width = 123;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(18, 279);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(333, 20);
            this.linkLabel1.TabIndex = 19;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Panduan konversi SKS ke JAM silahkan klik link ini";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bLoad);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.bAdd);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(21, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1058, 237);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ENTRY PENELITIAN";
            // 
            // bLoad
            // 
            this.bLoad.Location = new System.Drawing.Point(940, 139);
            this.bLoad.Name = "bLoad";
            this.bLoad.Size = new System.Drawing.Size(112, 91);
            this.bLoad.TabIndex = 17;
            this.bLoad.Text = "LOAD";
            this.bLoad.UseVisualStyleBackColor = true;
            this.bLoad.Visible = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbTahun);
            this.groupBox4.Controls.Add(this.cbBulan);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(488, 128);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(446, 102);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Load Data Lama";
            this.groupBox4.Visible = false;
            // 
            // cbTahun
            // 
            this.cbTahun.FormattingEnabled = true;
            this.cbTahun.Items.AddRange(new object[] {
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026"});
            this.cbTahun.Location = new System.Drawing.Point(126, 59);
            this.cbTahun.Name = "cbTahun";
            this.cbTahun.Size = new System.Drawing.Size(121, 28);
            this.cbTahun.TabIndex = 16;
            // 
            // cbBulan
            // 
            this.cbBulan.FormattingEnabled = true;
            this.cbBulan.Items.AddRange(new object[] {
            "1 - JANUARI",
            "2 - FEBRUARI",
            "3 - MARET",
            "4 - APRIL",
            "5 - MEI",
            "6 - JUNI",
            "7 - JULI",
            "8 - AGUSTUS",
            "9 - SEPTEMBER",
            "10 - OKTOBER ",
            "11 - NOVEMBER",
            "12 - DESEMBER"});
            this.cbBulan.Location = new System.Drawing.Point(126, 23);
            this.cbBulan.Name = "cbBulan";
            this.cbBulan.Size = new System.Drawing.Size(182, 28);
            this.cbBulan.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(73, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Tahun";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(74, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Bulan";
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(940, 28);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(112, 91);
            this.bAdd.TabIndex = 12;
            this.bAdd.Text = "ADD";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtJamCapaian);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtBuktiDokumen);
            this.groupBox3.Location = new System.Drawing.Point(488, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(446, 99);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Capaian";
            // 
            // txtJamCapaian
            // 
            this.txtJamCapaian.Location = new System.Drawing.Point(126, 58);
            this.txtJamCapaian.MaxLength = 5;
            this.txtJamCapaian.Name = "txtJamCapaian";
            this.txtJamCapaian.Size = new System.Drawing.Size(60, 27);
            this.txtJamCapaian.TabIndex = 11;
            this.txtJamCapaian.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJamCapaian_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(85, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Jam";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Bukti Dokumen";
            // 
            // txtBuktiDokumen
            // 
            this.txtBuktiDokumen.Location = new System.Drawing.Point(126, 25);
            this.txtBuktiDokumen.MaxLength = 255;
            this.txtBuktiDokumen.Name = "txtBuktiDokumen";
            this.txtBuktiDokumen.Size = new System.Drawing.Size(310, 27);
            this.txtBuktiDokumen.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtMasaPenugasan);
            this.groupBox2.Controls.Add(this.txtJamTarget);
            this.groupBox2.Controls.Add(this.txtBuktiPenugasan);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtJenisKegiatan);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(6, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(465, 210);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Target";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Masa Penugasan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Jam";
            // 
            // txtMasaPenugasan
            // 
            this.txtMasaPenugasan.Location = new System.Drawing.Point(136, 171);
            this.txtMasaPenugasan.MaxLength = 255;
            this.txtMasaPenugasan.Name = "txtMasaPenugasan";
            this.txtMasaPenugasan.Size = new System.Drawing.Size(310, 27);
            this.txtMasaPenugasan.TabIndex = 7;
            // 
            // txtJamTarget
            // 
            this.txtJamTarget.Location = new System.Drawing.Point(136, 138);
            this.txtJamTarget.MaxLength = 5;
            this.txtJamTarget.Name = "txtJamTarget";
            this.txtJamTarget.Size = new System.Drawing.Size(60, 27);
            this.txtJamTarget.TabIndex = 5;
            this.txtJamTarget.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJamTarget_KeyPress);
            // 
            // txtBuktiPenugasan
            // 
            this.txtBuktiPenugasan.Location = new System.Drawing.Point(136, 105);
            this.txtBuktiPenugasan.MaxLength = 255;
            this.txtBuktiPenugasan.Name = "txtBuktiPenugasan";
            this.txtBuktiPenugasan.Size = new System.Drawing.Size(310, 27);
            this.txtBuktiPenugasan.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bukti Penugasan";
            // 
            // txtJenisKegiatan
            // 
            this.txtJenisKegiatan.Location = new System.Drawing.Point(136, 25);
            this.txtJenisKegiatan.MaxLength = 600;
            this.txtJenisKegiatan.Multiline = true;
            this.txtJenisKegiatan.Name = "txtJenisKegiatan";
            this.txtJenisKegiatan.Size = new System.Drawing.Size(310, 74);
            this.txtJenisKegiatan.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jenis Kegiatan";
            // 
            // bSave
            // 
            this.bSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bSave.Location = new System.Drawing.Point(1175, 190);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(136, 68);
            this.bSave.TabIndex = 18;
            this.bSave.Text = "SAVE";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1095, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 41);
            this.button1.TabIndex = 21;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_Penelitian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 748);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lvTampil);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Penelitian";
            this.ShowIcon = false;
            this.Text = "ENTRY PENELITIAN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvTampil;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtBuktiDokumen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMasaPenugasan;
        private System.Windows.Forms.TextBox txtJamTarget;
        private System.Windows.Forms.TextBox txtBuktiPenugasan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtJenisKegiatan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtJamCapaian;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bLoad;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cbTahun;
        private System.Windows.Forms.ComboBox cbBulan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
    }
}
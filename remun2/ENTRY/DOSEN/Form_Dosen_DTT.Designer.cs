namespace remun2.ENTRY.DOSEN
{
    partial class Form_Dosen_DTT
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
            this.cbPengakuanBebanKinerja = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbJurnalPublikasi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbNarasumber = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbHaki = new System.Windows.Forms.ComboBox();
            this.cbBukuReferensiMonograf = new System.Windows.Forms.ComboBox();
            this.cbPelatihanKompetensi = new System.Windows.Forms.ComboBox();
            this.cbKelebihanJamTeori = new System.Windows.Forms.ComboBox();
            this.cbKepanitiaanDiluarTugasUtama = new System.Windows.Forms.ComboBox();
            this.bSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mohonTidakRightClickToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbPengakuanBebanKinerja
            // 
            this.cbPengakuanBebanKinerja.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbPengakuanBebanKinerja.FormattingEnabled = true;
            this.cbPengakuanBebanKinerja.Items.AddRange(new object[] {
            "Tidak Ada",
            "KaProdi lokasi / SekJur / KaUnit /Ka.SPI/kasub Unit/Koord/Koord Dos/Sekprodi",
            "Penanggung jawab di bawah Ka.Unit/Ka.SPI/Kepala Urusan",
            "Penanggung jawab di bawah Ka.Sub Unit/Koordinator"});
            this.cbPengakuanBebanKinerja.Location = new System.Drawing.Point(388, 39);
            this.cbPengakuanBebanKinerja.Name = "cbPengakuanBebanKinerja";
            this.cbPengakuanBebanKinerja.Size = new System.Drawing.Size(522, 28);
            this.cbPengakuanBebanKinerja.TabIndex = 2;
            this.cbPengakuanBebanKinerja.Tag = "0";
            this.cbPengakuanBebanKinerja.SelectedIndexChanged += new System.EventHandler(this.cbPengakuanBebanKinerja_SelectedIndexChanged);
            this.cbPengakuanBebanKinerja.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbPengakuanBebanKinerja_KeyPress);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(50, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(222, 20);
            this.label11.TabIndex = 1;
            this.label11.Text = "1. PENGAKUAN BEBAN KINERJA";
            // 
            // cbJurnalPublikasi
            // 
            this.cbJurnalPublikasi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbJurnalPublikasi.FormattingEnabled = true;
            this.cbJurnalPublikasi.Items.AddRange(new object[] {
            "Tidak punya",
            "Proses (dengan bukti) pengajuan publikasi Nasional (ISSN/ISBN)",
            "Proses  (dengan bukti) pengajuan publikasi Nasional terakreditasi (ISSN/ISBN)",
            "Nasional ISSN 1 buah/proseding nasional (ISSN/ISBN)",
            "Proses (dengan bukti) pengajuan publikasi Nasional terindek Dikti",
            "Proses (dengan bukti) pengajuan publikasi Internasional Bereputasi (SCOPUS, SCIMA" +
                "GO, semisalnya)",
            "Nasional ISSN 2 buah/proseding nasional (ISSN/ISBN)",
            "Nasional terakreditasi 1 buah",
            "Nasional terakreditasi 2 buah",
            "Internasional terindek dikti/poster/proseding internasional",
            "Internasional bereputasi (SCOPUS, SCIMAGHO, dan semisalnya)"});
            this.cbJurnalPublikasi.Location = new System.Drawing.Point(388, 83);
            this.cbJurnalPublikasi.Name = "cbJurnalPublikasi";
            this.cbJurnalPublikasi.Size = new System.Drawing.Size(522, 28);
            this.cbJurnalPublikasi.TabIndex = 4;
            this.cbJurnalPublikasi.Tag = "1";
            this.cbJurnalPublikasi.SelectedIndexChanged += new System.EventHandler(this.cbJurnalPublikasi_SelectedIndexChanged);
            this.cbJurnalPublikasi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbJurnalPublikasi_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "2. JURNAL / PUBLIKASI";
            // 
            // cbNarasumber
            // 
            this.cbNarasumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbNarasumber.FormattingEnabled = true;
            this.cbNarasumber.Items.AddRange(new object[] {
            "Tidak pernah",
            "Lokal/institusi 1-3 kali",
            "Lokal/institusi > 3 kali",
            "nasional 1-3",
            "nasional >3",
            "Internasional sekali",
            "Internasional lebih dari sekali"});
            this.cbNarasumber.Location = new System.Drawing.Point(388, 130);
            this.cbNarasumber.Name = "cbNarasumber";
            this.cbNarasumber.Size = new System.Drawing.Size(522, 28);
            this.cbNarasumber.TabIndex = 6;
            this.cbNarasumber.Tag = "2";
            this.cbNarasumber.SelectedIndexChanged += new System.EventHandler(this.cbNarasumber_SelectedIndexChanged);
            this.cbNarasumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbNarasumber_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "3. NARASUMBER";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "4. HAKI";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "5. BUKU REFERENSI / MONOGRAF";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(257, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "6. PELATIHAN KOMPETENSI > 30 JAM";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(313, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "7. KELEBIHAN JAM TEORI+PRAKTIK (>12 SKS)";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 355);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(279, 40);
            this.label7.TabIndex = 15;
            this.label7.Text = "8. KEPANITIAAN DILUAR TUGAS UTAMA \r\nKHUSUS DOSEN MURNI (DS)";
            // 
            // cbHaki
            // 
            this.cbHaki.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbHaki.FormattingEnabled = true;
            this.cbHaki.Items.AddRange(new object[] {
            "Tidak punya",
            "Masih proses",
            "Sudah terbit"});
            this.cbHaki.Location = new System.Drawing.Point(388, 176);
            this.cbHaki.Name = "cbHaki";
            this.cbHaki.Size = new System.Drawing.Size(522, 28);
            this.cbHaki.TabIndex = 8;
            this.cbHaki.Tag = "3";
            this.cbHaki.SelectedIndexChanged += new System.EventHandler(this.cbHaki_SelectedIndexChanged);
            this.cbHaki.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbHaki_KeyPress);
            // 
            // cbBukuReferensiMonograf
            // 
            this.cbBukuReferensiMonograf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbBukuReferensiMonograf.FormattingEnabled = true;
            this.cbBukuReferensiMonograf.Items.AddRange(new object[] {
            "Tidak punya",
            "Masih proses",
            "Sudah terbit"});
            this.cbBukuReferensiMonograf.Location = new System.Drawing.Point(388, 222);
            this.cbBukuReferensiMonograf.Name = "cbBukuReferensiMonograf";
            this.cbBukuReferensiMonograf.Size = new System.Drawing.Size(522, 28);
            this.cbBukuReferensiMonograf.TabIndex = 10;
            this.cbBukuReferensiMonograf.Tag = "4";
            this.cbBukuReferensiMonograf.SelectedIndexChanged += new System.EventHandler(this.cbBukuReferensiMonograf_SelectedIndexChanged);
            this.cbBukuReferensiMonograf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbBukuReferensiMonograf_KeyPress);
            // 
            // cbPelatihanKompetensi
            // 
            this.cbPelatihanKompetensi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbPelatihanKompetensi.FormattingEnabled = true;
            this.cbPelatihanKompetensi.Items.AddRange(new object[] {
            "Tidak punya",
            "Punya sekali saja",
            "Punya lebih dari sekali"});
            this.cbPelatihanKompetensi.Location = new System.Drawing.Point(388, 268);
            this.cbPelatihanKompetensi.Name = "cbPelatihanKompetensi";
            this.cbPelatihanKompetensi.Size = new System.Drawing.Size(522, 28);
            this.cbPelatihanKompetensi.TabIndex = 12;
            this.cbPelatihanKompetensi.Tag = "5";
            this.cbPelatihanKompetensi.SelectedIndexChanged += new System.EventHandler(this.cbPelatihanKompetensi_SelectedIndexChanged);
            this.cbPelatihanKompetensi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbPelatihanKompetensi_KeyPress);
            // 
            // cbKelebihanJamTeori
            // 
            this.cbKelebihanJamTeori.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbKelebihanJamTeori.FormattingEnabled = true;
            this.cbKelebihanJamTeori.Items.AddRange(new object[] {
            "Tidak ada Kelebihan",
            "Kelebihan ≤ 10,5 jam per bulan",
            "Kelebihan 10,6 - 17,5 jam per bulan",
            "Kelebihan ≥ 17,5 jam per bulan"});
            this.cbKelebihanJamTeori.Location = new System.Drawing.Point(388, 313);
            this.cbKelebihanJamTeori.Name = "cbKelebihanJamTeori";
            this.cbKelebihanJamTeori.Size = new System.Drawing.Size(522, 28);
            this.cbKelebihanJamTeori.TabIndex = 14;
            this.cbKelebihanJamTeori.Tag = "6";
            this.cbKelebihanJamTeori.SelectedIndexChanged += new System.EventHandler(this.cbKelebihanJamTeori_SelectedIndexChanged);
            this.cbKelebihanJamTeori.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbKelebihanJamTeori_KeyPress);
            // 
            // cbKepanitiaanDiluarTugasUtama
            // 
            this.cbKepanitiaanDiluarTugasUtama.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbKepanitiaanDiluarTugasUtama.FormattingEnabled = true;
            this.cbKepanitiaanDiluarTugasUtama.Items.AddRange(new object[] {
            "Tidak terlibat dalam kegiatan apapun",
            "Aktif dalam kegiatan sekali saja",
            "Aktif dalam kegiatan 2-3 kali",
            "Aktif dalam kegiatan > 3 kali"});
            this.cbKepanitiaanDiluarTugasUtama.Location = new System.Drawing.Point(388, 361);
            this.cbKepanitiaanDiluarTugasUtama.Name = "cbKepanitiaanDiluarTugasUtama";
            this.cbKepanitiaanDiluarTugasUtama.Size = new System.Drawing.Size(522, 28);
            this.cbKepanitiaanDiluarTugasUtama.TabIndex = 16;
            this.cbKepanitiaanDiluarTugasUtama.Tag = "7";
            this.cbKepanitiaanDiluarTugasUtama.SelectedIndexChanged += new System.EventHandler(this.cbKepanitiaanDiluarTugasUtama_SelectedIndexChanged);
            this.cbKepanitiaanDiluarTugasUtama.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbKepanitiaanDiluarTugasUtama_KeyPress);
            // 
            // bSave
            // 
            this.bSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bSave.Location = new System.Drawing.Point(774, 406);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(136, 68);
            this.bSave.TabIndex = 17;
            this.bSave.Text = "SAVE";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.bSave);
            this.panel1.Controls.Add(this.cbKepanitiaanDiluarTugasUtama);
            this.panel1.Controls.Add(this.cbKelebihanJamTeori);
            this.panel1.Controls.Add(this.cbPelatihanKompetensi);
            this.panel1.Controls.Add(this.cbBukuReferensiMonograf);
            this.panel1.Controls.Add(this.cbHaki);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbNarasumber);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbJurnalPublikasi);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbPengakuanBebanKinerja);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(25, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(947, 508);
            this.panel1.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(740, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "ENTRY BAGI DOSEN DENGAN TUGAS TAMBAHAN (DTT) DI LUAR TUGAS UTAMA SEBAGAI DOSEN BI" +
    "ASA (DS)";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mohonTidakRightClickToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(206, 26);
            // 
            // mohonTidakRightClickToolStripMenuItem
            // 
            this.mohonTidakRightClickToolStripMenuItem.Name = "mohonTidakRightClickToolStripMenuItem";
            this.mohonTidakRightClickToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.mohonTidakRightClickToolStripMenuItem.Text = "Mohon Tidak Right Click";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(434, 441);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 18;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_Dosen_DTT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 561);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Dosen_DTT";
            this.ShowInTaskbar = false;
            this.Text = "ENTRY DTT DI LUAR TUGAS UTAMA SEBAGAI DS";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPengakuanBebanKinerja;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbJurnalPublikasi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbNarasumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbHaki;
        private System.Windows.Forms.ComboBox cbBukuReferensiMonograf;
        private System.Windows.Forms.ComboBox cbPelatihanKompetensi;
        private System.Windows.Forms.ComboBox cbKelebihanJamTeori;
        private System.Windows.Forms.ComboBox cbKepanitiaanDiluarTugasUtama;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mohonTidakRightClickToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}
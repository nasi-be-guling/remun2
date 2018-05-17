﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using _encryption;
using _connectMySQL;

namespace remun2.ENTRY.DOSEN
{
    public partial class Form_Dosen_DTT : Form
    {
        #region KOMPONEN WAJIB
        private readonly CConnection _connect = new CConnection();
        private MySqlConnection _connection;
        private string _sqlQuery;
        private readonly string _configurationManager = Properties.Settings.Default.Setting;
        private readonly CLASS.Class_TOOLS _tools = new CLASS.Class_TOOLS();
        /*
         * contoh class
        private class Pegawai
        {
            private string id;
            private string nama;

            public Pegawai(string id, string nama)
            {
                this.id = id;
                this.nama = nama;
            }

            public string Id
            {
                get { return id; }
                set { id = value; }
            }
            public string Nama
            {
                get { return nama; }
                set { nama = value; }
            }
        }
          
         */
        #endregion

        public Form_Dosen_DTT()
        {
            InitializeComponent();
        }

        public int ID_USER;

        private void bSave_Click(object sender, EventArgs e)
        {
            if (indexPoint1 < 0 || indexPoint2 < 0 || indexPoint3 < 0 || indexPoint4 < 0 || indexPoint5 < 0 || indexPoint6 < 0 ||
                indexPoint7 < 0 || indexPoint8 < 0 )
            {
                MessageBox.Show("Harap Mengisi Semua Isian dengan Memilih Salah satu dari Pilihan", "ERROR");
                return;
            }

            if (MessageBox.Show("Apakah Sudah Yakin Akan Menyimpan data?", "KONFIRMASI", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            string errMsg = "";
            _connection = _connect.Connect(_configurationManager, ref errMsg, "GhY873LhT");
            if (errMsg != "")
            {
                MessageBox.Show(errMsg);
                return;
            }
            MySqlTransaction _transaction = _connection.BeginTransaction();
            _sqlQuery = "insert into t_dtt_ds (namaJenis, kodeJenis, namaPilihan, nilai, bulan, tahun, tanggal, statusDP, idUser) values " +
                "(@namaJenis, @kodeJenis, @namaPilihan, @nilai, @bulan, @tahun, @tanggal, @statusDP, @idUser);";
            MySqlCommand cmd = new MySqlCommand(_sqlQuery, _connection, _transaction);


            cmd.Parameters.Add("@namaJenis", MySqlDbType.VarChar, 255);
            cmd.Parameters.Add("@kodeJenis", MySqlDbType.Int16, 11);
            cmd.Parameters.Add("@namaPilihan", MySqlDbType.VarChar, 255);
            cmd.Parameters.Add("@nilai", MySqlDbType.Double);
            cmd.Parameters.Add("@bulan", MySqlDbType.Int16, 11);
            cmd.Parameters.Add("@tahun", MySqlDbType.Int16, 11);
            cmd.Parameters.Add("@tanggal", MySqlDbType.DateTime);
            cmd.Parameters.Add("@statusDP", MySqlDbType.Int16, 11);
            cmd.Parameters.Add("@idUser", MySqlDbType.Int16, 11);

            int rowsAffected = 0;
            try
            {
                for (int i = 0; i < 8; i++)
                {
                    cmd.Parameters["@namaJenis"].Value = getLabels[i];
                    cmd.Parameters["@kodeJenis"].Value = i+1;
                    cmd.Parameters["@namaPilihan"].Value = getComboText[i];
                    cmd.Parameters["@nilai"].Value = pointDTT[i];
                    cmd.Parameters["@bulan"].Value = DateTime.Now.Month;
                    cmd.Parameters["@tahun"].Value = DateTime.Now.Year;
                    cmd.Parameters["@tanggal"].Value = DateTime.Now;
                    cmd.Parameters["@statusDP"].Value = 1;
                    cmd.Parameters["@idUser"].Value = ID_USER;

                    rowsAffected = cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                _transaction.Rollback();
                MessageBox.Show("Terjadi kesalahan dengan kode:" + ex.Message);
                return;
            }

            if (rowsAffected > 0)
            {
                _transaction.Commit();
                MessageBox.Show("Penyimpanan Berhasil");
            }
            Bersih2();
            _connection.Close();
        }

        #region COMBOBOX HANDLER
        private void cbPengakuanBebanKinerja_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbJurnalPublikasi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbNarasumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbHaki_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbBukuReferensiMonograf_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbPelatihanKompetensi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbKelebihanJamTeori_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbKepanitiaanDiluarTugasUtama_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        #endregion

        private void Bersih2()
        {
            Array.Clear(pointDTT, 0, pointDTT.Length);
            Array.Clear(getLabels, 0, getLabels.Length);
            Array.Clear(getComboText, 0, getComboText.Length);

            indexPoint1 = -1;
            indexPoint2 = -1;
            indexPoint3 = -1;
            indexPoint4 = -1;
            indexPoint5 = -1;
            indexPoint6 = -1;
            indexPoint7 = -1;
            indexPoint8 = -1;

            cbPengakuanBebanKinerja.Text = "";
            cbJurnalPublikasi.Text = "";
            cbNarasumber.Text = "";
            cbHaki.Text = "";
            cbBukuReferensiMonograf.Text = "";
            cbPelatihanKompetensi.Text = "";
            cbKelebihanJamTeori.Text = "";
            cbKepanitiaanDiluarTugasUtama.Text = "";
        }  

        #region COMBOBOX INDEX HANDLER
        private double[] pointDTT = new double[8];
        private string[] getLabels = new string[8];
        private string[] getComboText = new string[8];

        private int indexPoint1 = -1;
        private int indexPoint2 = -1;
        private int indexPoint3 = -1;
        private int indexPoint4 = -1;
        private int indexPoint5 = -1;
        private int indexPoint6 = -1;
        private int indexPoint7 = -1;
        private int indexPoint8 = -1;


        private void cbPengakuanBebanKinerja_SelectedIndexChanged(object sender, EventArgs e)
        {
            indexPoint1 = cbPengakuanBebanKinerja.SelectedIndex;
            getLabels[0] = "PENGAKUAN BEBAN KINERJA";
            getComboText[0] = cbPengakuanBebanKinerja.Text;
            switch (cbPengakuanBebanKinerja.SelectedIndex)
            {
                case 0:
                    {
                        pointDTT[0] = 0;
                        break;
                    }
                case 1:
                    {
                        pointDTT[0] = 3;
                        break;
                    }
                case 2:
                    {
                        pointDTT[0] = 2;
                        break;
                    }
                case 3:
                    {
                        pointDTT[0] = 1;
                        break;
                    }
            }
        }

        private void cbJurnalPublikasi_SelectedIndexChanged(object sender, EventArgs e)
        {
            getLabels[1] = "JURNAL / PUBLIKASI";
            getComboText[1] = cbJurnalPublikasi.Text;
            indexPoint2 = cbJurnalPublikasi.SelectedIndex;
            switch (cbJurnalPublikasi.SelectedIndex)
            {
                case 0:
                    {
                        pointDTT[1] = 0;
                        break;
                    }
                case 1:
                    {
                        pointDTT[1] = 0.4;
                        break;
                    }
                case 2:
                    {
                        pointDTT[1] = 0.8;
                        break;
                    }
                case 3:
                    {
                        pointDTT[1] = 1;
                        break;
                    }
                case 4:
                    {
                        pointDTT[1] = 1.6;
                        break;
                    }
                case 5:
                    {
                        pointDTT[1] = 2.4;
                        break;
                    }
                case 6:
                    {
                        pointDTT[1] = 2;
                        break;
                    }
                case 7:
                    {
                        pointDTT[1] = 2;
                        break;
                    }
                case 8:
                    {
                        pointDTT[1] = 3;
                        break;
                    }
                case 9:
                    {
                        pointDTT[1] = 4;
                        break;
                    }
                case 10:
                    {
                        pointDTT[1] = 6;
                        break;
                    }
            }
        }

        private void cbNarasumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            getLabels[2] = "NARASUMBER";
            getComboText[2] = cbNarasumber.Text;
            indexPoint3 = cbNarasumber.SelectedIndex;
            switch (cbNarasumber.SelectedIndex)
            {
                case 0:
                    {
                        pointDTT[2] = 0;
                        break;
                    }
                case 1:
                    {
                        pointDTT[2] = 1;
                        break;
                    }
                case 2:
                    {
                        pointDTT[2] = 2;
                        break;
                    }
                case 3:
                    {
                        pointDTT[2] = 3;
                        break;
                    }
                case 4:
                    {
                        pointDTT[2] = 4;
                        break;
                    }
                case 5:
                    {
                        pointDTT[2] = 6;
                        break;
                    }
                case 6:
                    {
                        pointDTT[2] = 10;
                        break;
                    }
            }
        }

        private void cbHaki_SelectedIndexChanged(object sender, EventArgs e)
        {
            getComboText[3] = cbHaki.Text;
            getLabels[3] = "HAKI";
            indexPoint4 = cbHaki.SelectedIndex;
            switch (cbHaki.SelectedIndex)
            {
                case 0:
                    {
                        pointDTT[3] = 0;
                        break;
                    }
                case 1:
                    {
                        pointDTT[3] = 1;
                        break;
                    }
                case 2:
                    {
                        pointDTT[3] = 3;
                        break;
                    }
            }
        }

        private void cbBukuReferensiMonograf_SelectedIndexChanged(object sender, EventArgs e)
        {
            getComboText[4] = cbBukuReferensiMonograf.Text;
            getLabels[4] = "BUKU REFERENSI / MONOGRAF";
            indexPoint5 = cbBukuReferensiMonograf.SelectedIndex;
            switch (cbBukuReferensiMonograf.SelectedIndex)
            {
                case 0:
                    {
                        pointDTT[4] = 0;
                        break;
                    }
                case 1:
                    {
                        pointDTT[4] = 3;
                        break;
                    }
                case 2:
                    {
                        pointDTT[4] = 6;
                        break;
                    }
            }
        }

        private void cbPelatihanKompetensi_SelectedIndexChanged(object sender, EventArgs e)
        {
            getComboText[5] = cbPelatihanKompetensi.Text;
            getLabels[5] = "PELATIHAN KOMPETENSI > 30 JAM";
            indexPoint6 = cbPelatihanKompetensi.SelectedIndex;
            switch (cbPelatihanKompetensi.SelectedIndex)
            {
                case 0:
                    {
                        pointDTT[5] = 0;
                        break;
                    }
                case 1:
                    {
                        pointDTT[5] = 2;
                        break;
                    }
                case 2:
                    {
                        pointDTT[5] = 4;
                        break;
                    }
            }
        }

        private void cbKelebihanJamTeori_SelectedIndexChanged(object sender, EventArgs e)
        {
            getComboText[6] = cbKelebihanJamTeori.Text;
            getLabels[6] = "KELEBIHAN JAM TEORI+PRAKTIK (>12 SKS)";
            indexPoint7 = cbKelebihanJamTeori.SelectedIndex;
            switch (cbKelebihanJamTeori.SelectedIndex)
            {
                case 0:
                    {
                        pointDTT[6] = 0;
                        break;
                    }
                case 1:
                    {
                        pointDTT[6] = 2;
                        break;
                    }
                case 2:
                    {
                        pointDTT[6] = 3;
                        break;
                    }
                case 3:
                    {
                        pointDTT[6] = 4;
                        break;
                    }
            }
        }

        private void cbKepanitiaanDiluarTugasUtama_SelectedIndexChanged(object sender, EventArgs e)
        {
            getComboText[7] = cbKepanitiaanDiluarTugasUtama.Text;
            getLabels[7] = "KEPANITIAAN DILUAR TUGAS UTAMA KHUSUS DOSEN MURNI(DS)";
            indexPoint8 = cbKepanitiaanDiluarTugasUtama.SelectedIndex;
            switch (cbKepanitiaanDiluarTugasUtama.SelectedIndex)
            {
                case 0:
                    {
                        pointDTT[7] = 0;
                        break;
                    }
                case 1:
                    {
                        pointDTT[7] = 1;
                        break;
                    }
                case 2:
                    {
                        pointDTT[7] = 2;
                        break;
                    }
                case 3:
                    {
                        pointDTT[7] = 3;
                        break;
                    }
            }
        }

        private void disableShortCuts()
        {
            foreach (Control kontrol in panel1.Controls)
            {

            }
        }
        #endregion
    }
}

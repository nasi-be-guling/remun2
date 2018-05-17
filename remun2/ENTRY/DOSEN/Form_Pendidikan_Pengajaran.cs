using System;
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
using System.Threading;
using System.Globalization;
using System.IO;

namespace remun2.ENTRY.DOSEN
{
    public partial class Form_Pendidikan_Pengajaran : Form
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
        #region CLASS GENERATOR
        /*
         * CLASS GENERATOR
            select 't_identitas' into @table; #table name
            select 'remun' into @schema; #database name
            select concat('public class ',@table,'{') union
            select concat('public ',tps.dest,' ',column_name,'{get;set;}') from  information_schema.columns c
            join( #datatypes mapping
            select 'char' as orign ,'string' as dest union all
            select 'varchar' ,'string' union all
            select 'longtext' ,'string' union all
            select 'datetime' ,'DateTime?' union all
            select 'text' ,'string' union all
            select 'bit' ,'int?' union all
            select 'bigint' ,'int?' union all
            select 'int' ,'int?' union all
            select 'double' ,'double?' union all
            select 'decimal' ,'double?' union all
            select 'date' ,'DateTime?' union all
            select 'tinyint' ,'bool?'
            ) tps on c.data_type like tps.orign
            where table_schema=@schema and table_name=@table union
            select '}';
         * */
        /* CLASS EXAMPLE
       private class Pegawai
       {
           private string id;
           private string nama;
           private string nip;

           public Pegawai(string id, string nama, string nip)
           {
               this.id = id;
               this.nama = nama;
               this.nip = nip;
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
           public string Nip
           {
               get { return nip; }
               set { nip = value; }
           }           
       }
       */
        #endregion
        #region CLASS
        private class Identitas
        {
            private string id;              //1
            private string noSertifikat;    //2
            private string nip;             //3    
            private string nidn;            //4
            private string nama;            //5
            private string jurusan;         //6
            private string prodi;           //7
            private string jabFung;         //8
            private string tglLahir;        //9 
            private string tempatLhr;       //10
            private string s1;              //11
            private string s2;              //12
            private string s3;              //13
            private string jenis;           //14
            private string bidangIlmu;      //15
            private string noHP;            //16
            private string atasanLangsung;  //17
            private string email;           //18
            private string statusPK;        //19
            private string statusDP;        //20

            public Identitas(string id, string noSertifikat, string nip, string nidn, string nama, string jurusan, string prodi, string jabFung, string tglLahir,
                string tempatLhr, string s1, string s2, string s3, string jenis, string bidangIlmu, string noHP, string atasanLangsung, string email,
                string statusPK, string statusDP)
            {
                this.id = id;
                this.noSertifikat = noSertifikat;
                this.nip = nip;
                this.nidn = nidn;
                this.nama = nama;
                this.jurusan = jurusan;
                this.prodi = prodi;
                this.jabFung = jabFung;
                this.tglLahir = tglLahir;
                this.tempatLhr = tempatLhr;
                this.s1 = s1;
                this.s2 = s2;
                this.s3 = s3;
                this.jenis = jenis;
                this.bidangIlmu = bidangIlmu;
                this.noHP = noHP;
                this.atasanLangsung = atasanLangsung;
                this.email = email;
                this.statusPK = statusPK;
                this.statusDP = statusDP;
            }

            public string Id
            {
                get { return id; }
                set { id = value; }
            }
            public string Nip
            {
                get { return nip; }
                set { nip = value; }
            }
            public string NoSertifikat
            {
                get { return noSertifikat; }
                set { noSertifikat = value; }
            }
            public string Nidn
            {
                get { return nidn; }
                set { nidn = value; }
            }
            public string Nama
            {
                get { return nama; }
                set { nama = value; }
            }
            public string Jurusan
            {
                get { return jurusan; }
                set { jurusan = value; }
            }
            public string Prodi
            {
                get { return prodi; }
                set { prodi = value; }
            }
            public string JabFung
            {
                get { return jabFung; }
                set { jabFung = value; }
            }
            public string TglLahir
            {
                get { return tglLahir; }
                set { tglLahir = value; }
            }
            public string TempatLhr
            {
                get { return tempatLhr; }
                set { tempatLhr = value; }
            }
            public string S1
            {
                get { return s1; }
                set { s1 = value; }
            }
            public string S2
            {
                get { return s2; }
                set { s2 = value; }
            }
            public string S3
            {
                get { return s3; }
                set { s3 = value; }
            }
            public string Jenis
            {
                get { return jenis; }
                set { jenis = value; }
            }
            public string BidangIlmu
            {
                get { return bidangIlmu; }
                set { bidangIlmu = value; }
            }
            public string NoHP
            {
                get { return noHP; }
                set { noHP = value; }
            }
            public string AtasanLangsung
            {
                get { return atasanLangsung; }
                set { atasanLangsung = value; }
            }
            public string Email
            {
                get { return email; }
                set { email = value; }
            }
            public string StatusPK
            {
                get { return statusPK; }
                set { statusPK = value; }
            }
            public string StatusDP
            {
                get { return statusDP; }
                set { statusDP = value; }
            }
        }
        #endregion

        List<Identitas> _Identitas = new List<Identitas>();

        public Form_Pendidikan_Pengajaran()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string errMsg = "";
            _connection = _connect.Connect(_configurationManager, ref errMsg, "GhY873LhT");
            if (errMsg != "")
            {
                MessageBox.Show(errMsg);
                return;
            }

            _sqlQuery = "select berkas from t_dokumentasi where id = @id";
            MySqlCommand cmd = new MySqlCommand(_sqlQuery, _connection);

            cmd.Parameters.AddWithValue("@id", "1");
            MySqlDataReader reader = cmd.ExecuteReader();

            if (errMsg != "")
            {
                MessageBox.Show(errMsg);
                return;
            }
            try
            {
                if (reader.HasRows)
                {
                    reader.Read();
                    var blob = new byte[(reader.GetBytes(0, 0, null, 0, int.MaxValue))];
                    reader.GetBytes(0, 0, blob, 0, blob.Length);

                    SaveFileDialog saveDialog1 = new SaveFileDialog();
                    saveDialog1.Filter = "Microsoft document file|*.docx";
                    saveDialog1.RestoreDirectory = true;
                    saveDialog1.FileName = "PEDOMAN PENETAPAN INDIKATOR KINERJA INDIVIDU DOSEN";
                    if (saveDialog1.ShowDialog() == DialogResult.OK)
                    {
                        using (var fs = new FileStream(saveDialog1.FileName, FileMode.Create, FileAccess.Write))
                            fs.Write(blob, 0, blob.Length);
                    }
                    reader.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Terjadi kesalahan dengan kode:" + ex.Message);
            }
            _connection.Close();
        }

        private void txtJamTarget_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == ','
                && (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }
        }

        private void txtJamCapaian_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == ','
                && (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            if (!_tools.CekTeksBoxKosong(groupBox2.Controls) || !_tools.CekTeksBoxKosong(groupBox3.Controls))
            {
                MessageBox.Show("Tidak boleh Kosong, Nol, atau Negatif", "PERHATIAN");
                return;
            }

            if (_tools.ControlNameIteration(groupBox2.Controls, "txtJamTarget") || _tools.ControlNameIteration(groupBox3.Controls, "txtJamCapaian"))
            {
                MessageBox.Show("Tidak boleh Kosong, Nol, atau Negatif", "PERHATIAN");
                return;
            }

            double jamTarget = Convert.ToDouble(txtJamTarget.Text);
            double jamCapaian = Convert.ToDouble(txtJamCapaian.Text);

            string rekomendasi = string.Empty;

            if (jamCapaian < jamTarget)
                rekomendasi = "TIDAK TERCAPAI";
            else if (jamCapaian >= jamTarget)
                rekomendasi = "TERCAPAI";

            int noUrut = 1;
            if (lvTampil.Items.Count > 0)
                noUrut = lvTampil.Items.Count + 1;
            ListViewItem items = new ListViewItem(noUrut++.ToString());
            items.SubItems.Add(txtJenisKegiatan.Text);
            items.SubItems.Add(txtBuktiPenugasan.Text);
            items.SubItems.Add(txtJamTarget.Text);
            items.SubItems.Add(txtMasaPenugasan.Text);
            items.SubItems.Add(txtBuktiDokumen.Text);
            items.SubItems.Add(txtJamCapaian.Text);
            items.SubItems.Add(rekomendasi);
            lvTampil.Items.Add(items);
            //lvTampil.Columns[7].Width = 0;
            //lvTampil.Columns[8].Width = 0;
            //lvTampil.Columns[9].Width = 0;
            Bersih2();
            txtJenisKegiatan.Focus();
        }

        public int ID_USER;
        private void bSave_Click(object sender, EventArgs e)
        {
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
            _sqlQuery = "insert into t_unsur (tipeUnsur, jenisKegiatan, buktiPenugasan, jamTarget, masaPenugasan, buktiDokumen, jamCapaian, rekomendasi, " +
                "bulan, tahun, tanggal, statusDP, idUser) values (@tipeUnsur, @jenisKegiatan, @buktiPenugasan, @jamTarget, @masaPenugasan, " +
                "@buktiDokumen, @jamCapaian, @rekomendasi, @bulan, @tahun, @tanggal, @statusDP, @idUser);";
            MySqlCommand cmd = new MySqlCommand(_sqlQuery, _connection, _transaction);


            cmd.Parameters.Add("@tipeUnsur", MySqlDbType.Int16, 11);
            cmd.Parameters.Add("@jenisKegiatan", MySqlDbType.VarChar, 500);
            cmd.Parameters.Add("@buktiPenugasan", MySqlDbType.VarChar, 255);
            cmd.Parameters.Add("@jamTarget", MySqlDbType.Double);
            cmd.Parameters.Add("@masaPenugasan", MySqlDbType.VarChar, 255);
            cmd.Parameters.Add("@buktiDokumen", MySqlDbType.VarChar, 255);
            cmd.Parameters.Add("@jamCapaian", MySqlDbType.Double);
            cmd.Parameters.Add("@rekomendasi", MySqlDbType.VarChar, 60);
            cmd.Parameters.Add("@bulan", MySqlDbType.Int16, 11);
            cmd.Parameters.Add("@tahun", MySqlDbType.Int16, 11);
            cmd.Parameters.Add("@tanggal", MySqlDbType.DateTime);
            cmd.Parameters.Add("@statusDP", MySqlDbType.Bit, 1);
            cmd.Parameters.Add("@idUser", MySqlDbType.Int16, 11);

            int rowsAffected = 0;

            try
            {
                foreach (ListViewItem items in lvTampil.Items)
                {
                    //MessageBox.Show(items.SubItems[1].Text + "|" + items.SubItems[2].Text + "|" + items.SubItems[3].Text + "|" + items.SubItems[4].Text + 
                    //    "|" + items.SubItems[5].Text + "|" + items.SubItems[6].Text + "|" + items.SubItems[7].Text);
                    cmd.Parameters["@tipeUnsur"].Value = TIPE_UNSUR;
                    cmd.Parameters["@jenisKegiatan"].Value = items.SubItems[1].Text;
                    cmd.Parameters["@buktiPenugasan"].Value = items.SubItems[2].Text;
                    cmd.Parameters["@jamTarget"].Value = items.SubItems[3].Text;
                    cmd.Parameters["@masaPenugasan"].Value = items.SubItems[4].Text;
                    cmd.Parameters["@buktiDokumen"].Value = items.SubItems[5].Text;
                    cmd.Parameters["@jamCapaian"].Value = items.SubItems[6].Text;
                    cmd.Parameters["@rekomendasi"].Value = items.SubItems[7].Text;
                    cmd.Parameters["@bulan"].Value = DateTime.Now.Month.ToString();
                    cmd.Parameters["@tahun"].Value = DateTime.Now.Year.ToString();
                    cmd.Parameters["@tanggal"].Value = DateTime.Now;
                    cmd.Parameters["@statusDP"].Value = "1";
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
            lvTampil.Items.Clear();
            _connection.Close();
        }

        public void LoadLVUnsur(int jenisUnsur)
        {
            lvTampil.Items.Clear();
            string errMsg = "";
            _connection = _connect.Connect(_configurationManager, ref errMsg, "GhY873LhT");
            if (errMsg != "")
            {
                MessageBox.Show(errMsg);
                return;
            }
            _sqlQuery = "select * from t_unsur where idUser = '" + ID_USER + "' and bulan = '" + DateTime.Now.Month + "' and tahun = '" + DateTime.Now.Year +
                "' and tipeUnsur = '" + jenisUnsur + "';";
            MySqlDataReader reader = _connect.Reading(_sqlQuery, _connection, ref errMsg);
            if (errMsg != "")
            {
                MessageBox.Show(errMsg);
                return;
            }
            try
            {
                if (reader.HasRows)
                {
                    int noUrut = 1;
                    bSave.Enabled = false;
                    while (reader.Read())
                    {
                        ListViewItem items = new ListViewItem(noUrut++.ToString());
                        items.SubItems.Add(reader.GetString(2));
                        items.SubItems.Add(reader.GetString(3));
                        items.SubItems.Add(reader.GetString(4));
                        items.SubItems.Add(reader.GetString(5));
                        items.SubItems.Add(reader.GetString(6));
                        items.SubItems.Add(reader.GetString(7));
                        items.SubItems.Add(reader.GetString(8));
                        lvTampil.Items.Add(items);
                    }
                    reader.Close();
                }
                else
                {
                    _connection.Close();
                    bSave.Enabled = true;
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            _connection.Close();
        }

        private void Bersih2()
        {
            foreach (Control tb in groupBox2.Controls)
            {
                if (tb is TextBox)
                {
                    tb.Text = "";
                }
                if (tb is ComboBox)
                {
                    tb.Text = "";
                }
            }
            foreach (Control tb in groupBox3.Controls)
            {
                if (tb is TextBox)
                {
                    tb.Text = "";
                }
                if (tb is ComboBox)
                {
                    tb.Text = "";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string errMsg = "";
            _connection = _connect.Connect(_configurationManager, ref errMsg, "GhY873LhT");
            if (errMsg != "")
            {
                MessageBox.Show(errMsg);
                return;
            }

            _sqlQuery = "select * from t_unsur";
            MySqlCommand cmd = new MySqlCommand(_sqlQuery, _connection);

            cmd.Parameters.AddWithValue("@id", "1");
            MySqlDataReader reader = cmd.ExecuteReader();

            if (errMsg != "")
            {
                MessageBox.Show(errMsg);
                return;
            }
            try
            {
                int nomerUrut = 1;
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ListViewItem items = new ListViewItem(nomerUrut++.ToString());
                        items.SubItems.Add(reader.GetString(2));
                        items.SubItems.Add(reader.GetString(3));
                        items.SubItems.Add(reader.GetDouble(4).ToString());
                        items.SubItems.Add(reader.GetString(5));
                        items.SubItems.Add(reader.GetString(6));
                        items.SubItems.Add(reader.GetDouble(7).ToString());
                        items.SubItems.Add(reader.GetString(8));
                        lvTampil.Items.Add(items);
                    }
                    reader.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Terjadi kesalahan dengan kode:" + ex.Message);
            }
            _connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // ============================= file stream ================================
            string ImageFileNames;
            byte[] ImageData;
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "Image Files | *.docx";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    ImageFileNames = openFileDialog1.FileName;
                }
                else
                    return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan membuka berkas dengan kode:" + ex.Message);
                return;
            }

            FileStream fs;
            BinaryReader br;

            try
            {
                string FileName = ImageFileNames;

                fs = new FileStream(FileName, FileMode.Open, FileAccess.Read);
                br = new BinaryReader(fs);
                if (fs.Length > 15000000)
                {
                    MessageBox.Show("File upload tidak boleh melebihi 15 MB", "ERROR");
                    return;
                }

                ImageData = br.ReadBytes((int)fs.Length);

                br.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan file stream dengan kode:" + ex.Message);
                return;
            }

            // ========================== end of file stream ============================
            string errMsg = "";
            _connection = _connect.Connect(_configurationManager, ref errMsg, "GhY873LhT");
            if (errMsg != "")
            {
                MessageBox.Show(errMsg);
                return;
            }
            MySqlTransaction _transaction = _connection.BeginTransaction();
            _sqlQuery = "insert into t_dokumentasi (berkas) values (@berkas)";
            MySqlCommand cmd = new MySqlCommand(_sqlQuery, _connection, _transaction);

            cmd.Parameters.Add("@berkas", MySqlDbType.MediumBlob);

            cmd.Parameters["@berkas"].Value = ImageData;

            int rowsAffected = 0;

            try
            {
                rowsAffected = cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Terjadi kesalahan dengan kode:" + ex.Message);
                return;
            }

            if (errMsg != "")
            {
                _transaction.Rollback();
                MessageBox.Show(errMsg);
                return;
            }

            if (rowsAffected > 0)
            {
                MessageBox.Show("Penyimpanan Berhasil");
            }

            _transaction.Commit();
            _connection.Close();
        }

        int TIPE_UNSUR;

        public void FormSettings(string FormCaption, int TipeUnsur)
        {
            Text = FormCaption;
            label9.Text = FormCaption;
            TIPE_UNSUR = TipeUnsur;
        }
    }
}

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
using _connectMySQL;
using _encryption;

namespace remun2.SETTING
{
    public partial class Form_Identitas_Pendidik : Form
    {
        #region KOMPONEN WAJIB
        private readonly CConnection _connect = new CConnection();
        private MySqlConnection _connection;
        private string _sqlQuery;
        private readonly string _configurationManager = Properties.Settings.Default.Setting;

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

        public Form_Identitas_Pendidik()
        {
            InitializeComponent();
        }

        private bool CekTeksBoxKosong()
        {
            foreach (Control tb in Controls)
            {
                if (tb is TextBox)
                {
                    if (string.IsNullOrEmpty(tb.Text) || string.IsNullOrWhiteSpace(tb.Text))
                        return false;
                }
                if (tb is ComboBox)
                {
                    if (string.IsNullOrEmpty(tb.Text) || string.IsNullOrWhiteSpace(tb.Text))
                        return false;
                }
            }
            return true;
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            if (!CekTeksBoxKosong())
            {
                MessageBox.Show("Harap isi semua data", "PERHATIAN");
                return;
            }

            foreach (Control txtPassword in Controls)
            {
                if (txtPassword.Name == "txtPasswd1" || txtPassword.Name == "txtPasswd2")
                {
                    if (txtPassword.Text.Length < 6)
                    {
                        MessageBox.Show("Password minimal 6 (Enam) karakter", "Error");
                        txtPasswd1.Clear();
                        txtPasswd2.Clear();
                        txtPasswd1.Focus();
                        return;
                    }
                }
            }

            if (txtPasswd2.Text != txtPasswd1.Text)
            {
                MessageBox.Show("Password dan Ulangi tidak sama, tolong samakan", "ERROR");
                txtPasswd1.Clear();
                txtPasswd2.Clear();
                txtPasswd1.Focus();
                return;
            }

            string errMsg = "";
            _connection = _connect.Connect(_configurationManager, ref errMsg, "GhY873LhT");
            if (errMsg != "")
            {
                MessageBox.Show(errMsg);
                return;
            }
            MySqlTransaction _transaction = _connection.BeginTransaction();
            _sqlQuery = "insert into t_identitas (noSertifikat, nip, nidn, nama, jurusan, prodi, jabFung, tglLahir, tempatLhr, s1, s2, s3, jenis, bidangIlmu, " +
                " noHP, atasanLangsung, email, statusPK, statusDP, passwd) " +
                " values (@noSertifikat, @nip, @nidn, @nama, @jurusan, @prodi, @jabFung, @tglLahir, @tempatLhr, @s1, @s2, @s3, @jenis, @bidangIlmu, " +
                " @noHP, @atasanLangsung, @email, @statusPK, @statusDP, @passwd);";
            MySqlCommand cmd = new MySqlCommand(_sqlQuery, _connection, _transaction);

            cmd.Parameters.Add("@noSertifikat", MySqlDbType.VarChar, 50);
            cmd.Parameters.Add("@nip", MySqlDbType.VarChar, 50);
            cmd.Parameters.Add("@nidn", MySqlDbType.VarChar, 50);
            cmd.Parameters.Add("@nama", MySqlDbType.VarChar, 255);
            cmd.Parameters.Add("@jurusan", MySqlDbType.VarChar, 255);
            cmd.Parameters.Add("@prodi", MySqlDbType.VarChar, 255);
            cmd.Parameters.Add("@jabFung", MySqlDbType.VarChar, 255);
            cmd.Parameters.Add("@tglLahir", MySqlDbType.Date);
            cmd.Parameters.Add("@tempatLhr", MySqlDbType.VarChar, 255);
            cmd.Parameters.Add("@s1", MySqlDbType.VarChar, 255);
            cmd.Parameters.Add("@s2", MySqlDbType.VarChar, 255);
            cmd.Parameters.Add("@s3", MySqlDbType.VarChar, 255);
            cmd.Parameters.Add("@jenis", MySqlDbType.VarChar, 255);
            cmd.Parameters.Add("@bidangIlmu", MySqlDbType.VarChar, 255);
            cmd.Parameters.Add("@noHP", MySqlDbType.VarChar, 255);
            cmd.Parameters.Add("@atasanLangsung", MySqlDbType.VarChar, 255);
            cmd.Parameters.Add("@email", MySqlDbType.VarChar, 255);
            cmd.Parameters.Add("@statusPK", MySqlDbType.Bit, 1);
            cmd.Parameters.Add("@statusDP", MySqlDbType.Bit, 1);
            cmd.Parameters.Add("@passwd", MySqlDbType.VarChar, 50);

            cmd.Parameters["@noSertifikat"].Value = txtNoSertifikat.Text;
            cmd.Parameters["@nip"].Value = txtNIP.Text;
            cmd.Parameters["@nidn"].Value = txtNIDN.Text;
            cmd.Parameters["@nama"].Value = txtNama.Text;
            cmd.Parameters["@jurusan"].Value = cbJurusan.Text;
            cmd.Parameters["@prodi"].Value = cbProgStudi.Text;
            cmd.Parameters["@jabFung"].Value = txtJabFungsional.Text;
            cmd.Parameters["@tglLahir"].Value = String.Format("{0:yyyy-MM-dd}", dtpTglLahir.Value);
            cmd.Parameters["@tempatLhr"].Value = txtTempatLhr.Text;
            cmd.Parameters["@s1"].Value = txtS1.Text;
            cmd.Parameters["@s2"].Value = txtS2.Text;
            cmd.Parameters["@s3"].Value = txtS3.Text;
            cmd.Parameters["@jenis"].Value = cbJenis.Text.Split(' ')[0];
            cmd.Parameters["@bidangIlmu"].Value = txtBidangIlmu.Text;
            cmd.Parameters["@noHP"].Value = txtNoHP.Text;
            cmd.Parameters["@atasanLangsung"].Value = txtAtasanLangsung.Text;
            cmd.Parameters["@email"].Value = txtEmail.Text;
            cmd.Parameters["@statusPK"].Value = "0";
            cmd.Parameters["@statusDP"].Value = "1";
            cmd.Parameters["@passwd"].Value = CStringCipher.Encrypt(txtPasswd2.Text, "hjsu939LpTie");

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
                _transaction.Commit();
                MessageBox.Show("Penyimpanan Berhasil");
            }
            Bersih2();
            _connection.Close();
        }

        private void Bersih2()
        {
            foreach (Control tb in Controls)
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

        private void cbJurusan_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbProgStudi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbJurusan_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbProgStudi.Text = string.Empty;
            cbProgStudi.Items.Clear();
            if (cbJurusan.SelectedIndex == 0)
            {
                cbProgStudi.Items.AddRange(new string[] {"D4 KEPERAWATAN SOETOMO", "D3 KEPERAWATAN SOETOMO", "D3 KEPERAWATAN SUTOPO",
                    "D3 KEPERAWATAN SIDOARJO", "D3 KEPERAWATAN TUBAN"});
            }
            else if (cbJurusan.SelectedIndex == 1)
            {
                cbProgStudi.Items.AddRange(new string[] {"D4 KEBIDANAN SUTOMO", "D3 KEBIDANAN SUTOMO", "D3 KEBIDANAN BANGKALAN",
                    "D3 KEBIDANAN MAGETAN"});
            }
            else if (cbJurusan.SelectedIndex == 2)
            {
                cbProgStudi.Items.AddRange(new string[] {"D4 KESEHATAN LINGKUNGAN SURABAYA", "D3 KESEHATAN LINGKUNGAN SURABAYA",
                    "D3 KESEHATAN LINGKUNGAN MAGETAN"});
            }
            else if (cbJurusan.SelectedIndex == 3)
            {
                cbProgStudi.Items.AddRange(new string[] {"D4 ANALIS KESEHATAN", "D3 ANALIS KESEHATAN"});
            }
            else if (cbJurusan.SelectedIndex == 4)
            {
                cbProgStudi.Items.AddRange(new string[] {"D4 TEKNIK ELEKTROMEDIK", "D3 TEKNIK ELEKTROMEDIK"});
            }
            else if (cbJurusan.SelectedIndex == 5)
            {
                cbProgStudi.Items.AddRange(new string[] {"D4 KEPERAWATAN GIGI", "D3 KEPERAWATAN GIGI"});
            }
            else if (cbJurusan.SelectedIndex == 6)
            {
                cbProgStudi.Items.AddRange(new string[] {"D3 GIZI"});
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(String.Format("{0:yyyy-MM-dd}", dtpTglLahir.Value));
            MessageBox.Show(cbJenis.Text.Split(' ')[0]);
        }

        private void cbJenis_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}

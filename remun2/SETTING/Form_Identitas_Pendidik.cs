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
            private string nip;             //2    
            private string nidn;            //3
            private string nama;            //4
            private string jurusan;         //5
            private string prodi;           //6
            private string jabFung;         //7
            private string tglLahir;        //8 
            private string tempatLhr;       //9
            private string s1;              //10
            private string s2;              //11
            private string s3;              //12
            private string jenis;           //13
            private string bidangIlmu;      //14
            private string noHP;            //15
            private string atasanLangsung;  //16
            private string email;           //17
            private string statusPK;        //18
            private string statusDP;        //19

            public Identitas(string id, string nip, string nidn, string nama, string jurusan, string prodi, string jabFung, string tglLahir,
                string tempatLhr, string s1, string s2, string s3, string jenis, string bidangIlmu, string noHP, string atasanLangsung, string email,
                string statusPK, string statusDP)
            {
                this.id = id;              
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
                
        private void bSave_Click(object sender, EventArgs e)
        {
            string errMsg = "";
            _connection = _connect.Connect(_configurationManager, ref errMsg, "GhY873LhT");
            if (errMsg != "")
            {
                MessageBox.Show(errMsg);
                return;
            }
            MySqlTransaction _transaction = _connection.BeginTransaction();
            _sqlQuery = "insert into t_identitas (jenis, nama, rektor, fakultas, dekan, jurusan, kajur, logo) " +
                " values (@jenis, @nama, @rektor, @fakultas, @dekan, @jurusan, @kajur, @logo)";
            MySqlCommand cmd = new MySqlCommand(_sqlQuery, _connection, _transaction);

            cmd.Parameters.Add("@jenis", MySqlDbType.VarChar, 60);
            cmd.Parameters.Add("@nama", MySqlDbType.VarChar, 255);
            cmd.Parameters.Add("@rektor", MySqlDbType.VarChar, 255);
            cmd.Parameters.Add("@fakultas", MySqlDbType.VarChar, 255);
            cmd.Parameters.Add("@dekan", MySqlDbType.VarChar, 255);
            cmd.Parameters.Add("@jurusan", MySqlDbType.VarChar, 255);
            cmd.Parameters.Add("@kajur", MySqlDbType.VarChar, 255);
            cmd.Parameters.Add("@logo", MySqlDbType.MediumBlob);

            //cmd.Parameters["@jenis"].Value = cbJenisPerguruanTinggi.Text;
            //cmd.Parameters["@nama"].Value = txtNamaPerguruanTinggi.Text;
            //cmd.Parameters["@rektor"].Value = txtNamaRektor.Text;
            //cmd.Parameters["@fakultas"].Value = txtNamaFakultas.Text;
            //cmd.Parameters["@dekan"].Value = txtNamaDekan.Text;
            //cmd.Parameters["@jurusan"].Value = txtNamaJurusan.Text;
            //cmd.Parameters["@kajur"].Value = txtNamaKaJur.Text;
            //cmd.Parameters["@logo"].Value = ImageData;

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
        }
    }
}

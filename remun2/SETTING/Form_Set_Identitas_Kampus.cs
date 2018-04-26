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
using System.IO;

namespace remun2.SETTING
{
    public partial class Form_Set_Identitas_Kampus : Form
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


        public Form_Set_Identitas_Kampus()
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
            _sqlQuery = "insert into t_kampus (jenis, nama, rektor, fakultas, dekan, jurusan, kajur, logo) " + 
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

            cmd.Parameters["@jenis"].Value = cbJenisPerguruanTinggi.Text;
            cmd.Parameters["@nama"].Value = txtNamaPerguruanTinggi.Text;
            cmd.Parameters["@rektor"].Value = txtNamaRektor.Text;
            cmd.Parameters["@fakultas"].Value = txtNamaFakultas.Text;
            cmd.Parameters["@dekan"].Value = txtNamaDekan.Text;
            cmd.Parameters["@jurusan"].Value = txtNamaJurusan.Text;
            cmd.Parameters["@kajur"].Value = txtNamaKaJur.Text;
            cmd.Parameters["@logo"].Value = ImageData;

            int rowsAffected = cmd.ExecuteNonQuery();
                     
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

        private byte[] ImageData;
        private void bLoadLogo_Click(object sender, EventArgs e)
        {
            string ImageFileNames;
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "Image Files | *.jpg";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    txtLogo.Text = openFileDialog1.FileName;
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
                ImageData = br.ReadBytes((int)fs.Length);

                br.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan file stream dengan kode:" + ex.Message);
                return;
            }
        }
    }
}

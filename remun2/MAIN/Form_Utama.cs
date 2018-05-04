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


namespace remun2.MAIN
{
    public partial class Form_Utama : Form
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

        #region CLASS
        
        //List<Pegawai> _Pegawai = new List<Pegawai>();
        //List<Menu_Pegawai> _Menu_pegawai = new List<Menu_Pegawai>();

        #endregion

        public Form_Utama()             LANJUTKAN DENGAN MENYUSUN MENU UTAMA:
        {                               1. Pengecekan pada saat login:
            InitializeComponent();         1.1 User login, pasword benar -> lanjut, password salah kembali lagi, cek NIP kalo ga ada buat user baru
        }

        private void Form_Utama_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
            toolStripStatusLabel2.Text = "";
            Form_Login _fLogin = new Form_Login();
            _fLogin.ShowDialog(this);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        public string ID_USER;

        public void Load_Pegawai()
        {
            toolStripStatusLabel1.Text = "";
            toolStripStatusLabel2.Text = "";
            string errMsg = "";
            _connection = _connect.Connect(_configurationManager, ref errMsg, "GhY873LhT");
            if (errMsg != "")
            {
                MessageBox.Show(errMsg);
                return;
            }
            _sqlQuery = "select * from t_user where id = '" + CStringCipher.Decrypt(ID_USER, "hjYir83K") + "'";
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
                    while (reader.Read())
                    {
                        _Pegawai.Add(new Pegawai(Convert.ToInt16(reader[0]), Convert.ToString(reader[1]), Convert.ToString(reader[2]),
                            Convert.ToString(reader[3]), Convert.ToString(reader[4]), Convert.ToString(reader[5]), Convert.ToString(reader[6]),
                            Convert.ToString(reader[7]), Convert.ToString(reader[8]), Convert.ToString(reader[9]), Convert.ToString(reader[10])));
                    }
                    reader.Close();
                    var query = (from i in _Pegawai select i);
                    foreach (var item in query)
                    {
                        toolStripStatusLabel1.Text = "Nama: " + item.Nama;
                        toolStripStatusLabel2.Text = " | NIP: " + item.Nip;
                        statusPegawai = Convert.ToInt16(item.IsDosen);
                    }
                }
                else
                {
                    MessageBox.Show("User atau password salah", "ERROR");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            Load_Menu();
        }
    }
}

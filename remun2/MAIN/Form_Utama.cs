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

        public Form_Utama()
        {
            InitializeComponent();
        }

        private void Form_Utama_Load(object sender, EventArgs e)
        {

        }
    }
}

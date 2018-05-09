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

        #region CLASS

        private class Menu_Pegawai
        {
            private int id;
            private string nama;
            private string text;
            private string namaForm;
            private string isDosen;
            private string parentMenu;

            public Menu_Pegawai(int id, string nama, string text, string namaForm, string isDosen, string parentMenu)
            {
                this.id = id;
                this.nama = nama;
                this.text = text;
                this.namaForm = namaForm;
                this.isDosen = isDosen;
                this.parentMenu = parentMenu;
            }

            public int Id
            {
                get { return id; }
                set { id = value; }
            }
            public string Nama
            {
                get { return nama; }
                set { nama = value; }
            }
            public string Text
            {
                get { return text; }
                set { text = value; }
            }
            public string NamaForm
            {
                get { return namaForm; }
                set { namaForm = value; }
            }
            public string IsDosen
            {
                get { return isDosen; }
                set { isDosen = value; }
            }
            public string ParentMenu
            {
                get { return parentMenu; }
                set { parentMenu = value; }
            }
        }

        List<Menu_Pegawai> _Menu_pegawai = new List<Menu_Pegawai>();
        #endregion

        public Form_Utama()             
        {                               
            InitializeComponent();         
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

        public int ID_USER;

        private int statusPegawai;
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
            _sqlQuery = "select * from t_identitas where id = '" + ID_USER + "'";
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
                    reader.Read();
                    FontFamily fontFamily = new FontFamily("Arial");
                    toolStripStatusLabel1.Font = new Font(fontFamily, 12, FontStyle.Bold);
                    toolStripStatusLabel1.Text = "  " + reader.GetString(4);
                    toolStripStatusLabel2.Text = " | Jabatan: " + reader.GetString(7).ToUpper() + " | Jurusan: " + reader.GetString(5).ToUpper() + " | Prodi: " + reader.GetString(6).ToUpper();
                    statusPegawai = reader.GetInt16(19);
                    reader.Close();
                }
                else
                {
                    MessageBox.Show("Ada sesuatu yg salah: User tidak ditemukan?", "ERROR");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            _connection.Close();
            Load_Menu();
        }

        private void Load_Menu()
        {
            string errMsg = "";
            _connection = _connect.Connect(_configurationManager, ref errMsg, "GhY873LhT");
            if (errMsg != "")
            {
                MessageBox.Show(errMsg);
                return;
            }
            if (statusPegawai == 0)
                _sqlQuery = "select * from t_menu where isDosen = 0";
            else
                _sqlQuery = "select * from t_menu where isDosen = 1";
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
                        _Menu_pegawai.Add(new Menu_Pegawai(Convert.ToInt16(reader[0]), Convert.ToString(reader[1]), Convert.ToString(reader[2]),
                            Convert.ToString(reader[3]), Convert.ToString(reader[4]), Convert.ToString(reader[5])));
                    }
                    reader.Close();
                    var query = (from i in _Menu_pegawai select i);
                    foreach (var item in query)
                    {
                        if (item.ParentMenu == "entry")
                        {
                            ToolStripMenuItem SSMenu = new ToolStripMenuItem(item.Text, null, new EventHandler(ChildClick), item.Nama);
                            entryToolStripMenuItem.DropDownItems.Add(SSMenu);
                        }
                        if (item.ParentMenu == "report")
                        {
                            ToolStripMenuItem SSMenu = new ToolStripMenuItem(item.Text, null, new EventHandler(ChildClick), item.Nama);
                            reportToolStripMenuItem.DropDownItems.Add(SSMenu);
                        }
                        if (item.ParentMenu == "setting")
                        {
                            ToolStripMenuItem SSMenu = new ToolStripMenuItem(item.Text, null, new EventHandler(ChildClick), item.Nama);
                            settingToolStripMenuItem.DropDownItems.Add(SSMenu);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Menu tidak ditemukan", "KOK ANEH??");
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

        private void ChildClick(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;
            if (menuItem.Name == "mPendidikanPengajaran")
            {
                show_custom_form(12); 
            }
            if (menuItem.Name == "mSettingIdentitas")
            {
                show_custom_form(11);
            }
            if (menuItem.Name == "mPendidikanPengajaran_init")
            {

            }
            if (menuItem.Name == "mSettingIdentitasND")
            {
                show_custom_form(21);
            }
            
            else
                return;
        }

        private void show_custom_form(int form_index)
        {
            switch (form_index) // index 1X untuk dosen; 2X untuk non dosen
            {
                case 11: // FORM SETTING IDENTITAS DOSEN
                    {
                        SETTING.Form_Identitas_Pendidik _fIdentitasDosen;
                        if ((_fIdentitasDosen = (SETTING.Form_Identitas_Pendidik)_tools.FormSudahDibuat(typeof(SETTING.Form_Identitas_Pendidik))) == null)
                        {
                            _fIdentitasDosen = new SETTING.Form_Identitas_Pendidik();
                            _fIdentitasDosen.MdiParent = this;
                            _fIdentitasDosen.StartPosition = FormStartPosition.CenterScreen;
                            _fIdentitasDosen.WindowState = FormWindowState.Normal;
                            _fIdentitasDosen.Show();
                        }
                        else
                        {
                            _fIdentitasDosen.StartPosition = FormStartPosition.CenterScreen;
                            _fIdentitasDosen.WindowState = FormWindowState.Normal;
                            _fIdentitasDosen.Select();
                        }
                        break;
                    }
                case 12: // FORM ENTRY PENDIDIKAN PENGAJARAN DOSEN
                    {
                        {
                            ENTRY.DOSEN.Form_Pendidikan_Pengajaran _fPendidikanPengajaran;
                            if ((_fPendidikanPengajaran = (ENTRY.DOSEN.Form_Pendidikan_Pengajaran)_tools.FormSudahDibuat(typeof(ENTRY.DOSEN.Form_Pendidikan_Pengajaran))) == null)
                            {
                                _fPendidikanPengajaran = new ENTRY.DOSEN.Form_Pendidikan_Pengajaran();
                                _fPendidikanPengajaran.ID_USER = ID_USER;
                                _fPendidikanPengajaran.MdiParent = this;
                                _fPendidikanPengajaran.WindowState = FormWindowState.Maximized;
                                _fPendidikanPengajaran.Show();
                            }
                            else
                            {
                                _fPendidikanPengajaran.WindowState = FormWindowState.Maximized;
                                _fPendidikanPengajaran.Select();
                            }
                            break;
                        }
                    }                    
                case 21: // FORM SETTING IDENTITAS NON DOSEN
                    {
                        SETTING.Form_Identitas_ND _fIdentitasNonDosen;
                        if ((_fIdentitasNonDosen = (SETTING.Form_Identitas_ND)_tools.FormSudahDibuat(typeof(SETTING.Form_Identitas_ND))) == null)
                        {
                            _fIdentitasNonDosen = new SETTING.Form_Identitas_ND();
                            _fIdentitasNonDosen.MdiParent = this;
                            _fIdentitasNonDosen.StartPosition = FormStartPosition.CenterScreen;
                            _fIdentitasNonDosen.WindowState = FormWindowState.Normal;
                            _fIdentitasNonDosen.Show();
                        }
                        else
                        {
                            _fIdentitasNonDosen.StartPosition = FormStartPosition.CenterScreen;
                            _fIdentitasNonDosen.WindowState = FormWindowState.Normal;
                            _fIdentitasNonDosen.Select();
                        }
                        break;
                    }
            }
        }

        private bool CekInitTahun(string SqlQueryCek, MySqlConnection _MYSQLCONNECTION)
        {
            string errMsg = string.Empty;
            if (errMsg != "")
            {
                MessageBox.Show(errMsg);
                return false;
            }
            MySqlDataReader reader = _connect.Reading(SqlQueryCek, _MYSQLCONNECTION, ref errMsg);
            if (errMsg != "")
            {
                MessageBox.Show(errMsg);
                return false;
            }
            try
            {
                if (reader.HasRows)
                    return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            return false;
        }
    }
}

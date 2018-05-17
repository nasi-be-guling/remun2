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

namespace remun2.MAIN
{
    public partial class Form_Login : Form
    {
        #region KOMPONEN WAJIB
        private readonly CConnection _connect = new CConnection();
        private MySqlConnection _connection;
        private string _sqlQuery;
        private readonly string _configurationManager = Properties.Settings.Default.Setting;
        private readonly CLASS.Class_TOOLS _tools = new CLASS.Class_TOOLS();
        #endregion

        MAIN.Form_Utama _fMainMenu;        

        public Form_Login()
        {
            InitializeComponent();
        }

        private bool Check_NIP(MySqlConnection MYSQLCONNECTION, string NIP)
        {
            string errMsg = "";
            _sqlQuery = "";
            _sqlQuery = "select id from t_identitas where nip = '" + NIP + "'";
            MySqlDataReader reader = _connect.Reading(_sqlQuery, MYSQLCONNECTION, ref errMsg);
            if (errMsg != "")
            {
                MessageBox.Show(errMsg);
                return false;
            }
            try
            {
                if (reader.HasRows)
                {
                    reader.Close();
                    return true;
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            return false;
        }

        private void show_custom_form(int form_index)
        {
            switch (form_index)
            {
                case 1:
                    {
                        SETTING.Form_Identitas_Pendidik _fIdentitasDosen;
                        if ((_fIdentitasDosen = (SETTING.Form_Identitas_Pendidik)_tools.FormSudahDibuat(typeof(SETTING.Form_Identitas_Pendidik))) == null)
                        {
                            _fIdentitasDosen = new SETTING.Form_Identitas_Pendidik();
                            _fIdentitasDosen.ShowDialog(Parent);
                        }
                        else
                        {
                            _fIdentitasDosen.Select();
                        }
                        break;
                    }
                case 2:
                    {
                        SETTING.Form_Identitas_ND _fIdentitasNonDosen;
                        if ((_fIdentitasNonDosen = (SETTING.Form_Identitas_ND)_tools.FormSudahDibuat(typeof(SETTING.Form_Identitas_ND))) == null)
                        {
                            _fIdentitasNonDosen = new SETTING.Form_Identitas_ND();
                            _fIdentitasNonDosen.ShowDialog(Parent);
                        }
                        else
                        {
                            _fIdentitasNonDosen.Select();
                        }
                        break;
                    }
            }
        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            int idUser;
            string password = "";
            string errMsg = "";
            _sqlQuery = "";
            _connection = _connect.Connect(_configurationManager, ref errMsg, "GhY873LhT");
            if (errMsg != "")
            {
                MessageBox.Show(errMsg);
                return;
            }

            _sqlQuery = "select id, passwd from t_identitas where nip = '" + txtNIP.Text + "'";
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
                    idUser = reader.GetInt16(0);
                    password = reader.GetString(1);
                    reader.Close();
                }
                else
                {
                    if (MessageBox.Show("NIP tidak ditemukan, harap melakukan registrasi", "KONFIRMASI", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (MessageBox.Show("Dosen?", "REGISTRASI", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            show_custom_form(1);
                            return;
                        }
                        else
                        {
                            show_custom_form(2);
                            return;
                        }
                    }
                    else
                        return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            if (CStringCipher.Decrypt(password, "hjsu939LpTie") == txtPasswd.Text)
            {
                if ((_fMainMenu = (Form_Utama)_tools.FormSudahDibuat(typeof(Form_Utama))) == null)
                {
                    _fMainMenu = new Form_Utama();
                    _fMainMenu.ID_USER = idUser;
                    _fMainMenu.Show();
                }
                else
                {
                    _fMainMenu.ID_USER = idUser;
                    _fMainMenu.Load_Pegawai();
                    _fMainMenu.Select();
                }
                Close();
            }
            else
                MessageBox.Show("Password salah", "ERROR");

            _connection.Close();
        }

        private void txtNIP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

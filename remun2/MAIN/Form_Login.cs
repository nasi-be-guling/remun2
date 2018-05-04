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

        private void bLogin_Click(object sender, EventArgs e)
        {
            string idUser = "";
            string password = "";
            string errMsg = "";
            _sqlQuery = "";
            _connection = _connect.Connect(_configurationManager, ref errMsg, "GhY873LhT");
            if (errMsg != "")
            {
                MessageBox.Show(errMsg);
                return;
            }
            _sqlQuery = "select id, passwd from t_user where nip = '" + txtNIP.Text + "'";
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
                    idUser = reader[0].ToString();
                    password = reader[1].ToString();
                    reader.Close();
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

            if (CStringCipher.Decrypt(password, "hjsu939LpTie") == txtPasswd.Text)
            {
                if ((_fMainMenu = (MAIN.Form_Utama)_tools.FormSudahDibuat(typeof(MAIN.Form_Utama))) == null)
                {
                    _fMainMenu = new MAIN.Form_Utama();
                    _fMainMenu.ID_USER = CStringCipher.Encrypt(idUser, "hjYir83K");
                    _fMainMenu.Show();
                }
                else
                {
                    _fMainMenu.ID_USER = CStringCipher.Encrypt(idUser, "hjYir83K");
                    _fMainMenu.Load_Pegawai();
                    _fMainMenu.Select();
                }
                Close();
            }
            else
                MessageBox.Show("User atau password salah", "ERROR");

            _connection.Close();
        }
    }
}

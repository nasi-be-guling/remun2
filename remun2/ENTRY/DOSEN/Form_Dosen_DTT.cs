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
using Xceed.Words.NET;
using System.IO;

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

        private void button1_Click(object sender, EventArgs e)
        {
            //CreateDocument();
            //CreateDocX();
            //GetLogoImage("3");
            CreateInvoiceTemplate();
        }

        private MemoryStream GetLogoImage(string ID_IMAGE)
        {
            string errMsg = "";
            MemoryStream memoriohmemori = null;
            _connection = _connect.Connect(_configurationManager, ref errMsg, "GhY873LhT");
            if (errMsg != "")
            {
                MessageBox.Show(errMsg);
                return null;
            }

            _sqlQuery = "select berkas from t_dokumentasi where id = @id";
            MySqlCommand cmd = new MySqlCommand(_sqlQuery, _connection);

            cmd.Parameters.AddWithValue("@id", ID_IMAGE);
            MySqlDataReader reader = cmd.ExecuteReader();

            if (errMsg != "")
            {
                MessageBox.Show(errMsg);
                return null;
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

                    memoriohmemori = new MemoryStream(blob);

                    reader.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Terjadi kesalahan dengan kode:" + ex.Message);
            }
            _connection.Close();
            return memoriohmemori;
        }

        #region CREATE DOCX DOCUMENT USING OPEN Xceed DOCX :)
        private void CreateDocX()
        {
            string fileName = @"D:\DocXExample.docx";

            // Create a document in memory:
            var doc = DocX.Create(fileName);

            doc.MarginTop = 70;
            doc.MarginBottom = 70;
            doc.MarginLeft = 70;
            doc.MarginRight = 70;

            doc.PageLayout.Orientation = Xceed.Words.NET.Orientation.Landscape;

            Xceed.Words.NET.Image LogoKemenkes = doc.AddImage(GetLogoImage("7"));
            Xceed.Words.NET.Image LogoPoltekkes = doc.AddImage(GetLogoImage("8"));

            // Create a picture (A custom view of an Image).
            Picture pictureKemenkes = LogoKemenkes.CreatePicture();
            Picture picturePoltekkes = LogoPoltekkes.CreatePicture();

            pictureKemenkes.Height = 133;
            pictureKemenkes.Width = 127;

            picturePoltekkes.Height = 131;
            picturePoltekkes.Width = 135;

            // Insert a new Paragraph into the document.
            Paragraph title = doc.InsertParagraph().AppendPicture(pictureKemenkes).Append("LAPORAN KINERJA DOSEN").
                FontSize(20).Font("Arial").AppendPicture(picturePoltekkes);
            title.Alignment = Alignment.center;

            // Insert a new Paragraph into the document.
            Paragraph p1 = doc.InsertParagraph();

            // Append content to the Paragraph
            p1.AppendLine("Check out this picture ").AppendPicture(pictureKemenkes).Append(" its funky don't you think?");
            p1.AppendLine();

            p1.AppendPicture(picturePoltekkes);
            // Insert a paragrpah:

            doc.InsertParagraph("This is my first paragraph");

            // Save to the output directory:
            doc.Save();
        }
        #endregion

        /// <summary>
        /// The following is code snipet from c-sharpcorner.com, the author where fantastico! I though i will give up using Xceed docX wonderfull library, but this guy
        /// from c-sharpcorner.com give me hope. The following line below is the url address for the fantastico code
        /// https://www.c-sharpcorner.com/UploadFile/scottlysle/using-the-docx-dll-to-programmatically-create-word-documents/
        /// The code used an obsolete method or function, i already adjust them.
        /// </summary>
        private void CreateInvoiceTemplate()

        {
            // Create a new document with the canned
            // document title.  Note this is really just
            // a document and not an actual template

            DocX document = DocX.Create(@"D:\DocXExample1.docx");

            // Create a table for layout purposes
            // (This table will be invisible).
            // Document content will be placed into various cells
            // within this table

            Table layout_table = document.InsertTable(2, 2);
            layout_table.Design = TableDesign.TableNormal;
            layout_table.AutoFit = AutoFit.Window;

            #region Create document style



            // create formatting styles that will be used

            // to define the appearance of the document

            // once populated with actual data



            // Large Dark formatting - for titles

            Formatting large_dark_formatting = new Formatting();

            large_dark_formatting.Bold = true;

            large_dark_formatting.Size = 16;

            large_dark_formatting.FontColor = Color.Black;



            // Dark formatting

            Formatting dark_formatting = new Formatting();

            dark_formatting.Bold = true;

            dark_formatting.Size = 12;

            dark_formatting.FontColor = Color.Black;



            // Light formatting

            Formatting light_formatting = new Formatting();

            light_formatting.Italic = true;

            light_formatting.Size = 11;

            light_formatting.FontColor = Color.Black;



            #endregion

            #region Company Name

            CustomProperty company_name =
                new CustomProperty("company_name", "Company Name");

            // Put the document property into the table at the
            // correct location and apply the display style
            // Force the next text insert to be on a new line.



            #endregion





            #region Company Slogan



            // use the same approach used with the company name to

            // insert a new property under the company name; this

            // property will display the company slogan using a

            // smaller font and in italics



            // Create a custom property called company_slogan

            CustomProperty company_slogan =

                new CustomProperty("company_slogan",

                    "Company slogan goes here.");



            // Insert a field of type doc property

            // (This will display the custom property 'company_slogan')

            #endregion





            #region Company Logo

            // Get the upper right Paragraph in the layout_table.
            // Add a template logo image to this document.

            Xceed.Words.NET.Image logo = document.AddImage(GetLogoImage("7"));



            // Insert this template logo into the upper right Paragraph.
            Paragraph upper_left_paragraph =

                layout_table.Rows[0].Cells[0].InsertParagraph();

            Picture picture_logo = logo.CreatePicture();

            upper_left_paragraph.InsertPicture(picture_logo);

            upper_left_paragraph.Alignment = Alignment.left;

            #endregion



            #region Hired Company Address



            // Create a custom property called

            // company_address_line_one

            CustomProperty hired_company_username =

                new CustomProperty("hired_company_username",

                    "User Name:");



            // Create a custom property called

            // company_address_line_one

            CustomProperty hired_company_address_line_one =

                new CustomProperty("hired_company_address_line_one",

                    "Street Address,");



            // Get the lower left Paragraph in the layout_table.

            Paragraph lower_left_paragraph =

                layout_table.Rows[1].Cells[0].InsertParagraph();



            lower_left_paragraph.InsertText("TO:\n", false, dark_formatting);



            // Insert a field of type doc property

            // (This will display the custom property

            // 'hired_company_username')

            lower_left_paragraph.InsertDocProperty(

                hired_company_username, false, light_formatting);



            // Force the next text insert to be on a new line.

            lower_left_paragraph.InsertText("\n", false);



            // Insert a field of type doc property

            // (This will display the custom property

            // 'hired_company_address_line_one')

            lower_left_paragraph.InsertDocProperty(

                hired_company_address_line_one, false, light_formatting);



            // Force the next text insert to be on a new line.

            lower_left_paragraph.InsertText("\n", false);



            // Create a custom property called

            // company_address_line_two

            CustomProperty hired_company_address_line_two =

                new CustomProperty("hired_company_address_line_two",

                    "City,");



            // Insert a field of type doc property

            // (This will display the custom property

            // 'hired_company_address_line_two')

            lower_left_paragraph.InsertDocProperty(

                hired_company_address_line_two, false, light_formatting);



            // Force the next text insert to be on a new line.

            lower_left_paragraph.InsertText("\n", false);



            // Create a custom property called company_address_line_two

            CustomProperty hired_company_address_line_three =

                new CustomProperty("hired_company_address_line_three",

                    "Zip Code");



            // Insert a field of type doc property

            // (This will display the custom property

            // 'hired_company_address_line_three')

            lower_left_paragraph.InsertDocProperty(

                hired_company_address_line_three, false, light_formatting);



            #endregion



            #region Date & Invoice number



            // Get the lower right Paragraph from the layout table.

            Paragraph lower_right_paragraph =

                layout_table.Rows[1].Cells[1].InsertParagraph();



            CustomProperty invoice_date =

                new CustomProperty("invoice_date",

                    DateTime.Today.Date.ToString("d"));



            lower_right_paragraph.InsertText("Date: ",

                false, dark_formatting);



            lower_right_paragraph.InsertDocProperty(invoice_date, false,

                light_formatting);



            CustomProperty invoice_time =

                new CustomProperty("invoice_time",

                    DateTime.Today.Date.ToShortTimeString());



            lower_right_paragraph.InsertText("\nTime: ",

                false, dark_formatting);



            lower_right_paragraph.InsertText("", false,

                light_formatting);



            lower_right_paragraph.InsertDocProperty(invoice_time, false,

                light_formatting);



            // set the paragraph to align against the right side

            // of the invoice

            lower_right_paragraph.Alignment = Alignment.right;



            #endregion





            #region Statement of thanks



            // Insert an empty Paragraph between two Tables,

            // so that they do not touch.

            document.InsertParagraph(string.Empty, false);



            // This table will hold all of the invoice data.

            // set the table style to a canned format

            Table invoice_table = document.InsertTable(7, 4);

            invoice_table.Design = TableDesign.LightShadingAccent1;

            invoice_table.Alignment = Alignment.center;



            // A nice thank you Paragraph.

            Paragraph thankyou =

                document.InsertParagraph("\nThank you for your business, " +

                "see us again for all of your OEM parts needs.",

                false, dark_formatting);



            thankyou.Alignment = Alignment.center;



            #endregion



            #region Hired company details



            CustomProperty hired_company_details_line_one =

                new CustomProperty("hired_company_details_line_one",

                    "Street Address, City, ZIP Code");



            CustomProperty hired_company_details_line_two =

                new CustomProperty("hired_company_details_line_two",

                    "Phone: 000-000-0000, Fax: 000-000-0000, " +

                    "e-mail: support@companyname.com");



            Paragraph companyDetails =

                document.InsertParagraph(string.Empty, false);



            companyDetails.InsertDocProperty(hired_company_details_line_one, false,

                light_formatting);



            companyDetails.InsertText("\n", false);



            companyDetails.InsertDocProperty(hired_company_details_line_two, false,

                light_formatting);



            companyDetails.Alignment = Alignment.center;



            #endregion



            // Return the template document now that it has been created.
            document.Save();
            //return document;

        }
        #region ONLY WORK WITH INTEROP/MICROSOFT WORD INSTALLED
        //private void CreateDocument()
        //{
        //    try
        //    {
        //        //Create an instance for word app
        //        Microsoft.Office.Interop.Word.Application winword = new Microsoft.Office.Interop.Word.Application();

        //        //Set animation status for word application
        //        //winword.showa = false;

        //        //Set status for word application is to be visible or not.
        //        winword.Visible = false;

        //        //Create a missing variable for missing value
        //        object missing = System.Reflection.Missing.Value;

        //        //Create a new document
        //        Document document = winword.Documents.Add(ref missing, ref missing, ref missing, ref missing);

        //        //Add header into the document
        //        foreach (Section section in document.Sections)
        //        {
        //            //Get the header range and add the header details.
        //            Range headerRange = section.Headers[WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
        //            headerRange.Fields.Add(headerRange, WdFieldType.wdFieldPage);
        //            headerRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
        //            headerRange.Font.ColorIndex = WdColorIndex.wdBlue;
        //            headerRange.Font.Size = 10;
        //            headerRange.Text = "Header text goes here";
        //        }

        //        //Add the footers into the document
        //        foreach (Section wordSection in document.Sections)
        //        {
        //            //Get the footer range and add the footer details.
        //            Range footerRange = wordSection.Footers[WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
        //            footerRange.Font.ColorIndex = WdColorIndex.wdDarkRed;
        //            footerRange.Font.Size = 10;
        //            footerRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
        //            footerRange.Text = "Footer text goes here";
        //        }

        //        //adding text to document
        //        document.Content.SetRange(0, 0);
        //        document.Content.Text = "This is test document " + Environment.NewLine;

        //        //Add paragraph with Heading 1 style
        //        Paragraph para1 = document.Content.Paragraphs.Add(ref missing);
        //        object styleHeading1 = "Heading 1";
        //        para1.Range.set_Style(ref styleHeading1);
        //        para1.Range.Text = "Para 1 text";
        //        para1.Range.InsertParagraphAfter();

        //        //Add paragraph with Heading 2 style
        //        Paragraph para2 = document.Content.Paragraphs.Add(ref missing);
        //        object styleHeading2 = "Heading 2";
        //        para2.Range.set_Style(ref styleHeading2);
        //        para2.Range.Text = "Para 2 text";
        //        para2.Range.InsertParagraphAfter();

        //        //Create a 5X5 table and insert some dummy record
        //        Table firstTable = document.Tables.Add(para1.Range, 5, 5, ref missing, ref missing);

        //        firstTable.Borders.Enable = 1;
        //        foreach (Row row in firstTable.Rows)
        //        {
        //            foreach (Cell cell in row.Cells)
        //            {
        //                //Header row
        //                if (cell.RowIndex == 1)
        //                {
        //                    cell.Range.Text = "Column " + cell.ColumnIndex.ToString();
        //                    cell.Range.Font.Bold = 1;
        //                    //other format properties goes here
        //                    cell.Range.Font.Name = "verdana";
        //                    cell.Range.Font.Size = 10;
        //                    //cell.Range.Font.ColorIndex = WdColorIndex.wdGray25;                            
        //                    cell.Shading.BackgroundPatternColor = WdColor.wdColorGray25;
        //                    //Center alignment for the Header cells
        //                    cell.VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;
        //                    cell.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;

        //                }
        //                //Data row
        //                else
        //                {
        //                    cell.Range.Text = (cell.RowIndex - 2 + cell.ColumnIndex).ToString();
        //                }
        //            }
        //        }

        //        //Save the document
        //        object filename = @"d:\temp1.docx";
        //        document.SaveAs(ref filename);
        //        document.Close(ref missing, ref missing, ref missing);
        //        document = null;
        //        winword.Quit(ref missing, ref missing, ref missing);
        //        winword = null;
        //        MessageBox.Show("Document created successfully !");
        //    }
        //    catch (Exception ex)
        //    {
        //        cbPengakuanBebanKinerja.Text = ex.Message;
        //        //MessageBox.Show(ex.Message);
        //    }
        //}
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data.Common;
using System.Security.Cryptography;

namespace uas_bd_1
{
    public partial class Login : Form
    {
        //Inisialisasi koneksi database dan variabel berkaitan dengan database
        MySqlConnection co = new MySqlConnection("server = localhost; Database = uas_bd1; Uid = root");
        MySqlCommand mycommand = new MySqlCommand();
        MySqlDataAdapter myadapter = new MySqlDataAdapter();

        public Login()
        {
            InitializeComponent();
        }

        //fungsi untuk mendapatkan hash sha256 dari sebuah string
        public static String sha256_hash(String value)
        {
            StringBuilder Sb = new StringBuilder();

            using (SHA256 hash = SHA256Managed.Create())
            {
                Encoding enc = Encoding.UTF8;
                Byte[] result = hash.ComputeHash(enc.GetBytes(value));

                foreach (Byte b in result)
                    Sb.Append(b.ToString("x2"));
            }

            return Sb.ToString();
        }

        //jika login ditekan
        private void button1_Click(object sender, EventArgs e)
        {
            //mulai dan buka koneksi ke database
            mycommand.Connection = co;
            if (co != null && co.State == ConnectionState.Closed)
            {
                co.Open();
            }

            try
            {
                //ambil username dan pw yg diinput, lalu dienkripsi
                string username = input_un.Text;
                string plain_pw = input_pw.Text;
                string cipher_pw = sha256_hash(plain_pw);

                string query = "SELECT * FROM accounts WHERE username = '" + username + "' AND password = '" + cipher_pw + "';";

                //pilih data dari database accounts dimana username dan password cocok
                mycommand.CommandText = query;
                myadapter.SelectCommand = mycommand;

                DataSet ds = new DataSet();
                myadapter.Fill(ds);

                //jika ada row yang ditemukan dari query
                if (ds.Tables[0].Rows.Count > 0)
                {
                    //beritahu user, tutup form dan buka form dashboard
                    MessageBox.Show("Akun ditemukan, selamat datang, " + username);

                    co.Close();
                    Dashboard show = new Dashboard();
                    show.Show();
                    this.Hide();
                }
                //jika tidak ada beritahu user login gagal
                else
                {
                    MessageBox.Show("Tidak ada akun ditemukan,\nmohon cek username dan password\nyang dimasukkan");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

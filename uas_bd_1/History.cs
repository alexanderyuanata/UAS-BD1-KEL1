using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uas_bd_1
{
    public partial class History : Form
    {
        //MySql initialization
        MySqlConnection co = new MySqlConnection("server = localhost; Database = uas_bd1; Uid = root");
        MySqlCommand mycommand = new MySqlCommand();
        MySqlDataAdapter myadapter = new MySqlDataAdapter();

        //tampilkan data dengan default query
        void tampildata(string query = 
            "select obat_dalam_transaksi.id_transaksi, obat_dalam_transaksi.id_obat,"
            + " obat_dalam_transaksi.jlh, `obat`.`merek dagang`, obat.harga, transaksi.waktu_transaksi from obat_dalam_transaksi"
            + " inner join obat on obat_dalam_transaksi.id_obat = obat.id"
            + " inner join transaksi on obat_dalam_transaksi.id_transaksi = transaksi.id_transaksi"
            + " order by obat_dalam_transaksi.id_transaksi ASC;")
            //query menampikan id transaksi, id obat, jumlah dalam transaksi, merek dagang, harga dan waktu transaksi
        {
            try
            {
                //buka koneksi dan pilih query
                mycommand.Connection = co;
                if (co != null && co.State == ConnectionState.Closed)
                {
                    co.Open();
                }
                myadapter.SelectCommand = new MySqlCommand(query, co);

                //jika query mengembalikan data, tampilkan
                DataSet ds = new DataSet();
                if (myadapter.Fill(ds, "dftpesan") > 0)
                {
                    history_view.DataSource = ds;
                    history_view.DataMember = "dftpesan";
                }

            }
            catch (Exception ex) //error handling
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public History()
        {
            //tampilkan data saat form dibuat
            InitializeComponent();
            tampildata();
        }

        //jika tombol exit ditekan maka berpindah ke form dashboard
        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard show = new Dashboard();
            show.Show();
            this.Hide();
        }
    }
}

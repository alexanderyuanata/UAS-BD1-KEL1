using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Collections;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace uas_bd_1
{
    public partial class ShowObat : Form
    {
        //MySql initialization
        MySqlConnection co = new MySqlConnection("server = localhost; Database = uas_bd1; Uid = root");
        MySqlCommand mycommand = new MySqlCommand();
        MySqlDataAdapter myadapter = new MySqlDataAdapter();

        //tampilkan data dari tabel obat tergantung dari query
        void tampildata(string query = "SELECT * FROM obat") //nilai query default
        {
            try
            {
                //buka koneksi ke mysql jika koneksi tertutup
                if (co != null && co.State == ConnectionState.Closed)
                {
                    co.Open();
                }
                //pilih query dan dieksekusi
                myadapter.SelectCommand = new MySqlCommand(query,co);

                //jika row yang dikembalikan query > 0 maka datasource diset
                DataSet ds = new DataSet();
                if (myadapter.Fill(ds, "dftpesan") > 0)
                {
                    mydatagrid.DataSource = ds;
                    mydatagrid.DataMember = "dftpesan";
                }

            }
            catch (Exception ex) //error handling
            {
                MessageBox.Show(ex.ToString());
            }
        }
        
        public ShowObat()
        {
            InitializeComponent();
            input_exp.Format = DateTimePickerFormat.Custom;
            //Format date time untuk insert ke database
            input_exp.CustomFormat = "yyyy-MM-dd";
        }

        //Saat form diload maka data ditampilkan dgn query default
        private void Form1_Load(object sender, EventArgs e)
        {
            tampildata();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        //Displays a row with a specific id
        private void search_btn_Click(object sender, EventArgs e)
        {
            //ambil id dari input
            string id = input_search.Text;

            //query mencari row dengan id yang mirip id pencarian
            string query = "SELECT * FROM obat WHERE id LIKE '%" + id + "%';";
            //set query dan pilih
            mycommand.Connection = co;
            mycommand.CommandText = query;
            myadapter.SelectCommand = mycommand;

            //isikan ds dengan hasil query
            DataSet ds = new DataSet();
            myadapter.Fill(ds);
            //jika query tidak mengembalikan row maka beritahu user
            if (ds.Tables[0].Rows.Count <= 0)
            {
                string message = "Data not found";
                string title = "Search Failure";

                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons);
                tampildata();
            }
            //jika query mengembalikan row maka tampilkan data dengan query ini
            else
            {
                tampildata(query);
            }
            //reset isi input
            input_search.Text = String.Empty;
        }

        //ketika tombol add data ditekan
        private void add_btn_Click(object sender, EventArgs e)
        {
            //deklarasi variabel dari input2
            string id = input_id.Text;
            uint stok = (uint)input_stock.Value;
            string satuan = input_unit.Text;
            ulong harga = (uint)input_price.Value;
            string merek = input_name.Text;

            //query mencari row dengan id yang sama dengan id pencarian
            string query = "SELECT * FROM obat WHERE id LIKE '" + id + "';";
            //set query dan pilih
            mycommand.Connection = co;
            mycommand.CommandText = query;
            myadapter.SelectCommand = mycommand;

            //isikan ds dengan hasil query
            DataSet ds = new DataSet();
            myadapter.Fill(ds);
            //jika query mengembalikan row maka beritahu user
            if (ds.Tables[0].Rows.Count > 0)
            {
                string message = "Sudah ada obat dengan ID sama, tolong ulangi!";
                string title = "Insert Failure";

                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons);
                tampildata();
            }
            else
            {

                try
                {
                    //query untuk memasukkan data
                    query = "INSERT INTO obat VALUES('" + id + "', '" + stok + "', '" + satuan + "', '" + harga + "', '" + input_exp.Text + "', '" + merek + "');";

                    //query diset ke query baru
                    mycommand.Connection = co;
                    mycommand.CommandText = query;
                    myadapter.SelectCommand = mycommand;

                    //eksekusi command, jika hanya 1 row yang dipengaruhi berarti bekerja dengan benar
                    if (mycommand.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Obat " + merek + " berhasil diciptakan");
                    }
                    //selain itu kemungkinan ada error
                    else
                    {
                        MessageBox.Show("Ada kesalahan!");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            //reset isi input
            input_id.Text = String.Empty;
            input_stock.Value = 0;
            input_name.Text = String.Empty;
            input_price.Value = 0;
            input_unit.Text = String.Empty;

            //tampilkan data lagi
            tampildata();
        }

        private void input_unit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //jika tombol exit ditekan
        private void exitobat_btn_Click(object sender, EventArgs e)
        {
            //tutup koneksi
            if (co != null && co.State == ConnectionState.Open)
            {
                co.Close();
            }
            //berpindah ke form dashboard
            Dashboard show = new Dashboard();
            show.Show();
            this.Hide();
        }

        //jika tombol delete ditekan
        private void delete_btn_Click(object sender, EventArgs e)
        {
            //ambil id obat yang ditekan
            string id = input_delete.Text;

            //query mencari obat yang idnya persis sama (delete hanya boleh mempengaruhi 1 row)
            string query = "SELECT * FROM obat WHERE id = '" + id + "';";

            //set query
            mycommand.Connection = co;
            mycommand.CommandText = query;
            myadapter.SelectCommand = mycommand;

            //query dimasukkan ke ds, jika isi ds lebih dari 0 berarti ada obat ditemukan
            DataSet ds = new DataSet();
            myadapter.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                //tampilkan messagebox, tanya bila user yakin ingin menghapus obat
                string message = "Data " + ds.Tables[0].Rows[0][0].ToString() +" found,\nare you sure you want to PERMANENTLY delete it?";
                string title = "Delete Entry";

                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);

                //jika dijawab yes maka lakukan query untuk menghapus obat dengan id tersebut
                if (result == DialogResult.Yes)
                {
                    string query2 =  "DELETE FROM obat_dalam_transaksi WHERE id_obat ='"+id+"';"
                                    +"DELETE FROM obat WHERE id = '"+id+"';";

                    mycommand.CommandText = query2;
                    myadapter.SelectCommand = mycommand;
                    mycommand.ExecuteNonQuery();
                }
            }
            //jika tidak ditemukan obat maka tampilkan
            else
            {
                MessageBox.Show("Data not found", "Search Fail", MessageBoxButtons.OK);
            }
            //kosongkan input dan update tampilan data
            input_delete.Text = String.Empty;
            tampildata();
        }

        //jika tombol edit ditekan
        private void edit_btn_Click(object sender, EventArgs e)
        {
            //ambil input dan deklarasikan variabel dengan nilai2 input
            string id = input_id.Text;
            uint stok = (uint)input_stock.Value;
            string satuan = input_unit.Text;
            ulong harga = (uint)input_price.Value;
            string merek = input_name.Text;

            try
            {
                //cari id yang persis sama dalam tabel obat dengan id input
                string query = "SELECT * FROM obat WHERE `id` = '" + id + "';";

                //pilih query baru dan isikan ds dengan hasil query
                mycommand.Connection = co;
                mycommand.CommandText = query;
                myadapter.SelectCommand = mycommand;

                DataSet ds = new DataSet();
                myadapter.Fill(ds);

                //jika query mengembalikan row berarti ada obat yang id sama
                if (ds.Tables[0].Rows.Count > 0)
                {
                    //query untuk mengupdate isi dari row
                    query = "UPDATE obat SET id = '" + id + "', stok = '" + stok + "', satuan = '" + satuan + "', harga = '" + harga + "', exp = '" + input_exp.Text + "', `merek dagang` = '" + merek + "' WHERE id = '" + id + "';";

                    //pilih query baru
                    mycommand.CommandText = query;
                    myadapter.SelectCommand = mycommand;

                    //eksekusi query dan jika hanya 1 row yang terdampak
                    if (mycommand.ExecuteNonQuery() == 1)
                    {
                        //beritahu user editing sukses
                        MessageBox.Show("Obat " + merek + " berhasil diedit");
                    }
                    //selain itu kemungkinan ada kesalahan
                    else
                    {
                        MessageBox.Show("Ada kesalahan!");
                    }
                }
                else //jika query tidak mengembalikan row berarti tidak ada obat dengan id tersebut
                {
                    MessageBox.Show("Tidak ada obat dengan ID tersebut, mohon coba lagi!", "Obat Gagal Dicari", MessageBoxButtons.OK);
                }
            } //error handling
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            //kosongkan isi input
            input_id.Text = String.Empty;
            input_stock.Value = 0;
            input_name.Text = String.Empty;
            input_price.Value = 0;
            input_unit.Text = String.Empty;

            //tampilkan data yang sudah terupdate
            tampildata();
        }

        private void mydatagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        //jika datagrid ditekan (diselect), maka nilai input diubah agar mudah diselect
        private void mydatagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //ambil jumlah row yang diselect, jika hanya 1
            int selectedRowCount = mydatagrid.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount == 1)
            {
                //ambil nilai2 dalam datagrid dan dideklarasikan variabel dengan nilai tersebut
                string id = mydatagrid.SelectedRows[0].Cells[0].Value.ToString();
                uint stok = (uint)mydatagrid.SelectedRows[0].Cells[1].Value;
                string satuan = mydatagrid.SelectedRows[0].Cells[2].Value.ToString();
                ulong harga =(ulong)mydatagrid.SelectedRows[0].Cells[3].Value;
                string exp = mydatagrid.SelectedRows[0].Cells[4].Value.ToString();
                string merek = mydatagrid.SelectedRows[0].Cells[5].Value.ToString();

                //ganti nilai2 input menjadi nilai2 dalam tabel
                input_id.Text = id;
                input_stock.Value = stok;
                input_unit.Text = satuan;
                input_price.Value = harga;
                input_exp.Text = exp;
                input_name.Text = merek;
            }
        }
    }
}

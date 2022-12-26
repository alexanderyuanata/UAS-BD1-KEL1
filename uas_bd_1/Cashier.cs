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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace uas_bd_1
{
    public partial class Cashier : Form
    {
        bool toggle = false;
        //MySql initialization
        MySqlConnection co = new MySqlConnection("server = localhost; Database = uas_bd1; Uid = root");
        MySqlCommand mycommand = new MySqlCommand();
        MySqlDataAdapter myadapter = new MySqlDataAdapter();

        string id;
        uint stok;
        string satuan;
        ulong harga;
        string merek;
        int row_id;

        void tampildataobat(string query = "SELECT id, `merek dagang`, satuan, stok, harga FROM obat")
        {
            try
            {
                mycommand.Connection = co;
                if (co != null && co.State == ConnectionState.Closed)
                {
                    co.Open();
                }
                myadapter.SelectCommand = new MySqlCommand(query, co);

                DataSet ds = new DataSet();
                if (myadapter.Fill(ds, "dftpesan") > 0)
                {
                    obat_list.DataSource = ds;
                    obat_list.DataMember = "dftpesan";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        public Cashier()
        {
            InitializeComponent();
            tampildataobat();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void confirm_purchase_Click(object sender, EventArgs e)
        {
            //query for transaksi
            ulong t_total = Convert.ToUInt32(label_price_2.Text);
            try
            {
                //Query needed for function
                string query = "INSERT INTO transaksi(nominal) VALUES('" + t_total + "');";

                //Sets CommandText as query and selects it
                mycommand.CommandText = query;
                myadapter.SelectCommand = mycommand;

                //Executes command, if it returns 1 affected row:
                mycommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            //query for obat_dalam_transaksi
            try
            {
                mycommand.CommandText = "SELECT LAST_INSERT_ID()";
                myadapter.SelectCommand = mycommand;
                mycommand.ExecuteNonQuery();

                DataSet ds = new DataSet();
                myadapter.Fill(ds);
                int new_id = Convert.ToInt16(ds.Tables[0].Rows[0][0]);
                int old_stok;
               
                string new_obat;
                int new_stok;

                foreach (DataGridViewRow row in item_list.Rows)
                {
                    new_obat = row.Cells[0].Value.ToString();
                    new_stok = Convert.ToInt16(row.Cells[3].Value.ToString());

                    mycommand.CommandText = "SELECT stok FROM obat WHERE id='" + new_obat + "';";
                    myadapter.SelectCommand = mycommand;
                    mycommand.ExecuteNonQuery();
                    DataSet ds2 = new DataSet();
                    myadapter.Fill(ds2);
                    old_stok = Convert.ToInt16(ds2.Tables[0].Rows[0][0]);

                    mycommand.CommandText = "INSERT INTO obat_dalam_transaksi VALUES('" + new_id + "', '" + new_obat + "', '" + new_stok + "');";
                    myadapter.SelectCommand = mycommand;
                    mycommand.ExecuteNonQuery();

                    mycommand.CommandText = "UPDATE obat SET stok='" + Convert.ToString(old_stok - new_stok) + "' WHERE id = '" + new_obat + "';";
                    myadapter.SelectCommand = mycommand;
                    mycommand.ExecuteNonQuery();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            MessageBox.Show("Transaksi telah direkam!", "Sukses", MessageBoxButtons.OK);
            item_list.Rows.Clear();
            tampildataobat();
        }

        private void filter_id_btn_Click(object sender, EventArgs e)
        {
            if (in_filter_id.Text == String.Empty) tampildataobat();
            string query = "SELECT * FROM obat WHERE id LIKE '%" + in_filter_id.Text + "%';";
            tampildataobat(query);
        }

        private void filter_unit_btn_Click(object sender, EventArgs e)
        {
            if (in_filter_unit.Text == String.Empty) tampildataobat();
            string query = "SELECT * FROM obat WHERE satuan LIKE '%" + in_filter_unit.Text + "%';";
            tampildataobat(query);
        }
        private void filter_name_btn_Click(object sender, EventArgs e)
        {
            if (in_filter_merek.Text == String.Empty) tampildataobat();
            string query = "SELECT * FROM obat WHERE `merek dagang` LIKE '%" + in_filter_merek.Text + "%';";
            tampildataobat(query);
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Dashboard show = new Dashboard();
            show.Show();
            this.Hide();
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            item_list.Rows.Clear();
        }

        private bool findid(string ide)
        {
            foreach (DataGridViewRow row in item_list.Rows)
            {
                if (row.Cells[0].Value.ToString() == ide)
                {
                    return true;
                }
            }
            return false;
        }

        private void total_price()
        {
            long total = 0;
            foreach (DataGridViewRow row in item_list.Rows)
            {
                total += Convert.ToInt32(row.Cells[4].Value);
            }

            label_price_2.Text = Convert.ToString(total);
        }
        private void add_btn_Click(object sender, EventArgs e)
        {
            uint jlh = (uint)input_jlh.Value;
            
            if (jlh <= 0 || (int)stok - (int)jlh < 0 || !toggle)
            {
                MessageBox.Show("Terdapat kesalahan, mohon cek obat yang dipilih dan jumlah yang ditambah!", "Error", MessageBoxButtons.OK);
                return;
            }

            foreach (DataGridViewRow row in item_list.Rows)
            {
                if (row.Cells[0].Value.ToString() == id)
                {
                    uint num = Convert.ToUInt32(row.Cells[3].Value.ToString());
                    if ((num + jlh) > stok)
                    {
                        MessageBox.Show("Tidak cukup stok untuk ditambah!", "Error", MessageBoxButtons.OK);
                        return;
                    }
                    else
                    {
                        row.Cells[3].Value = Convert.ToString(num + jlh);
                        row.Cells[4].Value = Convert.ToString((num + jlh) * harga);
                        total_price();
                        return;
                    }
                }
            }

            this.item_list.Rows.Add(id, merek, satuan, jlh, harga * jlh);
            total_price();
        }

        private void obat_list_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!toggle) toggle = true;
            int selectedRowCount = obat_list.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount == 1)
            {
                id = obat_list.SelectedRows[0].Cells[0].Value.ToString();
                stok = (uint)obat_list.SelectedRows[0].Cells[3].Value;
                satuan = obat_list.SelectedRows[0].Cells[2].Value.ToString();
                harga = (ulong)obat_list.SelectedRows[0].Cells[4].Value;
                merek = obat_list.SelectedRows[0].Cells[1].Value.ToString();
            }
        }

        private void subtract_btn_Click(object sender, EventArgs e)
        {
        }

        private void remove_btn_Click(object sender, EventArgs e)
        {
            if (this.item_list.SelectedRows.Count == 1)
            {
                item_list.Rows.RemoveAt(this.item_list.SelectedRows[0].Index);
            }
        }

        private void item_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void item_list_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row_id = e.RowIndex;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

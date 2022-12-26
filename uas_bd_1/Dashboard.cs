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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        //jika tombol logout ditekan maka tutup form dashboard dan kembali ke form login
        private void logout_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logout berhasil");
            Login show = new Login();
            show.Show();
            this.Hide();
        }

        //jika tombol obat ditekan maka berpindah ke form ShowObat
        private void to_obat_Click(object sender, EventArgs e)
        {
            ShowObat show = new ShowObat();
            show.Show();
            this.Hide();
        }

        //jika tombol history ditekan maka berpindah ke form sejarah transaksi
        private void to_history_Click(object sender, EventArgs e)
        {
            History show = new History();
            show.Show();
            this.Hide();
        }

        //jika tombol kasir ditekan maka berpindah ke form kasir
        private void to_kasir_Click(object sender, EventArgs e)
        {
            Cashier show = new Cashier();
            show.Show();
            this.Hide();
        }
    }
}

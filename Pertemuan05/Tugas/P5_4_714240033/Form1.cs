using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_4_714240033
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTampilkan_Click(object sender, EventArgs e)
        {
            string pilihanKelas = "";
            string pilihanJadwal = "";

            // Validasi Kelas
            if (!cbSepakBola.Checked && !cbBasket.Checked && !cbRenang.Checked &&
                !cbBuluTangkis.Checked && !cbTenis.Checked && !cbVoli.Checked &&
                !cbYoga.Checked && !cbPanahan.Checked)
            {
                MessageBox.Show("Harus memilih salah satu dari pilihan kelas", 
                    "Warning", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning); 
                return;
            }

            // Validasi Jadwal
            if (!rbJadwal1.Checked && !rbJadwal2.Checked && !rbJadwal3.Checked && !rbJadwal4.Checked)
            {
                MessageBox.Show("Harus memilih salah satu dari pilihan jadwal", "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning); 
                return;
            }

            // Data Kelas
            if (cbSepakBola.Checked) {pilihanKelas += "Sepak Bola, ";}
            if (cbBasket.Checked) {pilihanKelas += "Basket, ";}
            if (cbRenang.Checked) {pilihanKelas += "Renang, ";}
            if (cbBuluTangkis.Checked) {pilihanKelas += "Bulu Tangkis, ";}
            if (cbTenis.Checked) {pilihanKelas += "Tenis, ";}
            if (cbVoli.Checked) {pilihanKelas += "Voli, ";}
            if (cbYoga.Checked) {pilihanKelas += "Yoga, ";}
            if (cbPanahan.Checked) {pilihanKelas += "Panahan, ";}
            pilihanKelas = pilihanKelas.TrimEnd(',', ' ');

            // Data Jadwal
            if (rbJadwal1.Checked) { pilihanJadwal = rbJadwal1.Text; }
            else if (rbJadwal2.Checked) { pilihanJadwal = rbJadwal2.Text; }
            else if (rbJadwal3.Checked) { pilihanJadwal = rbJadwal3.Text; }
            else if (rbJadwal4.Checked) { pilihanJadwal = rbJadwal4.Text; }

            // MessageBox
            string nama = txtNama.Text;
            string jenisKelamin = cmbJenisKelamin.Text;
            string tanggalLahir = dtpTanggalLahir.Text;

            string hasil = "Nama: " + nama + "\n" +
                           "Jenis Kelamin: " + jenisKelamin + "\n" +
                           "Tanggal Lahir: " + tanggalLahir + "\n" +
                           "Pilihan Kelas: " + pilihanKelas + "\n" +
                           "Pilihan Jadwal: " + pilihanJadwal;

            MessageBox.Show(hasil, "Informasi Pendaftaran", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}

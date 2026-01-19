using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using P9_714240033.controller;
using P9_714240033.model;
using MySql.Data.MySqlClient;

namespace P9_714240033.view
{
    public partial class FormBarang : Form
    {
        Barang barang = new Barang();

        public FormBarang()
        {
            InitializeComponent();
        }

        public void Tampil()
        {
            DataBarang.DataSource = barang.Tampil();

            DataBarang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            DataBarang.Columns[2].DefaultCellStyle.Format = "Rp #,###";

            DataBarang.Columns[0].HeaderText = "ID";
            DataBarang.Columns[1].HeaderText = "Nama Barang";
            DataBarang.Columns[2].HeaderText = "Harga";
        }

        public void ResetForm()
        {
            txtNamaBarang.Text = "";
            txtHarga.Text = "";
            txtCari.Text = "";
        }

        private void FormBarang_Load(object sender, EventArgs e)
        {
            Tampil();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (txtNamaBarang.Text == "" || txtHarga.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                M_barang m_barang = new M_barang();
                m_barang.Nama_barang = txtNamaBarang.Text;
                m_barang.Harga = txtHarga.Text;

                barang.Insert(m_barang);
                ResetForm();
                Tampil();
            }
        }

        private void btnUbah_Click_1(object sender, EventArgs e)
        {
            if (DataBarang.CurrentRow != null)
            {
                M_barang m_barang = new M_barang();
                m_barang.Nama_barang = txtNamaBarang.Text;
                m_barang.Harga = txtHarga.Text;

                string id = DataBarang.CurrentRow.Cells[0].Value.ToString();

                barang.Update(m_barang, id);
                ResetForm();
                Tampil();
            }
            else
            {
                MessageBox.Show("Pilih data yang ingin diubah!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnHapus_Click_1(object sender, EventArgs e)
        {
            if (DataBarang.CurrentRow != null)
            {
                DialogResult pesan = MessageBox.Show("Yakin hapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (pesan == DialogResult.Yes)
                {
                    string id = DataBarang.CurrentRow.Cells[0].Value.ToString();
                    barang.Delete(id);
                    ResetForm();
                    Tampil();
                }
            }
            else
            {
                MessageBox.Show("Pilih data yang ingin dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ResetForm();
            Tampil();
        }

        private void DataBarang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtNamaBarang.Text = DataBarang.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtHarga.Text = DataBarang.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            DataBarang.DataSource = barang.CariData(txtCari.Text);

            DataBarang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataBarang.Columns[2].DefaultCellStyle.Format = "Rp #,###";
            DataBarang.Columns[0].HeaderText = "ID";
            DataBarang.Columns[1].HeaderText = "Nama Barang";
            DataBarang.Columns[2].HeaderText = "Harga";
        }
    }
}

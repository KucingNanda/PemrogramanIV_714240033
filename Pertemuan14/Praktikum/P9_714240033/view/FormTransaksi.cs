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
using System.Globalization;

namespace P9_714240033.view
{
    public partial class FormTransaksi : Form
    {
        Transaksi transaksi = new Transaksi();
        Koneksi koneksi = new Koneksi();

        public FormTransaksi()
        {
            InitializeComponent();
        }

        public void Tampil()
        {
            DataTransaksi.DataSource = transaksi.Tampil();
            DataTransaksi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            CultureInfo culture = new CultureInfo("id-ID");

            DataTransaksi.Columns[3].DefaultCellStyle.Format = "C0";
            DataTransaksi.Columns[3].DefaultCellStyle.FormatProvider = culture;

            DataTransaksi.Columns[5].DefaultCellStyle.Format = "C0";
            DataTransaksi.Columns[5].DefaultCellStyle.FormatProvider = culture;

            DataTransaksi.Columns[0].HeaderText = "ID";
            DataTransaksi.Columns[1].HeaderText = "ID Barang";
            DataTransaksi.Columns[2].HeaderText = "Nama Barang";
            DataTransaksi.Columns[3].HeaderText = "Harga";
            DataTransaksi.Columns[4].HeaderText = "Qty";
            DataTransaksi.Columns[5].HeaderText = "Total";
        }

        private void FormTransaksi_Load_1(object sender, EventArgs e)
        {
            Tampil();
            LoadBarang();
        }

        public void LoadBarang()
        {
            koneksi.OpenConnection();
            MySqlDataReader reader = koneksi.reader("SELECT * FROM t_barang");
            while (reader.Read())
            {
                cbIdBarang.Items.Add(reader["id_barang"].ToString());
            }
            reader.Close();
            koneksi.CloseConnection();
        }

        private void cbIdBarang_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbIdBarang.SelectedIndex != -1)
            {
                koneksi.OpenConnection();
                MySqlDataReader reader = koneksi.reader("SELECT * FROM t_barang WHERE id_barang = '" + cbIdBarang.Text + "'");
                if (reader.Read())
                {
                    txtNamaBarang.Text = reader["nama_barang"].ToString();
                    txtHarga.Text = reader["harga"].ToString();
                }
                reader.Close();
                koneksi.CloseConnection();
            }
        }

        private void txtQty_TextChanged_1(object sender, EventArgs e)
        {
            if (txtQty.Text != "" && txtHarga.Text != "")
            {
                try
                {
                    int harga = int.Parse(txtHarga.Text);
                    int qty = int.Parse(txtQty.Text);

                    int total = harga * qty;

                    txtTotal.Text = total.ToString();
                }
                catch
                {
                    txtTotal.Text = "0";
                }
            }
        }

        public void ResetForm()
        {
            cbIdBarang.SelectedIndex = -1;
            txtNamaBarang.Text = "";
            txtHarga.Text = "";
            txtQty.Text = "";
            txtTotal.Text = "";
        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            ResetForm();
            Tampil();
        }

        private void btnSimpan_Click_1(object sender, EventArgs e)
        {
            if (cbIdBarang.Text == "" || txtQty.Text == "" || txtTotal.Text == "")
            {
                MessageBox.Show("Data tidak lengkap!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                M_Transaksi m_trans = new M_Transaksi();
                m_trans.Id_barang = cbIdBarang.Text;
                m_trans.Qty = txtQty.Text;
                m_trans.Total = txtTotal.Text;

                transaksi.Insert(m_trans);
                ResetForm();
                Tampil();
            }
        }

        private void DataTransaksi_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                cbIdBarang.Text = DataTransaksi.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtQty.Text = DataTransaksi.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

        private void DataTransaksi_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3 || e.ColumnIndex == 5)
            {
                if (e.Value != null)
                {
                    double nilai;
                    if (double.TryParse(e.Value.ToString(), out nilai))
                    {
                        e.Value = nilai.ToString("C0", new System.Globalization.CultureInfo("id-ID"));
                        e.FormattingApplied = true;
                    }
                }
            }
        }

        private void textBoxCariData_TextChanged(object sender, EventArgs e)
        {
            DataTransaksi.DataSource = transaksi.CariData(textBoxCariData.Text);

            DataTransaksi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}

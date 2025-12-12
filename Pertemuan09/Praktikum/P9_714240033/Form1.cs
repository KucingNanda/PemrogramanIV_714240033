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

namespace P9_714240033
{
    public partial class Form1 : Form
    {
        Koneksi koneksi = new Koneksi();
        public Form1()
        {
            InitializeComponent();
        }

        public void Tampil()
        {
            string query = "SELECT * FROM t_mahasiswa";
            DataTable data = koneksi.ShowData(query);

            DataMahasiswa.DataSource = data;
            DataMahasiswa.Columns[0].HeaderText = "NPM";
            DataMahasiswa.Columns[1].HeaderText = "Nama";
            DataMahasiswa.Columns[2].HeaderText = "Angkatan";
            DataMahasiswa.Columns[3].HeaderText = "Alamat";
            DataMahasiswa.Columns[4].HeaderText = "Email";
            DataMahasiswa.Columns[5].HeaderText = "No HP";

            DataMahasiswa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            Tampil();
        }
    }
}

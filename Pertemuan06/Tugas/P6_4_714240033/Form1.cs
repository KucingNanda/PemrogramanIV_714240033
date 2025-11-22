using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace P6_4_714240033
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SetErrorMessages(TextBox textBox, 
            string warning, 
            string wrong, 
            string correct)
        {
            epWarning.SetError(textBox, warning);
            epWrong.SetError(textBox, wrong);
            epCorrect.SetError(textBox, correct);
        }

        private void txtNama_Leave(object sender, EventArgs e)
        {
            if (txtNama.Text == "")
            {
                SetErrorMessages(txtNama, "Nama belum diisi!", "", "");
            }
            // Regex agar spasi diperbolehkan
            else if (!Regex.IsMatch(txtNama.Text, @"^[a-zA-Z\s]+$"))
            {
                SetErrorMessages(txtNama, "", "Nama hanya boleh huruf!", "");
            }
            else
            {
                SetErrorMessages(txtNama, "", "", "Betul!");
            }
        }

        private void txtTelepon_Leave(object sender, EventArgs e)
        {
            if (txtTelepon.Text == "")
            {
                SetErrorMessages(txtTelepon, "No HP belum diisi!", "", "");
            }
            // Validasi Numeric
            else if (!txtTelepon.Text.All(Char.IsNumber))
            {
                SetErrorMessages(txtTelepon, "", "Hanya boleh angka!", "");
            }
            // Validasi Length
            else if (txtTelepon.Text.Length < 10 || txtTelepon.Text.Length > 13)
            {
                SetErrorMessages(txtTelepon, "", "No HP harus 10-13 digit!", "");
            }
            else
            {
                SetErrorMessages(txtTelepon, "", "", "Betul!");
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            // Regex Email standar
            string emailPattern = @"^[^@\s]+@[^@\s]+(\.[^@\s]+)+$";

            if (txtEmail.Text == "")
            {
                SetErrorMessages(txtEmail, "Email belum diisi!", "", "");
            }
            else if (!Regex.IsMatch(txtEmail.Text, emailPattern))
            {
                SetErrorMessages(txtEmail, "", "Format email salah!", "");
            }
            else
            {
                SetErrorMessages(txtEmail, "", "", "Betul!");
            }
        }

        private void txtKode_Leave(object sender, EventArgs e)
        {
            if (txtKode.Text == "")
            {
                SetErrorMessages(txtKode, "Kode Karyawan wajib diisi!", "", "");
            }
            else
            {
                SetErrorMessages(txtKode, "", "", "Betul!");
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                SetErrorMessages(txtPassword, "Password wajib diisi!", "", "");
            }
            // Minimal 8 karakter
            else if (txtPassword.Text.Length < 8)
            {
                SetErrorMessages(txtPassword, "Password terlalu pendek (min 8)!", "", "");
            }
            else
            {
                SetErrorMessages(txtPassword, "", "", "Betul!");
            }
        }

        private void txtKonfirmasi_Leave(object sender, EventArgs e)
        {
            if (txtKonfirmasi.Text == "")
            {
                SetErrorMessages(txtKonfirmasi, "Konfirmasi password wajib diisi!", "", "");
            }
            // Membandingkan dengan txtPassword
            else if (txtKonfirmasi.Text != txtPassword.Text)
            {
                SetErrorMessages(txtKonfirmasi, "", "Password tidak cocok!", "");
            }
            else
            {
                SetErrorMessages(txtKonfirmasi, "", "", "Cocok!");
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtNama.Text != "" && txtTelepon.Text != "" && txtEmail.Text != "" &&
                txtKode.Text != "" && txtPassword.Text == txtKonfirmasi.Text)
            {
                MessageBox.Show(
                    "Nama : " + txtNama.Text + "\n" +
                    "Telepon : " + txtTelepon.Text + "\n" +
                    "Email : " + txtEmail.Text + "\n" +
                    "Kode : " + txtKode.Text + "\n\n" +
                    "Data Berhasil Disimpan!",
                    "Informasi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else
            {
                MessageBox.Show("Mohon lengkapi data dengan benar!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

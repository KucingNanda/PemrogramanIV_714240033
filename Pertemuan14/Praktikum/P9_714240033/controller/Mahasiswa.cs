using MySql.Data.MySqlClient;
using P9_714240033.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P9_714240033.controller
{
    internal class Mahasiswa
    {
        Koneksi koneksi = new Koneksi();

        public bool Insert(M_mahasiswa mahasiswa)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();

                var cmd = new MySqlCommand(
                    "INSERT INTO t_mahasiswa (npm, nama, angkatan, alamat, email, nohp) " +
                    "VALUES (@npm, @nama, @angkatan, @alamat, @email, @nohp)"
                );

                cmd.Parameters.AddWithValue("@npm", mahasiswa.Npm);
                cmd.Parameters.AddWithValue("@nama", mahasiswa.Nama);
                cmd.Parameters.AddWithValue("@angkatan", mahasiswa.Angkatan);
                cmd.Parameters.AddWithValue("@alamat", mahasiswa.Alamat);
                cmd.Parameters.AddWithValue("@email", mahasiswa.Email);
                cmd.Parameters.AddWithValue("@nohp", mahasiswa.Nohp);

                koneksi.ExecuteQuery(cmd);

                status = true;
                MessageBox.Show("Data berhasil ditambahkan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal Insert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                koneksi.CloseConnection();
            }
            return status;
        }

        public bool Update(M_mahasiswa mahasiswa, string id)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                var cmd = new MySqlCommand(
                    "UPDATE t_mahasiswa SET nama=@nama, angkatan=@angkatan, " +
                    "alamat=@alamat, email=@email, nohp=@nohp WHERE npm=@npm");

                cmd.Parameters.AddWithValue("@npm", mahasiswa.Npm);
                cmd.Parameters.AddWithValue("@nama", mahasiswa.Nama);
                cmd.Parameters.AddWithValue("@angkatan", mahasiswa.Angkatan);
                cmd.Parameters.AddWithValue("@alamat", mahasiswa.Alamat);
                cmd.Parameters.AddWithValue("@email", mahasiswa.Email);
                cmd.Parameters.AddWithValue("@nohp", mahasiswa.Nohp);

                koneksi.ExecuteQuery(cmd);
                status = true;
                MessageBox.Show("Data berhasil Diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                koneksi.CloseConnection();
            }
            return status;
        }

        public bool Delete(string id)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                var cmd = new MySqlCommand("DELETE FROM t_mahasiswa WHERE npm=@id");
                cmd.Parameters.AddWithValue("@id", id);

                koneksi.ExecuteQuery(cmd);
                status = true;
                MessageBox.Show("Data berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal Hapus", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                koneksi.CloseConnection();
            }
            return status;
        }
    }
}

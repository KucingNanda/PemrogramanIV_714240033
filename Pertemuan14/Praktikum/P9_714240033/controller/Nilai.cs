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
    internal class Nilai
    {
        Koneksi koneksi = new Koneksi();

        // 1. METHOD INSERT
        public bool Insert(M_nilai nilai)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                var cmd = new MySqlCommand(
                    "INSERT INTO t_nilai (matkul, kategori, npm, nilai) " +
                    "VALUES (@matkul, @kategori, @npm, @nilai)");

                cmd.Parameters.AddWithValue("@matkul", nilai.Matkul);
                cmd.Parameters.AddWithValue("@kategori", nilai.Kategori);
                cmd.Parameters.AddWithValue("@npm", nilai.Npm);
                cmd.Parameters.AddWithValue("@nilai", nilai.Nilai);

                koneksi.ExecuteQuery(cmd);
                status = true;
                MessageBox.Show("Data berhasil ditambahkan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal Insert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { koneksi.CloseConnection(); }
            return status;
        }

        // 2. METHOD UPDATE
        public bool Update(M_nilai nilai, string id)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                var cmd = new MySqlCommand(
                    "UPDATE t_nilai SET matkul=@matkul, kategori=@kategori, " +
                    "npm=@npm, nilai=@nilai WHERE id_nilai=@id");

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@matkul", nilai.Matkul);
                cmd.Parameters.AddWithValue("@kategori", nilai.Kategori);
                cmd.Parameters.AddWithValue("@npm", nilai.Npm);
                cmd.Parameters.AddWithValue("@nilai", nilai.Nilai);

                koneksi.ExecuteQuery(cmd);
                status = true;
                MessageBox.Show("Data berhasil diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { koneksi.CloseConnection(); }
            return status;
        }

        // 3. METHOD DELETE
        public bool Delete(string id)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                var cmd = new MySqlCommand("DELETE FROM t_nilai WHERE id_nilai=@id");
                cmd.Parameters.AddWithValue("@id", id);

                koneksi.ExecuteQuery(cmd);
                status = true;
                MessageBox.Show("Data berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal Hapus", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { koneksi.CloseConnection(); }
            return status;
        }
    }
}

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using P9_714240033.model;

namespace P9_714240033.controller
{
    internal class Barang
    {
        Koneksi koneksi = new Koneksi();

        // TAMPIL DATA (READ)
        public DataTable Tampil()
        {
            DataTable data = new DataTable();
            try
            {
                string query = "SELECT * FROM t_barang";
                data = koneksi.ShowData(query);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return data;
        }

        // INSERT
        public bool Insert(M_barang barang)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                var cmd = new MySqlCommand("INSERT INTO t_barang (nama_barang, harga) VALUES (@nama, @harga)", koneksi.kon);
                cmd.Parameters.AddWithValue("@nama", barang.Nama_barang);
                cmd.Parameters.AddWithValue("@harga", barang.Harga);
                koneksi.ExecuteQuery(cmd);
                status = true;
                MessageBox.Show("Berhasil Tambah Barang", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e) { MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { koneksi.CloseConnection(); }
            return status;
        }

        // UPDATE
        public bool Update(M_barang barang, string id)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                var cmd = new MySqlCommand("UPDATE t_barang SET nama_barang=@nama, harga=@harga WHERE id_barang=@id", koneksi.kon);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@nama", barang.Nama_barang);
                cmd.Parameters.AddWithValue("@harga", barang.Harga);
                koneksi.ExecuteQuery(cmd);
                status = true;
                MessageBox.Show("Berhasil Update Barang", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e) { MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { koneksi.CloseConnection(); }
            return status;
        }

        // DELETE
        public bool Delete(string id)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                var cmd = new MySqlCommand("DELETE FROM t_barang WHERE id_barang=@id", koneksi.kon);
                cmd.Parameters.AddWithValue("@id", id);
                koneksi.ExecuteQuery(cmd);
                status = true;
                MessageBox.Show("Berhasil Hapus Barang", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e) { MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { koneksi.CloseConnection(); }
            return status;
        }

        public DataTable CariData(string keyword)
        {
            string query = "SELECT * FROM t_barang WHERE nama_barang LIKE @keyword OR id_barang LIKE @keyword";

            MySqlParameter[] parameters = {
            new MySqlParameter("@keyword", "%" + keyword + "%")
            };

            return koneksi.ShowDataParam(query, parameters);
        }
    }
}

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
    internal class Transaksi
    {
        Koneksi koneksi = new Koneksi();

        // TAMPIL DATA (JOIN)
        public DataTable Tampil()
        {
            string query = "SELECT t.id_transaksi, t.id_barang, b.nama_barang, b.harga, t.qty, t.total " +
                           "FROM t_transaksi t JOIN t_barang b ON t.id_barang = b.id_barang";
            return koneksi.ShowData(query);
        }

        // INSERT
        public bool Insert(M_Transaksi trans)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                MySqlDataReader reader = koneksi.reader("SELECT * FROM t_transaksi WHERE id_barang = '" + trans.Id_barang + "'");
                if (reader.Read())
                {
                    MessageBox.Show("Data Barang ini sudah ada di transaksi! Silakan lakukan Update.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    reader.Close();
                    koneksi.CloseConnection();
                    return false;
                }
                reader.Close();

                var cmd = new MySqlCommand("INSERT INTO t_transaksi (id_barang, qty, total) VALUES (@id_barang, @qty, @total)", koneksi.kon);
                cmd.Parameters.AddWithValue("@id_barang", trans.Id_barang);
                cmd.Parameters.AddWithValue("@qty", trans.Qty);
                cmd.Parameters.AddWithValue("@total", trans.Total);

                koneksi.ExecuteQuery(cmd);
                status = true;
                MessageBox.Show("Transaksi Berhasil", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e) { MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { koneksi.CloseConnection(); }
            return status;
        }

        // UPDATE
        public bool Update(M_Transaksi trans, string id)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                var cmd = new MySqlCommand("UPDATE t_transaksi SET id_barang=@id_barang, qty=@qty, total=@total WHERE id_transaksi=@id", koneksi.kon);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@id_barang", trans.Id_barang);
                cmd.Parameters.AddWithValue("@qty", trans.Qty);
                cmd.Parameters.AddWithValue("@total", trans.Total);

                koneksi.ExecuteQuery(cmd);
                status = true;
                MessageBox.Show("Transaksi Berhasil Diubah", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                var cmd = new MySqlCommand("DELETE FROM t_transaksi WHERE id_transaksi=@id", koneksi.kon);
                cmd.Parameters.AddWithValue("@id", id);
                koneksi.ExecuteQuery(cmd);
                status = true;
                MessageBox.Show("Transaksi Dihapus", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e) { MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { koneksi.CloseConnection(); }
            return status;
        }

        public DataTable CariData(string keyword)
        {
            string query = "SELECT t.id_transaksi, t.id_barang, b.nama_barang, b.harga, t.qty, t.total " +
                           "FROM t_transaksi t JOIN t_barang b ON t.id_barang = b.id_barang " +
                           "WHERE t.id_transaksi LIKE @key OR b.nama_barang LIKE @key";

            MySqlParameter[] parameters = {
            new MySqlParameter("@key", "%" + keyword + "%")
            };

            return koneksi.ShowDataParam(query, parameters);
        }
    }
}
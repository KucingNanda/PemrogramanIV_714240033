using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace P9_714240033
{
    internal class Koneksi
    {
        string connectionString = "Server=localhost; Database=pemrog2ulbi; Uid=root; Pwd=;";
        MySqlConnection kon;

        public void OpenConnection()
        {
            kon = new MySqlConnection(connectionString);
            kon.Open();
        }

        public void CloseConnection()
        {
            kon.Close();
        }

        public DataTable ShowData(string query)
        {
            OpenConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, kon);
            DataTable table = new DataTable();
            adapter.Fill(table);

            CloseConnection();
            return table;
        }
    }
}
